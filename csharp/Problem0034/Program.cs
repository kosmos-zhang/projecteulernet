using System;

namespace Problem0034
{
    /// <summary>
    /// 145 is a curious number, as 1! + 4! + 5! = 1 + 24 + 120 = 145.
    /// Find the sum of all numbers which are equal to the sum of the factorial of their digits.
    /// Note: as 1! = 1 and 2! = 2 are not sums they are not included.
    /// </summary>
    class Program
    {
        static int m = fun(9);

        static void Main(string[] args)
        {
            long s = 0;
            long l = 3;
            while(true)
            {
                if (l == fact(l))
                {
                    Console.WriteLine(l);
                    s += l;
                }

                if (l > l.ToString().ToCharArray().Length * m)
                {
                    break;
                }

                l++;
            }

            Console.WriteLine(s);
        }

        private static long fact(long l)
        {
            int s = 0;
            foreach(char c in l.ToString().ToCharArray())
            {
                s += fun(c - '0');
            }

            return s;
        }
        public static int fun(int n)
        {
            int a = 1;
            for (int j = 2; j <= n; j++)
            {
                a = a * j;
            }
            return a;
        }
    }
}
