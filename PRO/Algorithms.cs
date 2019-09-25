﻿using System;
using System.Collections.Generic;

namespace PRO
{
    class Algorithms
    {
        public static List<string> GetMocninyXOd0Po10(string input)
        {
            List<string> output = new List<string>();

            try
            {
                float x = float.Parse(input);

                for (int i = 0; i <= 10; i++)
                    output.Add(Math.Pow(x, i) + Environment.NewLine);
            }

            catch
            {
                output.Add("Ďalej to už nepôjde, formát: x(float)" + Environment.NewLine);
            }

            return output;
        }

        public static List<string> GetMocniny2PoX(string input)
        {
            List<string> output = new List<string>();

            try
            {
                int x = Convert.ToInt32(input);

                for (int i = 0; i <= x; i++)
                    output.Add(Math.Pow(2, i) + Environment.NewLine);
            }

            catch
            {
                output.Add("Ďalej to už nepôjde, formát: x(int)" + Environment.NewLine);
            }

            return output;
        }

        public static List<string> GetStvorec(string input)
        {
            List<string> output = new List<string>();

            try
            {
                int strana = Convert.ToInt32(input);

                for (int i = 0; i < strana; i++)
                {
                    if (i == 0 || i == strana - 1)
                        output.Add(new string('*', strana) + Environment.NewLine);
                    else
                        output.Add("*" + new string(' ', strana - 2) + "*" + Environment.NewLine);
                }
            }

            catch
            {
                output.Add("Ďalej to už nepôjde, formát: strana(int)" + Environment.NewLine);
            }

            return output;
        }

        public static List<string> GetKosostvorec(string input)
        {
            List<string> output = new List<string>();

            try
            {
                int max = Convert.ToInt32(input);

                for (int i = 1; i < max / 2 + max % 2; i++)
                {
                    output.Insert(i - 1,
                        new string(' ', (max - ((i - 1) * 2 + 1 + (max + 1) % 2)) / 2) +
                        new string('*', (i - 1) * 2 + 1 + (max + 1) % 2) +
                        Environment.NewLine);

                    output.Insert(i, output[i - 1]);
                }

                output.Insert(max / 2 + max % 2 - 1, new string('*', max) + Environment.NewLine);
            }

            catch
            {
                output.Add("Ďalej to už nepôjde, formát: max-šírka(int)" + Environment.NewLine);
            }

            return output;
        }

        public static List<string> GetPresypacieHodiny(string input)
        {
            List<string> output = new List<string>();

            try
            {
                int max = Convert.ToInt32(input);

                for (int i = 1; i < max / 2 + max % 2; i++)
                {
                    output.Insert(i - 1,
                        new string(' ', (max - (max - 2 * (i - 1))) / 2) +
                        new string('*', max - 2 * (i - 1)) +
                        Environment.NewLine);

                    output.Insert(i, output[i - 1]);
                }

                output.Insert(max / 2 + max % 2 - 1, new string(' ', (max - (-(max % 2) + 2)) / 2) + new string('*', (-(max % 2) + 2)) + Environment.NewLine);
            }

            catch
            {
                output.Add("Ďalej to už nepôjde, formát: max-šírka(int)" + Environment.NewLine);
            }

            return output;
        }

        public static List<string> GetKruh(string input)
        {
            List<string> output = new List<string>();

            try
            {
                int radius = Convert.ToInt32(input);
                char[][] twoDimArray = new char[radius][];

                for (int k = 0; k < radius; k++)
                    twoDimArray[k] = new char[radius];

                for (int i = 1; i <= radius * radius; i++)
                    if (Math.Sqrt(Math.Pow((i - 1) % radius, 2) + Math.Pow((i - 1) / radius, 2)) <= radius && Math.Sqrt(Math.Pow((i - 1) % radius + 1, 2) + Math.Pow((i - 1) / radius + 1, 2)) > radius)
                        twoDimArray[(i - 1) % radius][(i - 1) / radius] = '*';
                    else
                        twoDimArray[(i - 1) % radius][(i - 1) / radius] = ' ';

                for (int j = radius - 1; j >= 0; j--)
                {
                    Array.Reverse(twoDimArray[j]);
                    string line = new string(twoDimArray[j]);
                    Array.Reverse(twoDimArray[j]);
                    output.Insert(radius - j - 1, line + new string(twoDimArray[j]) + Environment.NewLine);
                    output.Insert(radius - j, line + new string(twoDimArray[j]) + Environment.NewLine);
                }
            }

            catch
            {
                output.Add("Ďalej to už nepôjde, formát: radius-polomer(int)" + Environment.NewLine);
            }

            return output;
        }

        public static List<string> GetTrojuholniky(string input)
        {
            List<string> output = new List<string>();

            try
            {
                int amount = Convert.ToInt32(input);

                for (int i = 1; i <= amount; i++)
                    output.Add(
                        new string('*', i) +
                        new string(' ', amount - i) +
                        "    " +
                        new string('*', amount - i + 1) +
                        new string(' ', i - 1) +
                        "    " +
                        new string(' ', i - 1) +
                        new string('*', amount - i + 1) +
                        "    " +
                        new string(' ', amount - i) +
                        new string('*', i) +
                        Environment.NewLine);
            }

            catch
            {
                output.Add("Ďalej to už nepôjde, fomrát: počet-riadkov(int)" + Environment.NewLine);
            }

            return output;
        }

        public static List<string> GetObdlznik(string input)
        {
            List<string> output = new List<string>();

            try
            {
                string[] in_ = input.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                int stranaX = Convert.ToInt32(in_[0]);
                int stranaY = Convert.ToInt32(in_[1]);

                for (int i = 0; i < stranaY; i++)
                {
                    if (i == 0 || i == stranaY - 1)
                        output.Add(new string('*', stranaX) + Environment.NewLine);
                    else
                        output.Add("*" + new string(' ', stranaX - 2) + "*" + Environment.NewLine);
                }
            }

            catch
            {
                output.Add("Ďalej to už nepôjde, formát: stranaX(int), stranaY(int)" + Environment.NewLine);
            }

            return output;
        }
    }
}
