using Nakov.TurtleGraphics;
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
    public partial class FormTurtle : Form
    {
        public FormTurtle()
        {
            InitializeComponent();
        }

        private void Stvorec_Click(object sender, EventArgs e)
        {
            try
            {
                float strana = float.Parse(Input.Text);
                Turtle.ShowTurtle = false;
                Turtle.PenSize = 1;

                for (int i = 0; i < 4; i++)
                {
                    Turtle.Forward(strana);
                    Turtle.Rotate(90);
                }
            }

            catch
            {
                MessageBox.Show("Ďalej to už nepôjde, formát: strana(float)");
            }
        }

        private void Obdlznik_Click(object sender, EventArgs e)
        {
            try
            {
                string[] split = Input.Text.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                float stranaX = float.Parse(split[0]);
                float stranaY = float.Parse(split[1]);
                Turtle.ShowTurtle = false;
                Turtle.PenSize = 1;

                for (int i = 0; i < 2; i++)
                {
                    Turtle.Forward(stranaY);
                    Turtle.Rotate(90);
                    Turtle.Forward(stranaX);
                    Turtle.Rotate(90);
                }
            }

            catch
            {
                MessageBox.Show("Ďalej to už nepôjde, formát: stranaX(float), stranaY(float)");
            }
        }

        private void StvorecSpin_Click(object sender, EventArgs e)
        {
            try
            {
                float strana = float.Parse(Input.Text);
                Turtle.ShowTurtle = false;
                Turtle.PenSize = 1;

                for (int k = 0; k < 3; k++)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        Turtle.Forward(strana);
                        Turtle.Rotate(90);
                    }

                    Turtle.Rotate(-6);
                }
            }

            catch
            {
                MessageBox.Show("Ďalej to už nepôjde, formát: strana(float)");
            }
        }

        private void Schody_Click(object sender, EventArgs e)
        {
            try
            {
                string[] split = Input.Text.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                float strana = float.Parse(split[0]);
                int pocet = Convert.ToInt32(split[1]);
                Turtle.ShowTurtle = false;
                Turtle.PenSize = 1;
                Turtle.RotateTo(90);

                for (int k = 0; k < pocet; k++)
                {
                    Turtle.Forward(strana);
                    Turtle.Rotate(-90);
                    Turtle.Forward(strana);
                    Turtle.RotateTo(90);
                }
            }

            catch
            {
                MessageBox.Show("Ďalej to už nepôjde, formát: strana(float), počet(int)");
            }
        }

        private void Ciara_Click(object sender, EventArgs e)
        {
            try
            {
                string[] split = Input.Text.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                float strana = float.Parse(split[0]);
                int pocet = Convert.ToInt32(split[1]);
                float medzera = float.Parse(split[2]);
                Turtle.ShowTurtle = false;
                Turtle.PenSize = 1;
                Turtle.RotateTo(90);

                for (int k = 0; k < pocet; k++)
                {
                    Turtle.Forward(strana);
                    Turtle.PenUp();
                    Turtle.Forward(medzera);
                    Turtle.PenDown();
                }
            }

            catch
            {
                MessageBox.Show("Ďalej to už nepôjde, formát: dĺžka-čiary(float), počet-čiar(int), dĺžka-medzery(float)");
            }
        }

        private void Ciara2_Click(object sender, EventArgs e)
        {
            try
            {
                string[] split = Input.Text.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                float grow = float.Parse(split[0]);
                int pocet = Convert.ToInt32(split[1]);
                float medzera = float.Parse(split[2]);
                Turtle.ShowTurtle = false;
                Turtle.PenSize = 1;
                Turtle.RotateTo(90);

                for (int k = 0; k < pocet; k++)
                {
                    Turtle.Forward(grow);
                    Turtle.PenUp();
                    Turtle.Forward(medzera);
                    Turtle.PenDown();
                    grow += grow;
                }
            }

            catch
            {
                MessageBox.Show("Ďalej to už nepôjde, formát: plus-dĺžka(float), počet-čiar(int), veľkosť-medzery(float)");
            }
        }

        private void Hexagon_Click(object sender, EventArgs e)
        {
            try
            {
                float strana = float.Parse(Input.Text);
                Turtle.ShowTurtle = false;
                Turtle.PenSize = 1;
                Turtle.RotateTo(90);

                for (int k = 0; k < 6; k++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        Turtle.Forward(strana);
                        Turtle.Rotate(60);
                    }

                    Turtle.Forward(strana);
                    Turtle.Rotate(-60);
                }
            }

            catch
            {
                MessageBox.Show("Ďalej to už nepôjde, formát: strana(float)");
            }
        }

        private void StvorecSpiral_Click(object sender, EventArgs e)
        {
            try
            {
                float strana = float.Parse(Input.Text);
                Turtle.ShowTurtle = false;
                Turtle.PenSize = 1;

                while (strana > 1)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        Turtle.Forward(strana);
                        Turtle.Rotate(90);
                    }

                    Turtle.Rotate(-6);
                    strana -= (strana / 100) * 2;
                }
            }

            catch
            {
                MessageBox.Show("Ďalej to už nepôjde, formát: strana(float)");
            }
        }

        private void TrojuholnikSpiral_Click(object sender, EventArgs e)
        {
            try
            {
                float strana = float.Parse(Input.Text);
                Turtle.ShowTurtle = false;
                Turtle.PenSize = 1;
                Turtle.RotateTo(180);

                while (strana > 1)
                {
                    Turtle.PenUp();
                    Turtle.Forward((float) Math.Sqrt(3) / 3f * strana);
                    Turtle.Rotate(150);
                    Turtle.PenDown();

                    for (int i = 0; i < 3; i++)
                    {
                        Turtle.Forward(strana);
                        Turtle.Rotate(120);
                    }
                    Turtle.Rotate(30);
                    Turtle.Forward((float)Math.Sqrt(3) / 3f * strana);
                    Turtle.Rotate(186);
                    strana -= (strana / 100) * 2;
                }
            }

            catch
            {
                MessageBox.Show("Ďalej to už nepôjde, formát: strana(float)");
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Turtle.Reset();
        }
    }
}
