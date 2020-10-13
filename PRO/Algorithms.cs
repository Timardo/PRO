using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PRO
{
    class Algorithms
    {
        public static int[][] DajPole(int x, int y)
        {
            int[][] pole = new int[x][];

            for (int i = 0; i < pole.Length; i++)
            {
                pole[i] = new int[y];
            }

            return pole;
        }

        public static string DajDoMatice(int[][] pole)
        {
            string ret = "";

            foreach (int[] radek in pole)
            {
                radek.ToList().ForEach(x => ret += x + " ");
                ret += Environment.NewLine;
            }

            return ret;
        }

        internal static string Cvic1()
        {
            return DajDoMatice(DajPole(7, 7));
        }

        internal static string Cvic2()
        {
            int[][] pole = DajPole(8, 4);

            for (int i = 0; i < 32; i++)
            {
                pole[i / 4][i % 4] = i + 1;
            }

            return DajDoMatice(pole);
        }

        internal static string Cvic3()
        {
            int[][] pole = DajPole(6, 9);
            Random r = new Random((int)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds));

            for (int i = 0; i < 54; i++)
            {
                pole[i / 9][i % 9] = r.Next(1, 101);
            }
            string komplet = DajDoMatice(pole);
            int[] tempRadek = pole[0];
            pole[0] = pole[5];
            pole[5] = tempRadek;
            komplet += "------------------------" + Environment.NewLine + DajDoMatice(pole);
            return komplet;
        }

        internal static string Cvic4()
        {
            int[][] pole = DajPole(7, 7);
            Random r = new Random((int)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds));

            for (int i = 0; i < 49; i++)
            {
                pole[i / 7][i % 7] = r.Next(1, 101);
            }

            string komplet = DajDoMatice(pole) + "-----------------" + Environment.NewLine;

            pole.ToList().ForEach(radek => { int max = 101; radek.ToList().ForEach(x => { if (x < max) max = x; }); komplet += max + Environment.NewLine; });
            return komplet;
        }

        internal static string Cvic5()
        {
            string[] matice = new string[28];
            int[][] pole1 = new int[5][];
            int[][] pole2 = new int[5][];
            int[][] pole10by5 = new int[10][]; //c
            int[][] pole5by10 = new int[5][]; //c
            Random r = new Random((int)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds));

            for (int i = 0; i < 25; i++)
            {
                if (i < 5)
                {
                    pole1[i] = new int[5];
                    pole2[i] = new int[5];
                    pole10by5[i] = new int[5]; //c
                    pole10by5[i + 5] = new int[5]; //c
                    pole5by10[i] = new int[10]; //d
                    matice[23 + i] = "X X X X X Y Y Y Y Y"; //d
                }

                pole1[i / 5][i % 5] = r.Next(-100, 101);
                pole2[i / 5][i % 5] = r.Next(-100, 101);
                pole10by5[i / 5][i % 5] = pole1[i / 5][i % 5]; //c
                pole10by5[i / 5 + 5][i % 5] = pole2[i / 5][i % 5]; //c
                pole5by10[i / 5][i % 5] = pole1[i / 5][i % 5]; //d
                pole5by10[i / 5][i % 5 + 5] = pole2[i / 5][i % 5]; //d
                matice[i / 5] += pole1[i / 5][i % 5] + " "; //a, b
                matice[i / 5 + 6] += pole2[i / 5][i % 5] + " "; //a, b
                matice[i / 5 + 12] += pole1[i / 5][i % 5] + " ";
                matice[i / 5 + 17] += pole2[i / 5][i % 5] + " ";
                matice[i / 5 + 23] = matice[i / 5 + 23].Insert(matice[i / 5 + 23].IndexOf("X"), pole1[i / 5][i % 5].ToString()).Replace(pole1[i / 5][i % 5] + "X", pole1[i / 5][i % 5].ToString());
                matice[i / 5 + 23] = matice[i / 5 + 23].Insert(matice[i / 5 + 23].IndexOf("Y"), pole2[i / 5][i % 5].ToString()).Replace(pole2[i / 5][i % 5] + "Y", pole2[i / 5][i % 5].ToString());
            }

            List<string> file1 = matice.ToList().GetRange(0, 5); //b
            List<string> file2 = matice.ToList().GetRange(6, 5); //b
            file1.Insert(0, "5 5"); //b
            file2.Insert(0, "5 5"); //b
            File.WriteAllLines(Application.StartupPath + "/mat1.txt", file1); //b
            File.WriteAllLines(Application.StartupPath + "/mat2.txt", file2); //b
            return string.Join(Environment.NewLine, matice) + Environment.NewLine + "Súbory sú uložené v priečinku: " + Application.StartupPath;
        }

        internal static string Cvic6(string input)
        {
            string ret = "Najvyššie body [x, y]: ";
            int[][] pole = new int[60][];
            Random r = new Random((int)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds));

            for (int i = 0; i < 3600; i++)
            {
                if (i < 60)
                    pole[i] = new int[60];

                pole[i / 60][i % 60] = r.Next(0, 101);
            }

            int max = 0;
            int min = 0;
            List<int[]> maxPts = new List<int[]>();
            int[] latestMax = new int[2];
            List<int[]> minPts = new List<int[]>();

            for (int i = 0; i < 3600; i++)
            {
                if (pole[i / 60][i % 60] == max)
                    maxPts.Add(new int[2] { i / 60, i % 60 });

                if (pole[i / 60][i % 60] == min)
                    minPts.Add(new int[2] { i / 60, i % 60 });

                if (pole[i / 60][i % 60] < min)
                {
                    minPts.Clear();
                    min = pole[i / 60][i % 60];
                    minPts.Add(new int[2] { i / 60, i % 60 });
                }

                if (pole[i / 60][i % 60] > max)
                {
                    if (maxPts.Count > 0)
                    {
                        latestMax[0] = maxPts[0][0];
                        latestMax[1] = maxPts[0][1];
                    }

                    maxPts.Clear();
                    max = pole[i / 60][i % 60];
                    maxPts.Add(new int[2] { i / 60, i % 60 });
                }
            }

            maxPts.ForEach(x => ret += "[" + x[0] + ", " + x[1] + "], ");
            ret.Remove(ret.Length - 2);
            ret += Environment.NewLine + "Najnižšie body [x, y]: ";
            minPts.ForEach(x => ret += "[" + x[0] + ", " + x[1] + "], ");
            ret.Remove(ret.Length - 2);

            if (maxPts.Count >= 2)
            {
                latestMax[0] = maxPts[1][0];
                latestMax[1] = maxPts[1][1];
            }

            ret += Environment.NewLine + "Vzdialenosť dvoch prvých najvyšších bodov je: " + Math.Sqrt(Math.Pow(latestMax[0] - maxPts[0][0], 2) + Math.Pow(latestMax[1] - maxPts[0][1], 2)) + Environment.NewLine;
            max = 0;
            int[] pos = new int[2];
            int h;

            for (int i = 0; i < 3600; i++)
            {
                if (i / 60 != 0) //north
                {
                    h = pole[i / 60 - 1][i % 60] - pole[i / 60][i % 60];

                    if (h > max)
                    {
                        max = h;
                        pos[0] = i / 60;
                        pos[1] = i % 60;
                    }
                }

                if (i % 60 != 0) //west
                {
                    h = pole[i / 60][i % 60 - 1] - pole[i / 60][i % 60];

                    if (h > max)
                    {
                        max = h;
                        pos[0] = i / 60;
                        pos[1] = i % 60;
                    }
                }

                if (i % 60 != 59) //east
                {
                    h = pole[i / 60][i % 60 + 1] - pole[i / 60][i % 60];

                    if (h > max)
                    {
                        max = h;
                        pos[0] = i / 60;
                        pos[1] = i % 60;
                    }
                }

                if (i / 60 != 59) //south
                {
                    h = pole[i / 60 + 1][i % 60] - pole[i / 60][i % 60];

                    if (h > max)
                    {
                        max = h;
                        pos[0] = i / 60;
                        pos[1] = i % 60;
                    }
                }
            }

            ret += "Poklad sa nachádza na pozícii [x, y]: [" + pos[0] + ", " + pos[1] + "] (rozdiel " + max + "m)" + Environment.NewLine;
            int voda = 0;

            try
            {
                voda = int.Parse(input);

                if (voda < 0 || voda > 100)
                    throw new FormatException();
            }

            catch
            {
                return ret + Environment.NewLine + "Ďalej to už nepôjde, správny formát: výška_vody(int)[0-100]";
            }

            List<int[]> toProcess = new List<int[]>();
            int[][] vodaPole = pole.Select(x => x.ToArray()).ToArray();

            for (int i = 0; i < 60; i++)
            {
                if (pole[0][i] <= voda)
                {
                    toProcess.Add(new int[2] { 0, i });
                    vodaPole[0][1] = 65536;
                }
            }

            if (toProcess.Count < 1)
                return ret += "Bohužiaľ na severe nie je výška reliéfu dostatočne nízka na zaplavenie";

            while (true)
            {
                int x = toProcess[0][0];
                int y = toProcess[0][1];
                toProcess.RemoveAt(0);

                if (x != 0) //north
                {
                    if (vodaPole[x - 1][y] != 65536 && vodaPole[x - 1][y] <= voda)
                    {
                        toProcess.Add(new int[2] { x - 1, y });
                        vodaPole[x - 1][y] = 65536;
                    }
                }

                if (y != 0) //west
                {
                    if (vodaPole[x][y - 1] != 65536 && vodaPole[x][y - 1] <= voda)
                    {
                        toProcess.Add(new int[2] { x, y -1 });
                        vodaPole[x][y - 1] = 65536;
                    }
                }

                if (y!= 59) //east
                {
                    if (vodaPole[x][y + 1] != 65536 && vodaPole[x][y + 1] <= voda)
                    {
                        toProcess.Add(new int[2] { x, y + 1});
                        vodaPole[x][y + 1] = 65536;
                    }
                }

                if (x != 59) //south
                {
                    if (vodaPole[x + 1][y] != 65536 && vodaPole[x + 1][y] <= voda)
                    {
                        toProcess.Add(new int[2] { x + 1, y });
                        vodaPole[x + 1][y] = 65536;
                    }
                }

                if (toProcess.Count == 0)
                    break;
            }

            string[] lines = new string[183];
            lines[121] = "┌────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐";
            lines[182] = "└────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘";

            for (int i = 0; i < 3600; i++)
            {
                lines[i / 60] += "[" + (pole[i / 60][i % 60] / 100 > 0 ? "" + pole[i / 60][i % 60] : (pole[i / 60][i % 60] / 10 > 0) ? " " + pole[i / 60][i % 60] : " " + pole[i / 60][i % 60] + " ") + "]";
                lines[i / 60 + 61] += "[" + (vodaPole[i / 60][i % 60] == 65536 ? "XXX" : vodaPole[i / 60][i % 60] / 100 > 0 ? "" + vodaPole[i / 60][i % 60] : (vodaPole[i / 60][i % 60] / 10 > 0) ? " " + vodaPole[i / 60][i % 60] : " " + vodaPole[i / 60][i % 60] + " ") + "]";
                lines[i / 60 + 122] += (i % 60 == 0 ? "│" : "") + (vodaPole[i / 60][i % 60] == 65536 ? "██" : "  ") + (i % 60 == 59 ? "│" : "");
            }

            return ret + string.Join(Environment.NewLine, lines) + Environment.NewLine + "Základné pole + pole zaliate vodou + farebne odlíšené zobrazenie (odporúčam zobraziť v outpute)";
        }
    }
}
