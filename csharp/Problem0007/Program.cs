using System;
using System.Collections.Generic;

namespace Problem0007
{
    /// <summary>
    /// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
    /// What is the 10001st prime number?
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Int64 i = 2;
            List<Int64> lst = new List<Int64>();
            while(lst.Count < 10001)
            {
                if (IsPrime(i))
                {
                    lst.Add(i);
                }
                i++;
            }

            Console.WriteLine(lst[10000]);
            //104743
        }

        static bool IsPrime(Int64 val)
        {
            for (Int64 i = (Int64)Math.Sqrt(val); i >= 2; i--)
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
