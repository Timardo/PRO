using System;
using System.Globalization;

namespace PRO
{
    class Algorithms
    {
        internal static string OdVikendaDoVikenda(string input)
        {
            try
            {
                int year = int.Parse(input);
                int pocet = 0;
                DateTime dt = new DateTime(year, 1, 1);
                string output = "";

                for (; ; )
                {
                    if (dt.DayOfWeek == DayOfWeek.Saturday)
                    {
                        output += "Sobota: " + dt.Day + "." + dt.Month + Environment.NewLine;
                        dt = dt.AddDays(1);
                        pocet++;
                        if (dt.Year != int.Parse(input)) break;
                    }

                    if (dt.DayOfWeek == DayOfWeek.Sunday)
                    {
                        output += "Nedeľa: " + dt.Day + "." + dt.Month + Environment.NewLine;
                        dt = dt.AddDays(5);
                        pocet++;
                        if (dt.Year != int.Parse(input)) break;
                    }

                    dt = dt.AddDays(1);
                }

                return output + "Počet víkendových dní: " + pocet;
            }

            catch
            {
                return "Ďalej to už nepôjde, správny formát: rok(int+)";
            }
        }

        internal static string Piatky13(string text)
        {
            try
            {
                int rok = int.Parse(text);
                DateTime dt = new DateTime(rok, 1, 13);
                string output = "Na piatok 13. v roku " + text + " sa možno tešiť v tieto mesiace: ";
                
                for (int i = 1; i < 12; i++)
                {
                    if (dt.DayOfWeek == DayOfWeek.Friday)
                    {
                        output += dt.Month + ". ";
                    }

                    dt = dt.AddMonths(1);
                }

                dt = DateTime.Now;
                string dalsi = "Bohužiaľ najbližší piatok 13. bude ";
                for (; ; )
                {
                    if (dt.Day != 13)
                    {
                        dt = dt.AddDays(1);
                        continue;
                    }

                    if (dt.DayOfWeek == DayOfWeek.Friday)
                    {
                        dalsi += dt.ToLocalTime().ToShortDateString();
                        break;
                    }

                    else dt = dt.AddMonths(1);
                }

                if (output.EndsWith(": ")) return "Žiadne piatky 13. v roku " + text + "! " + dalsi;
                else return output + dalsi;
            }

            catch
            {
                return "Ďalej to už nepôjde, správny formát: rok(int+)";
            }
        }

        internal static string UnixY2k38()
        {
            DateTime dt = new DateTime(1970, 1, 1);
            dt = dt.AddSeconds(2147483647);

            return "Hrôzostrašný moment nastane " + dt.ToLocalTime().ToString();
        }
    }
}
