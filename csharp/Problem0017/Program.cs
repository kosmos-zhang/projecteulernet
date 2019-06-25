using System;
using System.Collections.Generic;

namespace Problem0017
{
    /// <summary>
    /// If the numbers 1 to 5 are written out in words: one, two, three, four, five, then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.
    /// If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used?
    /// NOTE: Do not count spaces or hyphens.For example, 342 (three hundred and forty-two) contains 23 letters and 115 (one hundred and fifteen) contains 20 letters.The use of "and" when writing out numbers is in compliance with British usage.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> lst = new Dictionary<int, string>();

            lst.Add(1, "one");
            lst.Add(2, "two");
            lst.Add(3, "three");
            lst.Add(4, "four");
            lst.Add(5, "five");
            lst.Add(6, "six");
            lst.Add(7, "seven");
            lst.Add(8, "eight");
            lst.Add(9, "nine");
            lst.Add(10, "ten");
            lst.Add(11, "eleven");
            lst.Add(12, "twelve");
            lst.Add(13, "thirteen");
            lst.Add(14, "fourteen");
            lst.Add(15, "fifteen");
            lst.Add(16, "sixteen");
            lst.Add(17, "seventeen");
            lst.Add(18, "eighteen");
            lst.Add(19, "nineteen");
            lst.Add(20, "twenty");
            lst.Add(30, "thirty");
            lst.Add(40, "forty");
            lst.Add(50, "fifty");
            lst.Add(60, "sixty");
            lst.Add(70, "seventy");
            lst.Add(80, "eighty");
            lst.Add(90, "ninety");

            for (int i = 1; i <= 1000; i++)
            {
                if (lst.ContainsKey(i))
                {
                    continue;
                }

                if (i < 100)
                {
                    lst.Add(i, lst[i / 10 * 10] + "-" + lst[i % 10]);
                }
                else if (i == 1000)
                {
                    lst.Add(i, "one thousand");
                }
                else if (i % 100 == 0)
                {
                    lst.Add(i, lst[i / 100] + " hundred");
                }
                else
                {
                    lst.Add(i, lst[i / 100 * 100] + " and " + lst[i % 100]);
                }
            }

            int c = 0;
            for (int i = 1; i<= 1000; i++)
            {
                Console.WriteLine(lst[i]);
                c += lst[i].Replace(" ", "").Replace("-", "").Length;
            }
            Console.WriteLine(c);
        }
    }
}
