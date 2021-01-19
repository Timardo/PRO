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
        internal static string Pivot()
        {
            try
            {
                string[] nms = File.ReadAllText(Application.StartupPath + "/pivot.txt").Split(',');
                List<int> cisla = new List<int>();

                for (int n = 0; n < nms.Length; n++)
                    cisla.Add(int.Parse(nms[n]));

                int pivot = cisla.Last();
                int i = 0;
                int j = cisla.Count - 2;
                bool fw = true;

                while (true)
                {
                    if (i >= j)
                    {
                        cisla.Insert(i, pivot);
                        cisla.RemoveAt(cisla.Count - 1);
                        break;
                    }

                    if (fw)
                    {
                        if (cisla[i] > pivot)
                            fw = false;
                        else
                            i++;
                    }

                    else
                    {
                        if (cisla[j] < pivot)
                        {
                            int k = cisla[j];
                            cisla[j] = cisla[i];
                            cisla[i] = k;
                            fw = true;
                            i++;
                            j--;
                        }

                        else
                            j--;
                    }
                }

                return "Pivot: " + pivot + Environment.NewLine + "[" + string.Join(", ", cisla) + "]";
            }

            catch
            {
                return "Ďalej to už nepôjde, buď je zlý formát súboru alebo nie je možné nájsť súbor \"pivot.txt\" v priečinku s týmto programom.";
            }
        }
    }
}
