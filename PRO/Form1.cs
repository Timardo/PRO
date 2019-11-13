using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void Inicialy_Click(object sender, EventArgs e)
        {
            Output.AppendText(Algorithms.Inicialy(Input.Text) + Environment.NewLine);
        }

        private void Anagramy_Click(object sender, EventArgs e)
        {
            Output.AppendText(Algorithms.Anagramy(Input.Text) + Environment.NewLine);
        }

        private void yToZToY_Click(object sender, EventArgs e)
        {
            Output.AppendText(Algorithms.yToZToY(Input.Text) + Environment.NewLine);
        }

        private void slovakize_Click(object sender, EventArgs e)
        {
            Output.AppendText(Algorithms.Slovakize(Input.Text) + Environment.NewLine);
        }
    }
}
