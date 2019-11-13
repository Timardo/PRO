using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PRO
{
    class Algorithms
    {
        internal static string Nahrad(string text)
        {
            string znak = text.Substring(0, 1);
            string nahradit = text.Substring(1);
            nahradit = nahradit.Replace(znak, "#");
            return znak + nahradit;
        }

        internal static string NahradPosledny(string text)
        {
            try
            {
                string[] split = text.Split(';');
                string retazec = split[0];
                string sub = split[1];
                string nahrada = split[2];

                string[] bezNahrady = retazec.Split(new string[] { sub }, StringSplitOptions.None);
                int amount = bezNahrady.Length - 1;
                int lastIndexOfSub = retazec.Length - bezNahrady.Last().Length - sub.Length; //index posledného výskytu sub v reťazci
                string posledny = retazec.Substring(lastIndexOfSub); //obsahuje posledný výskyt subu a ostatok, čo je za ním
                posledny = posledny.Replace(sub, nahrada);
                string _out = retazec.Substring(0, lastIndexOfSub) + posledny;
                return _out;
            }

            catch
            {
                return "Ďalej to už nepôjde, formát: pôvodny-reťazec;hľadaný-podreťazec;náhrada";
            }
        }

        internal static string Samohlasky(string text)
        {
            int count = text.ToLower().Count(c => c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'y' || c == 'á' || c == 'ä' || c == 'é' || c == 'í' || c == 'ó' || c == 'ú' || c == 'ý');
            return "Veta '" + text + "' má " + count + " samohlások";
        }

        internal static string CMH(string text)
        {
            try
            {
                string[] vars = text.Split(';');
                string first = vars[0];
                string second = vars[1];
                string[] split = first.Split('*');
                string znak = second.Replace(split[0], "").Replace(split[1], "");

                if (first.Replace("*", znak) == second)
                    return "ANO";

                return "NIE";
            }

            catch
            {
                return "Ďalej to už nepôjde, formát: prvý-riadok;druhý-riadok";
            }
        }

        internal static string PrvePismena(string text)
        {
            string[] split = text.Split(' ');
            string _out = "";

            foreach (string s in split)
                _out += s[0];

            return _out;
        }

        internal static string Zhoda(string text)
        {
            try
            {
                string[] split = text.Split(';');
                string zhoda = "None";
                int max = 0;

                for (int i = 0; i < split[0].Length; i++)
                {
                    for (int j = split[0].Length - i; j > 0; j--)
                    {
                        string sub = split[0].Substring(i, j);

                        if (split[1].Contains(sub))
                        {
                            if (sub.Length > max)
                            {
                                max = sub.Length;
                                zhoda = sub;
                            }
                        }
                    }
                }

                return zhoda;
            }

            catch
            {
                return "Ďalej to už nepôjde, správny formát: veta1;veta2";
            }
        }

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
                        return "FALSE";

                    second = second.Substring(0, second.IndexOf(c)) + second.Substring(second.IndexOf(c) + 1);
                }

                if (second == "")
                    return "TRUE";

                 return "FALSE";
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

        internal static string Otacac(string text)
        {
            try
            {
                string[] split = text.Split(';');
                string veta = split[0];
                int vetaLen = veta.Length;
                int pocet = int.Parse(split[1]);
                pocet = pocet < 0 ? vetaLen + pocet : pocet;
            }

            catch
            {

            }

            return "ešte nefunguje";
        }

        internal static string Replace(string text)
        {
            try
            {
                string[] split = text.Split(';');
                char[] veta = split[0].ToCharArray();
                char stare = split[1][0];
                char nove = split[2][0];

                //return veta.Replace(stare, nove);

                for (int i = 0; i < veta.Length; i++)
                    if (veta[i] == stare)
                        veta[i] = nove;

                return new string(veta);
            }

            catch
            {
                return "Ďalej to už nepôjde, správny formát: veta;stary-znak;novy-znak";
            }
        }

        internal static string Zdvoj(string text)
        {
            string _out = "";

            foreach (char ch in text)
                if (ch != ' ')
                    _out += new string(ch, 2);

                else
                    _out += " ";

            return _out;
        }

        internal static string Soupa(string text)
        {
            int count = text.Count(c =>
                c == 'A' ||
                c == 'D' ||
                c == 'O' ||
                c == 'P' ||
                c == 'Q' ||
                c == 'R' ||
                c == 'a' ||
                c == 'b' ||
                c == 'd' ||
                c == 'e' ||
                c == 'g' ||
                c == 'o' ||
                c == 'p' ||
                c == 'q' ||
                c == '4' ||
                c == '6' ||
                c == '9' ||
                c == '0') + 2 * text.Count(c =>
                c == 'B' ||
                c == '8');

            return count.ToString();
        }

        internal static string Samostatne(string text)
        {
            string _out = "Tieto znaky sú v texte iba raz: ";

            foreach (char ch in text.ToLower())
            {
                if (text.Count(c => c == ch) == 1)
                    _out += ch + ", ";
            }

            return _out;
        }

        internal static string ObratVetu(string text)
        {
            int firstIndex = text.IndexOfAny(new char[] { '.', '?', '!' });
            string punct = "";

            if (firstIndex != -1)
            {
                punct = text.Substring(firstIndex);
                text = text.Substring(0, firstIndex);
            }

            string[] split = text.Split(' ');

            //string _out = split.Reverse().ToArray();
            string _out = "";

            for (int i = split.Length - 1; i >= 0; i--)
            {
                if (i != 0)
                    _out += split[i] + " ";
                else
                    _out += split[0] + punct;
            }

            return _out;
        }

        internal static string AkoVeta(string text)
        {
            string[] slova = text.Split(' ');

            for (int i = 0; i < slova.Length; i++)
            {
                if (i == 0 || slova[i - 1].EndsWith(".") || slova[i - 1].EndsWith("!") || slova[i - 1].EndsWith("?"))
                    slova[i] = slova[i].First().ToString().ToUpper() + slova[i].Substring(1).ToLower();

                else
                    slova[i] = slova[i].ToLower();
            }

            return string.Join(" ", slova);
        }
    }
}
