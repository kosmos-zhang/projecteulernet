using System;

namespace Problem0036
{
    class Program
    {
        /// <summary>
        /// The decimal number, 585 = 1001001001 2 (binary), is palindromic in both bases.
        /// Find the sum of all numbers, less than one million, which are palindromic in base 10 and base 2.
        /// (Please note that the palindromic number, in either base, may not include leading zeros.)
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            long sum = 0;
            for (int i = 1; i < 1000000; i++)
            {
                string s = i.ToString();
                char[] cs = s.ToCharArray();
                Array.Reverse(cs);
                if (!string.Concat(cs).Equals(s))
                {
                    continue;
                }

                s = Convert.ToString(i, 2);
                cs = s.ToCharArray();
                Array.Reverse(cs);
                if (!string.Concat(cs).Equals(s))
                {
                    continue;
                }

                sum += i;
            }

            Console.WriteLine(sum);
            // 872187
        }
    }
}
