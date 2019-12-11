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

        private void Naplnit_Click(object sender, EventArgs e)
        {
            Output.AppendText(string.Join(", ", Algorithms.Naplnit()) + Environment.NewLine);
        }

        private void Uloha1_Click(object sender, EventArgs e)
        {
            Output.AppendText(Algorithms.Uloha1() + Environment.NewLine);
        }

        private void Uloha2_Click(object sender, EventArgs e)
        {
            Output.AppendText(Algorithms.Uloha2() + Environment.NewLine);
        }

        private void Uloha3_Click(object sender, EventArgs e)
        {
            Output.AppendText(Algorithms.Uloha3() + Environment.NewLine);
        }

        private void Uloha4_Click(object sender, EventArgs e)
        {
            Output.AppendText(Algorithms.Uloha4(Input.Text) + Environment.NewLine);
        }

        private void Uloha5_Click(object sender, EventArgs e)
        {
            Output.AppendText(Algorithms.Uloha5() + Environment.NewLine);
        }

        private void Uloha6_Click(object sender, EventArgs e)
        {
            Output.AppendText(Algorithms.Uloha6(Input.Text) + Environment.NewLine);
        }

        private void Uloha7_Click(object sender, EventArgs e)
        {
            Output.AppendText(Algorithms.Uloha7() + Environment.NewLine);
        }

        private void Uloha8_Click(object sender, EventArgs e)
        {
            Output.AppendText(Algorithms.Uloha8() + Environment.NewLine);
        }

        private void Uloha9_Click(object sender, EventArgs e)
        {
            Output.AppendText(Algorithms.Uloha9() + Environment.NewLine);
        }

        private void Uloha10_Click(object sender, EventArgs e)
        {
            Output.AppendText(Algorithms.Uloha10(Input.Text) + Environment.NewLine);
        }

        private void Sito_Click(object sender, EventArgs e)
        {
            Output.AppendText(Algorithms.Sito() + Environment.NewLine);
        }

        private void Uloha12_Click(object sender, EventArgs e)
        {
            Output.AppendText(Algorithms.Uloha12() + Environment.NewLine);
        }

        private void DNA_Click(object sender, EventArgs e)
        {
            Output.AppendText(Algorithms.DNA(Input.Text) + Environment.NewLine);
        }

        private void Uloha14_Click(object sender, EventArgs e)
        {
            Output.AppendText(Algorithms.Uloha14() + Environment.NewLine);
        }

        private void Spustitelne_Click(object sender, EventArgs e)
        {
            Output.AppendText(Algorithms.Spustitelne() + Environment.NewLine);
        }
    }
}
