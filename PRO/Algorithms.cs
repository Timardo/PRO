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
        internal static string Podpostupnost()
        {
            try
            {
                string[] nms = File.ReadAllText(Application.StartupPath + "/task1.txt").Split(',');
                List<int> cisla = new List<int>();
                int maxNeg = int.MinValue;

                for (int n = 0; n < nms.Length; n++)
                {
                    int k = int.Parse(nms[n]);
                    // odignorujem záporné čísla už na začiatku pre ušetrenie výpočtov
                    if (k <= 0)
                    {
                        if (cisla.Count > 0)
                            ;
                        else
                            maxNeg = Math.Max(maxNeg, k);

                        continue;
                    }

                    cisla.Add(k);

                }
                // v prípade, že sa budú nachádzať v zozname len záporné čísla, bude výsledkom najväčšie záporné číslo
                if (cisla.Count == 0)
                    return "Zoznam obsahujuje len záporné čísla, preto je výsledkom najvyššia záporná hodnota: " + maxNeg;

                int[] hodnoty = new int[cisla.Count];
                List<List<int>> postupnost = new List<List<int>>();
                hodnoty[0] = cisla[0];
                postupnost.Add(new List<int>() { cisla[0] });
                int maxIndex = 0;

                for (int i = 1; i < cisla.Count; i++)
                {
                    int maxlocal = 0;

                    for (int j = i - 1; j >= 0; j--)
                    {
                        if (cisla[i] >= cisla[j])
                        {
                            if (hodnoty[j] > maxlocal)
                            {
                                hodnoty[i] = hodnoty[j] + cisla[i];

                                if (maxlocal == 0)
                                {
                                    postupnost.Add(new List<int>(postupnost[j]));
                                    postupnost[i].Add(cisla[i]);
                                }

                                else
                                {
                                    postupnost[i] = new List<int>(postupnost[j]);
                                    postupnost[i].Add(cisla[i]);
                                }

                                maxlocal = hodnoty[j];
                            }
                        }

                        if (hodnoty[i] > hodnoty[maxIndex])
                            maxIndex = i;
                    }

                    if (postupnost.Count == i)
                    {
                        hodnoty[i] = cisla[i];
                        postupnost.Add(new List<int>() { cisla[i] });
                    }
                }

                return "Najväčšia postupnosť čísel je: [" + string.Join(", ", postupnost[maxIndex]) + "]" + Environment.NewLine + "Hodnota: " + hodnoty[maxIndex];
            }

            catch
            {
                return "Ďalej to už nepôjde, buď je zlý formát súboru alebo nie je možné nájsť súbor \"task1.txt\" v priečinku s týmto programom.";
            }
        }
    }
}
