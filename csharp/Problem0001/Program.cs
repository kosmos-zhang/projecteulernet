using System;

namespace projecteulernet
{
    /// <summary>
    /// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
    /// Find the sum of all the multiples of 3 or 5 below 1000.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Multiples of 3 and 5
            int result = 0;
            int mul3 = 0;
            int mul5 = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (i - mul3 == 3 && i - mul5 == 5)
                {
                    result += i;
                    mul3 = i;
                    mul5 = i;
                    Console.Write(i + ",");
                }
                else if (i - mul3 == 3)
                {
                    result += i;
                    mul3 = i;
                    Console.Write(i + ",");
                }
                else if (i - mul5 == 5)
                {
                    result += i;
                    mul5 = i;
                    Console.Write(i + ",");
                }
            }

            Console.Write("result is :" + result);
        }
    }
}
