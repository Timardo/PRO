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

        private void MocninyXOd0Po10_Click(object sender, EventArgs e)
        {
            foreach (string line in Algorithms.GetMocninyXOd0Po10(Input.Text))
                Output.AppendText(line);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Output.ResetText();
        }

        private void Mocniny2PoX_Click(object sender, EventArgs e)
        {
            foreach (string line in Algorithms.GetMocniny2PoX(Input.Text))
                Output.AppendText(line);
        }

        private void Stvorec_Click(object sender, EventArgs e)
        {
            foreach (string line in Algorithms.GetStvorec(Input.Text))
                Output.AppendText(line);
        }

        private void Obdlznik_Click(object sender, EventArgs e)
        {
            foreach (string line in Algorithms.GetObdlznik(Input.Text))
                Output.AppendText(line);
        }

        private void Trojuholnik_Click(object sender, EventArgs e)
        {
            foreach (string line in Algorithms.GetTrojuholniky(Input.Text))
                Output.AppendText(line);
        }

        private void Kosostvorec_Click(object sender, EventArgs e)
        {
            foreach (string line in Algorithms.GetKosostvorec(Input.Text))
                Output.AppendText(line);
        }

        private void ShowOutput_Click(object sender, EventArgs e)
        {
            new FormOut(Output.Text).Show();
        }

        private void Kruh_Click(object sender, EventArgs e)
        {
            foreach (string line in Algorithms.GetKruh(Input.Text))
                Output.AppendText(line);
        }

        private void PresypacieHodiny_Click(object sender, EventArgs e)
        {
            foreach (string line in Algorithms.GetPresypacieHodiny(Input.Text))
                Output.AppendText(line);
        }

        private void Turtle_Click(object sender, EventArgs e)
        {
            new FormTurtle().Show();
        }
    }
}
