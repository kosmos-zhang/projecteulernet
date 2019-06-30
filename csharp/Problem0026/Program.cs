using System;
using System.Collections.Generic;

namespace Problem0026
{
    /// <summary>
    /// A unit fraction contains 1 in the numerator. The decimal representation of the unit fractions with denominators 2 to 10 are given:
    ///   1/2 = 0.5
    ///   1/3 = 0.(3)
    ///   1/4 = 0.25
    ///   1/5 = 0.2
    ///   1/6 = 0.1(6)
    ///   1/7 = 0.(142857)
    ///   1/8 = 0.125
    ///   1/9 = 0.(1)
    ///   1/10 = 0.1
    /// Where 0.1(6) means 0.166666..., and has a 1-digit recurring cycle.It can be seen that 1/7 has a 6-digit recurring cycle.
    /// Find the value of d< 1000 for which 1/d contains the longest recurring cycle in its decimal fraction part.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int maxd = 2;
            int maxrc = 0;
            for (int i =2; i < 1000; i++)
            {
                int rc = GetRecurringCycle(i);
                Console.WriteLine(string.Format("{0}({1})", i, rc));
                if (maxrc < rc)
                {
                    maxrc = rc;
                    maxd = i;
                }
            }

            Console.WriteLine(maxd);
        }

        static int GetRecurringCycle(int d)
        {
            int lft = 0;
            int a = 10;
            List<int> rcs = new List<int>();

            do
            {
                lft = a % d;

                if (rcs.Contains(lft))
                {
                    return rcs.Count - rcs.IndexOf(lft);
                }
                else
                {
                    rcs.Add(lft);
                    a = lft * 10;
                }
            }
            while (lft > 0);

            return 0;
        }
    }
}
