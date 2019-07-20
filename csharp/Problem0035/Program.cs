using System;
using System.Collections.Generic;

namespace Problem0035
{
    class Program
    {
        /// <summary>
        /// The number, 197, is called a circular prime because all rotations of the digits: 197, 971, and 719, are themselves prime.
        /// There are thirteen such primes below 100: 2, 3, 5, 7, 11, 13, 17, 31, 37, 71, 73, 79, and 97.
        /// How many circular primes are there below one million?
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            List<int> lst = new List<int>();
            for (int i = 2; i <= 1000000; i++)
            {
                if (IsPrime(i))
                {
                    lst.Add(i);
                }
            }

            List<int> res = new List<int>();
            for (int i = 0; i < lst.Count;)
            {
                List<int> cir = GetCirValues(lst[i]);
                bool isIn = true;
                foreach(int c in cir)
                {
                    if (!lst.Contains(c))
                    {
                        isIn = false;
                    }
                    else
                    {
                        lst.Remove(c);
                    }
                }

                if (isIn)
                {
                    res.AddRange(cir);
                }
            }


            Console.WriteLine(res.Count);
        }

        private static List<int> GetCirValues(int v)
        {
            List<int> cir = new List<int>();

            char[] cs = v.ToString().ToCharArray();
            for (int i = 0; i < cs.Length; i++)
            {
                int r = Convert.ToInt32(string.Concat(cs));
                if (!cir.Contains(r))
                {
                    cir.Add(r);
                }

                char c = cs[0];
                for (int j = 1; j < cs.Length; j++)
                {
                    cs[j - 1] = cs[j];
                }
                cs[cs.Length - 1] = c;
            }

            return cir;
        }

        static bool IsPrime(int v)
        {
            int x = 2;
            int y = v / x;

            while (x <= y)
            {
                if (x * y == v && y > 1)
                {
                    return false;
                }

                x ++;
                y = v / x;
            }

            return true;
        }
    }
}
