using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Numerics;
using System.Windows.Forms;
using System.IO;

namespace PRO
{
    class Algorithms
    {
        internal static List<string> Naplnit()
        {
            List<string> ret = new List<string>();

            for (int i = 1; i <= 21; i++)
                if (Prvocislo(i))
                    ret.Add(i.ToString());

            List<string> switched = new List<string>(ret);
            switched[0] = ret[ret.Count - 1];
            switched[ret.Count - 1] = ret[0];
            List<string> added = new List<string>(switched);
            added.Insert(added.Count / 2, 1000.ToString());
            List<string> fujTri = new List<string>(added);
            fujTri.ForEach(element => { if (int.Parse(element) % 3 == 0) fujTri.Remove(element); });
            ret.Add("Vymena -> ");
            ret.AddRange(switched);
            ret.Add("Vložená 1000 -> ");
            ret.AddRange(added);
            ret.Add("Odstránené čísla deliteľné 3 -> ");
            ret.AddRange(fujTri);
            return ret;
        }

        internal static string Uloha2()
        {
            var zoznam = RandomIntList(15);
            string output = "Originál: " + Environment.NewLine + string.Join(Environment.NewLine, zoznam);
            var zoznam2 = new List<int>();

            for (int i = 0; i < zoznam.Count; i += 2)
            {
                zoznam2.Add(zoznam[i]);
            }

            output += Environment.NewLine + "Iba párne pozície: " + Environment.NewLine + string.Join(Environment.NewLine, zoznam2);
            return output;
        }

        internal static string Uloha5()
        {
            var zoznam = RandomIntList(15);
            return "Iba párne hodnoty: " + Environment.NewLine + string.Join(Environment.NewLine, Parne(zoznam));
        }

        internal static string Uloha6(string text)
        {
            try
            {
                int delitel = int.Parse(text);
                var zoznam = RandomIntList(300);
                return "Čísla z random zoznamu deliteľné " + delitel + ": " + Environment.NewLine + string.Join(Environment.NewLine, Delitelne(zoznam, delitel));
            }
            
            catch
            {
                return "Ďalej to už nepôjde, správny formát: deliteľ(int)";
            }
        }

        internal static string Uloha9()
        {
            var zoznam = RandomIntList(100);
            string znasobeny = Sucin(zoznam).ToString();
            return "Zoznam: " + string.Join(", ", zoznam) + Environment.NewLine + "Znásobené čísla: " + Environment.NewLine + znasobeny;
        }

        internal static string Uloha10(string input)
        {
            var chars = input.ToCharArray().ToList();
            var output = new List<string>();
            Iter(chars, output, "");

            return string.Join(Environment.NewLine, output);
        }

        internal static string Sito()
        {
            return "nefungujem";
            //var intList = IntList(2000);
            //int removed = 0;

            //for (int i = 0; i < 1000; i++)
            //{
            //    int remLoc = 0;

            //    for (int j = intList[i] * 2; j < intList.Count; j++)
            //    {
            //        if (intList[j - remLoc] % intList[i] == 0)
            //        {
            //            intList.RemoveAt(j - remLoc);
            //            remLoc++;
            //        }
            //    }

            //    removed += remLoc;
            //}

            //return string.Join(Environment.NewLine, intList);
        }

        internal static string Spustitelne()
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog()
            {
                IsFolderPicker = true,
                InitialDirectory = Application.StartupPath
            };

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                string[] files = Directory.GetFiles(dialog.FileName);
                string ret = "";

                foreach (string fileEntry in files)
                {
                    if (fileEntry.EndsWith(".cmd") || fileEntry.EndsWith(".bat") || fileEntry.EndsWith(".run") || fileEntry.EndsWith(".exe") || fileEntry.EndsWith(".com"))
                    ret += Path.GetFileName(fileEntry) + Environment.NewLine;
                }

                return ret;
            }

            return "";
        }

        internal static string Uloha14()
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog() {
                IsFolderPicker = true,
                InitialDirectory = Application.StartupPath
            };

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                string[] files = Directory.GetFiles(dialog.FileName);
                string ret = "";

                foreach (string fileEntry in files)
                {
                    double size = (new FileInfo(fileEntry).Length);
                    int i = 0;

                    while (size >= 1024)
                    {
                        size /= 1024;
                        i++;
                    }

                    string sizeS = i == 0 ? "B" : i == 1 ? "KB" : i == 2 ? "MB" : i == 3 ? "MB" : i == 4 ? "GB" : "TB";
                    ret += "Súbor " + Path.GetFileName(fileEntry) + " má veľkosť " + Math.Round(size, 6, MidpointRounding.AwayFromZero) + " " + sizeS + Environment.NewLine; 
                }

                return ret;
            }

            return "";
        }

        internal static string DNA(string text)
        {
            try
            {
                string indexy = "Indexy mutácii (0-based): ";
                string markers = "";
                string[] split = text.Split(';');

                for (int i = 0; i < Math.Min(split[0].Length, split[1].Length); i++)
                    if (split[0][i] != split[1][i])
                    {
                        indexy += i + ", ";
                        markers += "^";
                        continue;
                    }

                    else
                        markers += " ";

                indexy += Environment.NewLine + split[0] + Environment.NewLine + split[1] + Environment.NewLine + markers;

                return indexy;
            }

            catch
            {
                return "Ďalej to už nepôjde, správny formát: dna(string);mutovanéDna(string)";
            }
        }

        internal static string Uloha12()
        {
            var zoznam1 = RandomIntList(5);
            var zoznam2 = RandomIntList(5, 1);
            var zoznam3 = RandomIntList(5, 2);
            zoznam1.Sort();
            zoznam2.Sort();
            zoznam3.Sort();

            return "Originály -> " + string.Join(", ", zoznam1) + "   -   " + string.Join(", ", zoznam2) + "   -   " + string.Join(", ", zoznam3) + Environment.NewLine + "Merged -> " + string.Join(", ", Merge(zoznam1, zoznam2, zoznam3));
        }

        private static List<int> Merge(List<int> zoznam1, List<int> zoznam2, List<int> zoznam3)
        {
            int count = zoznam1.Count + zoznam2.Count + zoznam3.Count;
            zoznam1.Add(int.MaxValue);
            zoznam2.Add(int.MaxValue);
            zoznam3.Add(int.MaxValue);
            var ret = new List<int>();

            while (ret.Count < count)
            {
                int current = Math.Min(zoznam1[0], Math.Min(zoznam2[0], zoznam3[0]));

                if (!zoznam1.Remove(current))
                    if (!zoznam2.Remove(current))
                        zoznam3.Remove(current);

                ret.Add(current);

            }

            return ret;
        }

        private static List<int> IntList(int count)
        {
            List<int> ret = new List<int>();

            for (int i = 2; i < count; i++)
                ret.Add(i);

            return ret;
        }

        internal static void Iter(List<char> input, List<string> output, string part)
        {
            for (int i = 0; i < input.Count; i++)
            {
                var copy = new List<char>(input);
                copy.RemoveAt(i);

                if (copy.Count == 0)
                {
                    output.Add(part + input[i]);
                    continue;
                }

                Iter(copy, output, part + input[i]);
            }
        }

        private static object Sucin(List<int> zoznam)
        {
            BigInteger ret = 1;
            zoznam.ForEach(x => { ret = ret * x; });
            return ret;
        }

        internal static string Uloha8()
        {
            var zoznam = RandomIntList(500000);
            MessageBox.Show("Bude to chvíľu trvať, deduplikuje sa 500000 prvkov");
            var deduplikovany = Deduplikuj(zoznam);
            return "Originál: 500000 prvkov" + Environment.NewLine + "Deduplikovaný: " + deduplikovany.Count + " prvkov";
        }

        private static List<int> Deduplikuj(List<int> zoznam)
        {
            var ret = new List<int>();

            zoznam.ForEach(x => { if (!ret.Contains(x)) ret.Add(x); });
            return ret;
        }

        internal static string Uloha7()
        {
            var zoznam = RandomIntList(1000000);
            var maxIndexes = MaxIndex(zoznam);
            return "Indexy čísla " + zoznam[maxIndexes[0]] + ": " + Environment.NewLine + string.Join(Environment.NewLine, maxIndexes);
        }

        private static List<int> MaxIndex(List<int> zoznam)
        {
            var ret = new List<int>();
            int maxNum = 0;

            for (int i = 0; i < zoznam.Count; i++)
            {
                if (zoznam[i] > maxNum)
                {
                    ret.Clear();
                    ret.Add(i);
                    maxNum = zoznam[i];
                }

                else if (zoznam[i] == maxNum)
                    ret.Add(i);
            }

            return ret;
        }

        private static List<int> Delitelne(List<int> zoznam, int delitel)
        {
            var zoznam2 = new List<int>();

            foreach (int i in zoznam)
                if (i % delitel == 0)
                    zoznam2.Add(i);

            return zoznam2;
        }

        private static List<int> Parne(List<int> input)
        {
            input.ForEach(x => { if (x % 2 != 0) input.Remove(x); });
            return input;
        }

        internal static string Uloha4(string text)
        {
            try
            {
                int pocet = int.Parse(text);
                return pocet + " nepárnych čísel: " + Environment.NewLine + string.Join(Environment.NewLine, Neparne(pocet));
            }

            catch
            {
                return "Ďalej to už nepôjde, správny formát: počet(int)" + Environment.NewLine;
            }
        }

        private static List<int> Neparne(int pocet)
        {
            Random RNG = new Random(DateTime.Now.Millisecond);
            List<int> ret = new List<int>();
            int counter = 1;

            while (ret.Count < pocet)
            {
                counter += 2;
                ret.Add(counter);
            }

            return ret;
        }

        internal static string Uloha3()
        {
            var zoznam = RandomIntList(15);
            zoznam.ForEach(x => { if (x % 2 != 0) zoznam.Remove(x); });

            return "Iba párne hodnoty: " + Environment.NewLine + string.Join(Environment.NewLine, zoznam);
        }

        internal static string Uloha1()
        {
            var zoznam = RandomIntList(15);
            string output = "Originál: " + Environment.NewLine + string.Join(", " + Environment.NewLine, zoznam);
            // Array.Reverse(zoznam.ToArray());
            var zoznamReversed = new List<int>();

            foreach (int kek in zoznam)
            {
                zoznamReversed.Insert(0, kek);
            }

            output += Environment.NewLine + "Obrátený: " + Environment.NewLine + string.Join(", " + Environment.NewLine, zoznamReversed);
            return output;
        }

        public static bool Prvocislo(int cislo)
        {
            int delitele = 2;

            for (int i = 2; i <= cislo / 2; i++)
                if (cislo % i == 0)
                    delitele++;

            return delitele == 2;
        }

        public static List<int> RandomIntList(int max, int seed = 0)
        {
            List<int> output = new List<int>();
            Random RNG = new Random(DateTime.Now.Millisecond + seed);

            for (int i = 0; i < max; i++)
                output.Add(RNG.Next(-10000, 10000));

            return output;
        }

    }
}
