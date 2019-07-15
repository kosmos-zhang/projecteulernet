using System;
using System.Collections.Generic;

namespace Problem0031
{
    /// <summary>
    /// In England the currency is made up of pound, £, and pence, p, and there are eight coins in general circulation:
    /// 1p, 2p, 5p, 10p, 20p, 50p, £1 (100p) and £2 (200p).
    /// It is possible to make £2 in the following way:
    /// 1×£1 + 1×50p + 2×20p + 1×5p + 1×2p + 3×1p
    /// How many different ways can £2 be made using any number of coins?
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 1, 2, 5, 10, 20, 50, 100, 200 };

            GetCount(200, a, 7, "0");

            Console.WriteLine(sumLst.Count);
        }

        static List<string> sumLst = new List<string>();
        private static void GetCount(int sum, int[] a, int v, string cur)
        {
            if (sum == 0)
            {
                if (!sumLst.Contains(cur))
                {
                    sumLst.Add(cur);
                    Console.WriteLine(sumLst.Count + "\t" + cur);
                }
                return;
            }

            string tmp = "";
            if (v == 0)
            {
                tmp = string.Format("{0}+{1}*{2}", cur, sum / 1, 1);
                if (!sumLst.Contains(tmp))
                {
                    sumLst.Add(tmp);
                    Console.WriteLine(sumLst.Count + "\t" + tmp);
                }
                return;
            }


            for (int j = v;j>0;j--)
            {
                int m = sum / a[j];
                int n = sum % a[j];

                for (int i = m; i > 0; i--)
                {
                    tmp = string.Format("{0}+{1}*{2}", cur, i, a[j]);
                    GetCount(sum - i * a[j], a, j - 1, tmp);
                }

                tmp = string.Format("{0}", cur);
                GetCount(sum, a, j - 1, tmp);
            }
        }
    }
}
