using System;
using System.Collections.Generic;

namespace Problem0030
{
    class Program
    {
        /// <summary>
        /// Surprisingly there are only three numbers that can be written as the sum of fourth powers of their digits:
        /// 1634 = 1^4 + 6^4 + 3^4 + 4^4
        /// 8208 = 8^4 + 2^4 + 0^4 + 8^4
        /// 9474 = 9^4 + 4^4 + 7^4 + 4^4
        /// As 1 = 1^4 is not a sum it is not included.
        /// The sum of these numbers is 1634 + 8208 + 9474 = 19316.
        /// Find the sum of all the numbers that can be written as the sum of fifth powers of their digits.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            List<long> lst = new List<long>();
            for (long l = 10; ; l++)
            {
                char[] cst = l.ToString().ToCharArray();

                double d = 0;
                foreach(char c in cst)
                {
                    d += Math.Pow(Convert.ToDouble(c.ToString()), 5);
                }

                if (l == d)
                {
                    lst.Add(l);
                    Console.WriteLine(l);
                }

                if (l > cst.Length * 590490)
                {
                    break;
                }
            }

            long r = 0;
            foreach(long l in lst)
            {
                r += l;
            }

            Console.WriteLine(r);
        }
    }
}
