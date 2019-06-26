using System;
using System.Collections.Generic;

namespace Problem0020
{
    /// <summary>
    /// n! means n × (n − 1) × ... × 3 × 2 × 1
    /// For example, 10! = 10 × 9 × ... × 3 × 2 × 1 = 3628800,
    /// and the sum of the digits in the number 10! is 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27.
    /// Find the sum of the digits in the number 100!
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            List<int> res = new List<int>();
            res.Add(1);

            for (int i = 2; i < 100; i++)
            {
                int m = 0;
                for (int j = 0; j < res.Count; j ++)
                {
                    m = res[j] * i + m;
                    res[j] = m % 10;
                    m = m / 10;
                }
                while(m > 0)
                {
                    res.Add(m % 10);
                    m = m / 10;
                }
            }

            Int64 c = 0;
            foreach(int i in res)
            {
                c += i;
            }

            Console.WriteLine(c);
        }
    }
}
