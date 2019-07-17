using System;
using System.Collections.Generic;

namespace problem0032
{
    class Program
    {
        /// <summary>
        /// We shall say that an n-digit number is pandigital if it makes use of all the digits 1 to n exactly once; 
        /// for example, the 5-digit number, 15234, is 1 through 5 pandigital.
        /// The product 7254 is unusual, as the identity, 39 × 186 = 7254, containing multiplicand, multiplier, 
        /// and product is 1 through 9 pandigital.
        /// Find the sum of all products whose multiplicand/multiplier/product identity can be written as a 1 through 9 pandigital.
        /// HINT: Some products can be obtained in more than one way so be sure to only include it once in your sum.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int s = 0;
            for (int i = 1; i <= 987; i++)
            {
                if (i % 10 == 0 || i / 10 == 1 % 10)
                {
                    continue;
                }

                for (int j = 123; j<=9876; j++)
                {
                    if (IsMulticand(i, j))
                    {
                        s += i * j;
                        Console.WriteLine(string.Format("{0}*{1}={2}", i, j, i*j));
                    }
                }
            }

            Console.WriteLine(s);
        }

        static bool IsMulticand(int i, int j)
        {
            List<char> cl = new List<char>();
            string r = string.Format("{0}{1}", i, j);
            foreach (char c in r.ToCharArray())
            {
                if (c=='0' || cl.Contains(c))
                {
                    return false;
                }
                cl.Add(c);
            }

            int m = i * j;
            r = string.Format("{0}", m);
            foreach(char c in r.ToCharArray())
            {
                if (c == '0' || cl.Contains(c))
                {
                    return false;
                }
                cl.Add(c);
            }

            return (cl.Count == 9);
        }
    }
}
