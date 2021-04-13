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
        internal static string MontyHall(string input)
        {
            try
            {
                bool[] dvere = new bool[3] { true, false, false }; // hádam nebude vadiť že každý test bude na rovnakom modeli, štatisticky by to malo byť ok a ušetrí to čas
                Random r = new Random();
                int iterations = int.Parse(input);
                int won1 = 0;
                int won2 = 0;
                // bez zmeny rozhodnutia
                for (int i = 0; i < iterations; i++)
                {
                    if (dvere[r.Next(0, 3)])
                        won1++; // prípad kedy si vyberie 1. dvere a nechá si ich
                    else // v druhom prípade odtránime kozu a zostane originálna možnosť a koza, čiže ak zmeníme rozhodnutie (a nevyhrali sme predtým), vyhráme
                        won2++;
                }

                return "Po " + iterations + " iteráciách program dospel k záveru, že v " + (float) won1 / (float) iterations * 100 + "% prípadov hráč vyhral ak dvere nezmenil a v " + (float) won2 / (float) iterations * 100 + "% ak dvere zmenil";
            }

            catch
            {
                return "Ďalej to už nepôjde, správny formát vstupu: max_iterations[int+]";
            }
            
        }
    }
}