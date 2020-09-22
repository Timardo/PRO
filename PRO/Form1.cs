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
            Output.AppendText(Algorithms.OdVikendaDoVikenda(Input.Text) + Environment.NewLine);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Output.AppendText(Algorithms.UnixY2k38() + Environment.NewLine);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Output.AppendText(Algorithms.Piatky13(Input.Text) + Environment.NewLine);
        }
    }
}
