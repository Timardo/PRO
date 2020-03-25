using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PRO
{
    public partial class Form1 : Form
    {
        private delegate void SafeCallDelegate(string text);
        public static volatile Connection connection = null;
        public static TextBox outputRef = null;
        public Thread connectionThread;

        public Form1()
        {
            InitializeComponent();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Output.ResetText();
        }

        private void ShowOutput_Click(object sender, EventArgs e)
        {
            new FormOut(Output.Text).Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Output.AppendText("Nefungujem" + Environment.NewLine);
            return;

            if (connection == null)
            {
                ThreadStart childref = new ThreadStart(startConnection);
                connectionThread = new Thread(childref);
                connectionThread.Start();
                Output.AppendText("Vytváram spojenie.." + Environment.NewLine);
            }

            else
            {
                Connection.waitingForInput = false;
                connection.sendMessage(Input.Text);
            }
        }

        public void startConnection()
        {
            outputRef = Output;
            connection = new Connection();
            connection.waitForInput();
        }

        public static void outputText(string text)
        {
            if (outputRef.InvokeRequired)
            {
                var d = new SafeCallDelegate(outputText);
                outputRef.Invoke(d, new object[] { text });
            }

            else
            {
                outputRef.AppendText(text);
            }
        }

        private void Painting_Click(object sender, EventArgs e)
        {
            new FormPaint(false).Show();
        }

        private void Smajliky_Click(object sender, EventArgs e)
        {
            new FormPaint(true).Show();
        }
    }

    public class Connection
    {
        TcpClient client;
        NetworkStream stream;
        public static volatile bool waitingForInput;

        public Connection()
        {
            client = new TcpClient();
            client.Connect("127.0.0.1", 25566);
            stream = client.GetStream();
            waitingForInput = true;
            Form1.outputText("Spojenie vytvorené!");

        }

        public void sendMessage(string message)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(message);
            stream.Write(bytes, 0, bytes.Length);
            stream.Flush();
            waitingForInput = true;
            waitForInput();
        }

        public void waitForInput()
        {
            while (waitingForInput)
            {
                byte[] responseData = new byte[client.ReceiveBufferSize];
                stream.Read(responseData, 0, client.ReceiveBufferSize);
                string responseText = Encoding.Unicode.GetString(responseData);
                Form1.outputText(responseText + Environment.NewLine);
            }
        }
    }
}
