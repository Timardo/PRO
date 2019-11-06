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

        private void Nahrad_Click(object sender, EventArgs e)
        {
            Output.AppendText(Algorithms.Nahrad(Input.Text) + Environment.NewLine);
        }

        private void NahradPosledny_Click(object sender, EventArgs e)
        {
            Output.AppendText(Algorithms.NahradPosledny(Input.Text) + Environment.NewLine);
        }

        private void AkoVeta_Click(object sender, EventArgs e)
        {
            Output.AppendText(Algorithms.AkoVeta(Input.Text) + Environment.NewLine);
        }

        private void ObratVetu_Click(object sender, EventArgs e)
        {
            Output.AppendText(Algorithms.ObratVetu(Input.Text) + Environment.NewLine);
        }

        private void Samohlasky_Click(object sender, EventArgs e)
        {
            Output.AppendText(Algorithms.Samohlasky(Input.Text) + Environment.NewLine);
        }

        private void SamostatneZnaky_Click(object sender, EventArgs e)
        {
            Output.AppendText(Algorithms.Samostatne(Input.Text) + Environment.NewLine);
        }

        private void ZenitOne_Click(object sender, EventArgs e)
        {
            Output.AppendText(Algorithms.CMH(Input.Text) + Environment.NewLine);
        }

        private void Soupa_Click(object sender, EventArgs e)
        {
            Output.AppendText(Algorithms.Soupa(Input.Text) + Environment.NewLine);
        }

        private void Zdvoj_Click(object sender, EventArgs e)
        {
            Output.AppendText(Algorithms.Zdvoj(Input.Text) + Environment.NewLine);
        }

        private void PrvePismena_Click(object sender, EventArgs e)
        {
            Output.AppendText(Algorithms.PrvePismena(Input.Text) + Environment.NewLine);
        }

        private void Menic_Click(object sender, EventArgs e)
        {
            Output.AppendText(Algorithms.Replace(Input.Text) + Environment.NewLine);
        }

        private void Zhoda_Click(object sender, EventArgs e)
        {
            Output.AppendText(Algorithms.Zhoda(Input.Text) + Environment.NewLine);
        }

        private void Otacac_Click(object sender, EventArgs e)
        {
            Output.AppendText(Algorithms.Otacac(Input.Text) + Environment.NewLine);
        }
    }
}
