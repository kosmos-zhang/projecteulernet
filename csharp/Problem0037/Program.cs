using System;

namespace Problem0037
{
    class Program
    {
        /// <summary>
        /// The number 3797 has an interesting property. Being prime itself, it is possible to continuously remove digits from left to right, and remain prime at each stage: 3797, 797, 97, and 7. Similarly we can work from right to left: 3797, 379, 37, and 3.
        /// Find the sum of the only eleven primes that are both truncatable from left to right and right to left.
        /// NOTE: 2, 3, 5, and 7 are not considered to be truncatable primes.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            long s = 0;
            long c = 10;
            int i = 0;
            while(i < 11)
            {
                if (IsPrime(c) && TruncatablePrime(c))
                {
                    Console.WriteLine(c);
                    s += c;
                    i ++;
                }
                c++;
            }

            Console.WriteLine(s);
        }

        static bool IsPrime(long v)
        {
            if (v < 2)
            {
                return false;
            }

            for (int i = (int)Math.Sqrt(v); i>=2; i --)
            {
                if (v % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static bool TruncatablePrime(long val)
        {
            long d = 10;
            long x = val / d;
            long y = val % d;

            while (x > 0)
            {
                if (x == 1 || y == 1)
                {
                    return false;
                }

                if (!IsPrime(x) || !IsPrime(y))
                {
                    return false;
                }

                d *= 10;
                x = val / d;
                y = val % d;
            }

            return true;
        }
    }
}
