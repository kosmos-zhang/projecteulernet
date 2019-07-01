using System;

namespace Problem0028
{
    /// <summary>
    /// Number spiral diagonals
    /// Starting with the number 1 and moving to the right in a clockwise direction a 5 by 5 spiral is formed as follows:s
    /// 21 22 23 24 25
    /// 20  7  8  9 10
    /// 19  6  1  2 11
    /// 18  5  4  3 12
    /// 17 16 15 14 13
    /// It can be verified that the sum of the numbers on the diagonals is 101.
    /// What is the sum of the numbers on the diagonals in a 1001 by 1001 spiral formed in the same way?
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            long[,] numdiag = new long[1001, 1001];

            int i = 500;
            int j = 500;

            long v = 1;
            int c = 1;

            numdiag[i, j] = v++;

            for (; c<= 500; c++)
            {
                numdiag[i, ++j] = v++;

                for (int x = 0; x < 2*c-1; x++)
                {
                    numdiag[++i, j] = v++;
                }
                for (int x = 0; x < 2 * c; x++)
                {
                    numdiag[i, --j] = v++;
                }
                for (int x = 0; x < 2 * c; x++)
                {
                    numdiag[--i, j] = v++;
                }
                for (int x = 0; x < 2 * c; x++)
                {
                    numdiag[i, ++j] = v++;
                }
            }

            long sum = 0;
            for (i = 0, j = 0; i < 1001; i++, j++)
            {
                sum += numdiag[i, j];
            }
            for (i = 0,j=1000; i < 1001; i++, j--)
            {
                sum += numdiag[i, j];
            }

            Console.WriteLine(sum - 1);
        }
    }
}
