using System;
using System.Collections.Generic;

namespace Problem0023
{
    /// <summary>
    /// A perfect number is a number for which the sum of its proper divisors is exactly equal to the number. 
    /// For example, the sum of the proper divisors of 28 would be 1 + 2 + 4 + 7 + 14 = 28, which means 
    /// that 28 is a perfect number.
    /// A number n is called deficient if the sum of its proper divisors is less than n and it is called 
    /// abundant if this sum exceeds n.
    /// As 12 is the smallest abundant number, 1 + 2 + 3 + 4 + 6 = 16, the smallest number that can be 
    /// written as the sum of two abundant numbers is 24. By mathematical analysis, it can be shown that all 
    /// integers greater than 28123 can be written as the sum of two abundant numbers. However, this upper 
    /// limit cannot be reduced any further by analysis even though it is known that the greatest number 
    /// that cannot be expressed as the sum of two abundant numbers is less than this limit.
    /// Find the sum of all the positive integers which cannot be written as the sum of two abundant numbers.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            List<int> abundlst = new List<int>();

            for (int i = 2; i<=28123; i++)
            {
                if (i < Abundant(i))
                {
                    abundlst.Add(i);
                }
            }

            long s = 28123 * (1 + 28123) / 2;

            List<int> sumabund = new List<int>();
            for (int i = 0; i < abundlst.Count; i++)
            {
                for (int j = i; j < abundlst.Count && abundlst[j]<= 28123 - abundlst[i]; j++)
                {
                    int sum = abundlst[i] + abundlst[j];
                    if (!sumabund.Contains(sum) && sum <= 28123)
                    {
                        s -= sum;
                        sumabund.Add(sum);
                    }
                }
            }

            Console.WriteLine(s);
        }

        static int Abundant(int val)
        {
            int s = 1;
            for (int j = (int)Math.Sqrt(val); j>1; j--)
            {
                if (val % j == 0)
                {
                    s += j;

                    if (j * j != val)
                    {
                        s += val / j;
                    }
                }
            }

            return s;
        }
    }
}
