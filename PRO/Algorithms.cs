using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PRO
{
    class Algorithms
    {
        internal static string Slovakize(string text)
        {
            return text.Replace('0', 'é').Replace('1', '+').Replace('2', 'ľ').Replace('3', 'š').Replace('4', 'č').Replace('5', 'ť').Replace('6', 'ž').Replace('7', 'ý').Replace('8', 'á').Replace('9', 'í');
        }

        internal static string yToZToY(string text)
        {
            char notHere = '¨';
            int i = 0;

            while (text.Contains(notHere) || notHere.ToString().ToLower() == "y" || notHere.ToString().ToLower() == "z")
                notHere = (char)i++;

            return text.Replace('z', notHere).Replace('y', 'z').Replace(notHere, 'y').Replace('Z', notHere).Replace('Y', 'Z').Replace(notHere, 'Y');
        }

        internal static string Anagramy(string text)
        {
            try
            {
                string[] split = text.Split(';');
                string first = split[0];
                string second = split[1];

                foreach (char c in first)
                {
                    if (second == "")
                        return "FALSE - slová nie sp anagramy";

                    second = second.Substring(0, second.IndexOf(c)) + second.Substring(second.IndexOf(c) + 1);
                }

                if (second == "")
                    return "TRUE - slová sú anagramy";

                 return "FALSE - slová nie sú anagramy";
            }

            catch
            {
                return "Ďalej to už nepôjde, správny formát: prvé-slovo;druhé-slovo";
            }
        }

        internal static string Inicialy(string text)
        {
            string[] parts = text.Split(' ');
            string _out = "";

            for (int i = 0; i < parts.Length - 1; i++)
                _out += parts[i].ToUpper()[0] + ". ";

            return _out + parts.Last().ToUpper()[0] + parts.Last().Substring(1);
        }
    }
}
