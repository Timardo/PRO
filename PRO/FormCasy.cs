using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PRO
{
    public partial class FormCasy : Form
    {
        public static TextBox Out;
        public static Action CurrentAction = Action.Start;
        public static List<DateTime> Zoznam = new List<DateTime>();
        public static List<DateTime> Zoznam2 = new List<DateTime>();
        public static int EntriesLeft = 0;
        public static int ZoznamIndex = 0;
        public FormCasy()
        {
            InitializeComponent();
            Out = textBox1;
            Out.AppendText("Zadaj počet udalostí" + Environment.NewLine);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                try
                {
                    HandleEnter(((TextBox)sender).Text.Substring(((TextBox)sender).Text.LastIndexOf(Environment.NewLine)));
                }

                catch
                {
                    Out.AppendText("Neznámy príkaz, skús to znovu" + Environment.NewLine);
                }
        }

        private void HandleEnter(string arg)
        {
            switch (CurrentAction)
            {
                case Action.Start:
                    {
                        EntriesLeft = int.Parse(arg);
                        CurrentAction = Action.Hodnoty;
                        Out.AppendText("Hodnoty časov ho formáte hh:mm: " + Environment.NewLine);
                    }
                    break;

                case Action.Hodnoty:
                    {
                        string[] split = arg.Split(':');
                        int hours = int.Parse(split[0]);
                        int minutes = int.Parse(split[1]);
                        Zoznam.Add(new DateTime(0, 0, 0, hours, minutes, 0));
                        EntriesLeft--;

                        if (EntriesLeft < 1)
                        {
                            CurrentAction = Action.EsteJedna;
                            Zoznam.Sort();
                        }
                    }
                    break;

                case Action.EsteJedna:
                    {
                        string[] split = arg.Split(':');
                        int hours = int.Parse(split[0]);
                        int minutes = int.Parse(split[1]);
                        DateTime insert = new DateTime(0, 0, 0, hours, minutes, 0);

                        foreach (DateTime dt in Zoznam)
                        {
                            if (dt > insert)
                            {
                                Zoznam.Insert(Zoznam.IndexOf(dt), insert);
                                break;
                            }
                        }

                        CurrentAction = Action.Vyber;
                        Zoznam2 = new List<DateTime>(Zoznam);

                        for (int i = 0; i < Zoznam.Count; i++)
                            if (Math.Abs(Zoznam[i].Hour * 60 + Zoznam[i].Minute - Zoznam[i + 1].Hour * 60 - Zoznam[i + 1].Minute) <= 10)
                            {
                                Out.AppendText("Dvojica časov 1. - " + Zoznam[i].ToShortTimeString() + " a 2. - " + Zoznam[i + 1].ToShortTimeString() + " je v nepríjemnej blízkosti, zadaj 1 alebo 2 pre ponechanie jedného času");
                                break;
                            }
                    }
                    break;

                case Action.Vyber:
                    {
                        

                        ZoznamIndex++;

                        if (ZoznamIndex >= Zoznam.Count)
                            CurrentAction = Action.Presun;
                    }
                    break;


            }



        }
    }

    public enum Action
    {
        Start,
        Hodnoty,
        EsteJedna,
        Vyber,
        Presun,
        Neviem
    }
}
