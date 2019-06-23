using System;

namespace Problem0009
{
    /// <summary>
    /// A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
    /// a^2 + b^2 = c^2
    /// For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.
    /// There exists exactly one Pythagorean triplet for which a + b + c = 1000.
    /// Find the product abc.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i<=333;i++)
            {
                for (int j = i+1; j < 1000; j++)
                {
                    int k = 1000 - i - j;
                    //Console.WriteLine(string.Format("{0}, {1}, {2}", i, j, k));
                    if (k <= j)
                    {
                        break;
                    }
                    else if (i + j <= k)
                    {
                        continue;
                    }

                    if (k * k == i * i + j * j)
                    {
                        Console.WriteLine(string.Format("{0}, {1}, {2}", i, j, k));
                        Console.WriteLine(string.Format("{0}", i * j * k));
                        return;
                    }
                }
            }
            Console.WriteLine("No value matches");
        }
    }
}
