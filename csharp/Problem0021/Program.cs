using System;
using System.Collections.Generic;

namespace Problem0021
{
    /// <summary>
    /// Let d(n) be defined as the sum of proper divisors of n (numbers less than n which divide evenly into n).
    /// If d(a) = b and d(b) = a, where a ≠ b, then a and b are an amicable pair and each of a and b are called amicable numbers.
    /// For example, the proper divisors of 220 are 1, 2, 4, 5, 10, 11, 20, 22, 44, 55 and 110; therefore d(220) = 284. The proper divisors of 284 are 1, 2, 4, 71 and 142; so d(284) = 220.
    /// Evaluate the sum of all the amicable numbers under 10000.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> amic = new Dictionary<int, int>();

            int res = 0;
            for (int i = 1; i<10000; i++)
            {
                int c = 0;
                if (!amic.ContainsKey(i))
                {
                    c = SumDivisors(i);
                    amic.Add(i, c);
                }

                if (amic.ContainsKey(c) && amic[c] == i && i != c)
                {
                    res += c;
                    res += i;
                }
            }

            Console.WriteLine(res);
        }

        static int SumDivisors(int val)
        {
            int c = 1;
            for (int i = (int)Math.Sqrt(val); i > 1; i--)
            {
                if (val % i == 0)
                {
                    c += i;

                    int d = val / i;
                    if (d != i)
                    {
                        c += d;
                    }
                }
            }

            return c;
        }
    }
}
