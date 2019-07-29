using System;

namespace Problem4
{
    /// <summary>
    /// A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
    /// Find the largest palindrome made from the product of two 3-digit numbers.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 999998; i>100000; i --)
            {
                var ca = i.ToString().ToCharArray();
                Array.Reverse(ca);
                if (int.Parse(string.Join("", ca)) == i && Has3Factor(i))
                {
                    Console.Write(i + ",");
                }
            }

            // 906609
        }

        static bool Has3Factor(int val)
        {
            for (int i = (int)Math.Sqrt(val); i > 100; i--)
            {
                int j = val / i;
                if (val % i == 0 && j > 100 && j <1000 && i < 1000)
                {
                    Console.Write(i + "*" + j + ";");
                    return true;
                }
            }
            return false;
        }
    }
}
