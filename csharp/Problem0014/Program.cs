using System;
using System.Collections.Generic;

namespace Problem0014
{
    /// <summary>
    /// The following iterative sequence is defined for the set of positive integers:
    ///     n → n/2 (n is even)
    ///     n → 3n + 1 (n is odd)
    /// Using the rule above and starting with 13, we generate the following sequence:
    ///     13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
    /// It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.
    /// Which starting number, under one million, produces the longest chain?
    /// NOTE: Once the chain starts the terms are allowed to go above one million.
    /// </summary>
    class Program
    {
        static Dictionary<Int64, int> seq = new Dictionary<Int64, int>();
        static void Main(string[] args)
        {
            seq.Add(1, 1);

            int c = 0;
            int max = 0;
            int maxval = 0;
            for (int i = 2; i < 1000000; i++)
            {
                c = CountSeq(i);
                if (c > max)
                {
                    max = c;
                    maxval = i;
                }
            }

            Console.Write(maxval);
        }

        static int CountSeq(Int64 val)
        {
            if (seq.ContainsKey(val))
            {
                return seq[val];
            }

            Int64 i = 0;
            int c = 0;
            if (val % 2 == 0)
            {
                i = val / 2;
            }
            else
            {
                i = val * 3 + 1;
            }

            if (seq.ContainsKey(i))
            {
                c = 1 + seq[i];
            }
            else
            {
                c = 1 + CountSeq(i);
            }

            if (!seq.ContainsKey(val))
            {
                seq.Add(val, c);
            }

            return c;
        }
    }
}
