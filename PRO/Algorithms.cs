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
        internal static string HeapSort()
        {
            try
            {
                List<int> heap = new List<int>();
                List<int> list = new List<int>();

                foreach (string numero in File.ReadAllText(Application.StartupPath + "/cisla.txt").Split(','))
                {
                    int numeroParsaro = int.Parse(numero);
                    list.Add(numeroParsaro);
                }

                string ret = "Originálna postupnosť: " + Environment.NewLine + "[" + string.Join(", ", list) + "]" + Environment.NewLine + Environment.NewLine;
                int lastIndex = 0;

                foreach (int numero in list)
                {
                    heap.Add(numero);

                    int tempIndex = lastIndex++;

                    while (tempIndex != 0 && numero > heap[(tempIndex - 1) / 2])
                    {
                        heap[tempIndex] = heap[(tempIndex - 1) / 2];
                        tempIndex = (tempIndex - 1) / 2;
                        heap[tempIndex] = numero;
                    }
                }

                ret += "Heap strom: " + Environment.NewLine + "[" + string.Join(", ", heap) + "]" + Environment.NewLine + Environment.NewLine;
                List<int> post = new List<int>();
                post.Add(RemoveRoot(heap));
                ret += "Vybraný koreň: " + post[0] + Environment.NewLine + "Postupnosť po odobratí koreňa: " + Environment.NewLine + "[" + string.Join(", ", heap) + "]" + Environment.NewLine + Environment.NewLine;



                while (heap.Count > 0)
                {
                    post.Add(RemoveRoot(heap));
                }

                return ret + "Zoradená postupnosť: " + Environment.NewLine + "[" + string.Join(", ", post) + "]";
            }

            catch
            {
                return "Ďalej to už nepôjde, buď je nesprávny formát súboru alebo súbor 'cisla.txt' v priečinku s týmto programom";
            }
        }

        private static int RemoveRoot(List<int> heap)
        {
            int ret = heap[0];
            int last = 0;
            heap[0] = heap[heap.Count - 1];
            heap.RemoveAt(heap.Count - 1);

            while (true)
            {
                if (last * 2 + 1 > heap.Count - 1) break;

                int max = 0;

                if (last * 2 + 1 == heap.Count - 1)
                    max = 1;
                else
                    max = Math.Max(heap[last * 2 + 1], heap[last * 2 + 2]) == heap[last * 2 + 1] ? 1 : 2;

                if (!(heap[last] < heap[last * 2 + max])) break;

                int n = heap[last * 2 + max];
                heap[last * 2 + max] = heap[last];
                heap[last] = n;
                last = last * 2 + max;
            }

            return ret;
        }
    }
}
