using System;
using System.Collections.Generic;

namespace Problem0016
{
    class Program
    {
        /// <summary>
        /// 2^15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.
        /// What is the sum of the digits of the number 2^1000?
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            List<int> v = new List<int>();
            v.Add(1);

            for (int m = 1; m <= 1000; m++)
            {
                int jw = 0;
                int r = 0;
                for (int i = 0; i < v.Count; i++)
                {
                    r = v[i] * 2 + jw;
                    v[i] = (r >= 10) ? (r - 10) : r;
                    jw = (r >= 10) ? 1 : 0;
                }
                if (jw > 0)
                {
                    v.Add(jw);
                }
            }

            Int64 k = 0;
            foreach(int i in v)
            {
                k += i;
            }

            Console.WriteLine(k);

            v.Reverse();
            Console.WriteLine(string.Concat(v));
        }
    }
}
