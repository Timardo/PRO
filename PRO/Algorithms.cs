using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PRO
{
    class Algorithms
    {
        public static string Palindrom(string input)
        {
            return "Zadaný text " + (JePalindrom(input, "") == input ? "je" : "nie je") + " palindrom";
        }

        public static string JePalindrom(string originalPart, string reversedPart)
        {
            if (originalPart.Length == 0)
                return reversedPart;

            reversedPart = originalPart.ToCharArray()[0] + reversedPart;
            originalPart = originalPart.Substring(1);

            return JePalindrom(originalPart, reversedPart);
        }

        internal static string MinNum(string text)
        {
            try
            {
                int num = int.Parse(text);

                if (num < 1)
                    throw new ArgumentException();
                List<int> list = new List<int>();
                Random r = new Random();

                for (int i = 0; i < num; i++)
                    list.Add(r.Next(0, int.MaxValue));

                return "Najmenšie číslo je " + AkeMinNum(list, 0, int.MaxValue);
            }

            catch
            {
                return "Ďalej to už nepôjde, správny formát: veľkosť_zoznamu(int+)[max. 9074]";
            }
        }

        internal static string Bludisko()
        {
            CommonOpenFileDialog bludiskoFile = new CommonOpenFileDialog
            {
                InitialDirectory = Application.StartupPath
            };

            if (bludiskoFile.ShowDialog() == CommonFileDialogResult.Ok)
            {
                string[] lines = File.ReadAllLines(bludiskoFile.FileName);
                char[][][] arrayInput = new char[lines.Length][][];

                for (int i = 0; i < arrayInput.Length; i++)
                {
                    arrayInput[i] = new char[lines[0].Length][];

                    for (int j = 0; j < lines[0].Length; j++)
                        arrayInput[i][j] = new char[2] { lines[i].ToCharArray()[j], (char) 210 };
                }

                char[][][] o = SolveBludisko(arrayInput, 0, new List<int[]>());

                if (o == null)
                    return "Bludisko nemá riešenie";
                
                string ret = "";
 
                for (int i = 0; i < o[0].Length + 2; i++)
                {
                    ret += "██";
                }

                ret += Environment.NewLine;

                for (int i = 0; i < o.Length; i++)
                {
                    ret += "██";

                    for (int j = 0; j < o[0].Length; j++)
                    {
                        ret += o[i][j][0] == '#' ? "██" : o[i][j][0] == '.' ? "  " : "▓▓";
                    }

                    ret += "██" + Environment.NewLine;
                }

                for (int i = 0; i < o[0].Length + 2; i++)
                {
                    ret += "██";
                }

                return ret;
            }

            return null;
        }

        private static char[][][] SolveBludisko(char[][][] arrayInput, int index, List<int[]> pointsList)
        {
            if (pointsList.Count == 0 && index == -1)
                return null;

            if (index != -1 && pointsList.Count == 0)
            {
                if (arrayInput[index / arrayInput.Length][index % arrayInput.Length][0] == 'S')
                {
                    arrayInput[index / arrayInput.Length][index % arrayInput.Length][0] = '*';
                    pointsList.Add(new int[2] { index / arrayInput.Length, index % arrayInput.Length });
                    return SolveBludisko(arrayInput, -1, pointsList);
                }

                return SolveBludisko(arrayInput, index + 1, pointsList);
            }

            if (arrayInput[pointsList[pointsList.Count - 1][0]][pointsList[pointsList.Count - 1][1]][0] == 'C')
                return arrayInput;

            int x = pointsList[pointsList.Count - 1][0];
            int y = pointsList[pointsList.Count - 1][1];
            int bit = arrayInput[x][y][1];

            if (bit % 2 == 0) //N
            {
                if (x - 1 >= 0)
                {
                    if (arrayInput[x - 1][y][0] == '.' && arrayInput[x - 1][y][1] != 1)
                    {
                        arrayInput[x - 1][y][0] = '*';
                        pointsList.Add(new int[] { x - 1, y });
                    }

                    else if (arrayInput[x - 1][y][0] == 'C')
                        pointsList.Add(new int[] { x - 1, y });

                    else
                        arrayInput[x][y][1] = (char)(arrayInput[x][y][1] / 2);
                }

                else
                    arrayInput[x][y][1] = (char) (arrayInput[x][y][1] / 2);
            }

            else if (bit % 3 == 0) //E
            {
                if (y + 1 < arrayInput[x].Length)
                {
                    if (arrayInput[x][y + 1][0] == '.' && arrayInput[x][y + 1][1] != 1)
                    {
                        arrayInput[x][y + 1][0] = '*';
                        pointsList.Add(new int[] { x, y + 1 });
                    }

                    else if (arrayInput[x][y + 1][0] == 'C')
                        pointsList.Add(new int[] { x, y + 1 });

                    else
                        arrayInput[x][y][1] = (char)(arrayInput[x][y][1] / 3);
                }

                else
                    arrayInput[x][y][1] = (char)(arrayInput[x][y][1] / 3);
            }


            else if (bit % 5 == 0) //S
            {
                if (x + 1 < arrayInput.Length)
                {
                    if (arrayInput[x + 1][y][0] == '.' && arrayInput[x + 1][y][1] != 1)
                    {
                        arrayInput[x + 1][y][0] = '*';
                        pointsList.Add(new int[] { x + 1, y });
                    }

                    else if (arrayInput[x][y + 1][0] == 'C')
                        pointsList.Add(new int[] { x + 1, y });

                    else
                        arrayInput[x][y][1] = (char)(arrayInput[x][y][1] / 5);
                }

                else
                    arrayInput[x][y][1] = (char)(arrayInput[x][y][1] / 5);
            }

            else if (bit % 7 == 0) //W
            {
                if (y - 1 >= 0)
                {
                    if (arrayInput[x][y - 1][0] == '.' && arrayInput[x][y - 1][1] != 1)
                    {
                        arrayInput[x][y - 1][0] = '*';
                        pointsList.Add(new int[] { x, y - 1});
                    }

                    else if (arrayInput[x][y - 1][0] == 'C')
                        pointsList.Add(new int[] { x, y - 1 });

                    else
                        arrayInput[x][y][1] = (char)(arrayInput[x][y][1] / 7);
                }

                else
                    arrayInput[x][y][1] = (char)(arrayInput[x][y][1] / 7);
            }

            else
            {
                arrayInput[x][y][0] = '.';
                pointsList.RemoveAt(pointsList.Count - 1);
            }

            return SolveBludisko(arrayInput, -1, pointsList);
        }

        private static int AkeMinNum(List<int> list, int i, int min)
        {
            if (list.Count == i + 1)
                return min;

            if (list[i] < min)
                min = list[i];

            i++;

            return AkeMinNum(list, i, min);
        }

        internal static string ListPerm(string text)
        {
                return "[" + string.Join("]" + Environment.NewLine + "[", Permutacie(text.Split(',').ToList(), 0, 0, 0, new List<string>())) + "]";
        }

        private static List<string> Permutacie(List<string> input, int index, int addCount, int copyCount, List<string> output)
        {
            if (input.Count == index)
                return output;

            if (index == 0)
            {
                output.Add(input[0]);
                return Permutacie(input, 1, 0, 0, output);
            }

            if (addCount < Fact(index))
            {
                output[addCount] += ", " + input[index];
                return Permutacie(input, index, addCount + 1, 0, output);
            }

            if (copyCount < index * addCount)
            {
                string str = output[copyCount / index];
                int nthIndex = Regex.Match(str, "((,).*?){" + (index - copyCount % index) + "}").Groups[2].Captures[index - copyCount % index - 1].Index;
                string left = str.Substring(nthIndex + 2);
                output.Add(left + ", " + str.Substring(0, nthIndex));
                return Permutacie(input, index, addCount, copyCount + 1, output);
            }

            return Permutacie(input, index + 1, 0, 0, output);
        }

        public static long Fact(long n)
        {
            if (n == 1)
                return 1;

            else
                return n * Fact(n - 1);
        }
    }
}
