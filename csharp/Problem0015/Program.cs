using System;
using System.Collections.Generic;

namespace Problem0015
{
    class Program
    {
        /// <summary>
        /// Starting in the top left corner of a 2×2 grid, and only being able to move to the right and down, there are exactly 6 routes to the bottom right corner.
        /// How many such routes are there through a 20×20 grid?
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //     20     10       4       1
            //      ------------------------
            //     |       |       |       |
            //     |       |       |       |
            //     | 10    | 6     | 3     | 1
            //     |-------|-------|-------|
            //     |       |       |       |
            //     | 4     | 3     | 2     | 1
            //     |-------|-------|-------|
            //     |       |       |       |
            //     |       |       |       |
            //     -------------------------
            //     1       1       1       1

            Int64[,] dic = new Int64[101, 101];
            for (int i = 0; i < 51; i++)
            {
                dic[i, 0] = 1;
            }
            for (int j = 0; j < 51; j++)
            {
                dic[0, j] = 1;
            }

            for (int i =1; i< 51; i++)
            {
                for (int j = 1; j < 51; j++)
                {
                    dic[i, j] = dic[i - 1, j] + dic[i, j - 1];
                }
            }

            for (int i = 0; i < 51; i++)
            {
                for (int j = 0; j < 51; j++)
                {
                    Console.Write(dic[i, j] + "\t");
                }
                Console.WriteLine("");
            }

            Console.Write(dic[5, 5]);

            //Console.Write(RouteCount(20, 20));
        }

        static Int64 RouteCount(int x, int y)
        {
            if (x == 0)
            {
                return 1;
            }
            else if (y == 0)
            {
                return 1;
            }
            else
            {
                return RouteCount(x - 1, y) + RouteCount(x, y - 1);
            }
        }
    }
}
