using System;

namespace Problem3
{
    /// <summary>
    /// The prime factors of 13195 are 5, 7, 13 and 29.
    /// What is the largest prime factor of the number 600851475143 ?
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // The prime factors of 13195 are 5, 7, 13 and 29.
            // What is the largest prime factor of the number 600851475143 ?

            Int64 val = 600851475143;
            for (Int64 i = (Int64)Math.Sqrt(val); i > 1; i--)
            {
                if (val % i == 0 && IsEven(i))
                {
                    Console.Write(i);
                    return;
                }
            }

            // 6857
        }

        static bool IsEven(Int64 val)
        {
            for (Int64 i = (Int64)Math.Sqrt(val); i > 1; i--)
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
