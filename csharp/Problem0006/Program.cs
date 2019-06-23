using System;

namespace Problem0006
{
    /// <summary>
    /// The sum of the squares of the first ten natural numbers is,
    /// 1^2 + 2^2 + ... + 10^2 = 385
    /// The square of the sum of the first ten natural numbers is,
    /// (1 + 2 + ... + 10)^2 = 55^2 = 3025
    /// Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
    /// Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Int64 n = 0;            
            for (int i = 1; i <= 100; i++)
            {
                n += i * i;
            }

            int m = 0;
            for (int i = 0; i<=100; i++)
            {
                m += i;
            }

            Console.WriteLine(m * m - n);
        }
    }
}
