using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Windows.Forms;

namespace PRO
{
    class Algorithms
    {
        public static string Rekurzia(string input)
        {
            try
            {
                string[] split = input.Split(' ');
                double x = double.Parse(split[0]);
                int n = int.Parse(split[1]);

                return "Výsledok je " + Exponent(x, n);
            }

            catch
            {
                return "Ďalej to už nepôjde, sprábny formát: x(double) y(int)";
            }
        }

        public static double Exponent(double x, int n) => n == 1 ? x : n == 0 ? 1 : n / 2 * 2 == n ? Math.Pow(Exponent(x, n / 2), 2) : Math.Pow(Exponent(x, n / 2), 2) * x;
    }
}
