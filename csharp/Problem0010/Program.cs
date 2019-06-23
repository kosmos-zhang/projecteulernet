using System;

namespace Problem0010
{
    /// <summary>
    /// The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
    /// Find the sum of all the primes below two million.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Int64 sum = 0;
            for (int i = 2; i<= 2000000; i++)
            {
                if (IsPrime(i))
                {
                    sum += i;
                }
            }

            Console.WriteLine(sum);
        }

        static bool IsPrime(int val)
        {
            for (int i = (int)Math.Sqrt(val); i >= 2; i --)
            {
                if (val % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
