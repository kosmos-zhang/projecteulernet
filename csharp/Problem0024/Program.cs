using System;
using System.Collections.Generic;

namespace Problem0024
{
    /// <summary>
    /// A permutation is an ordered arrangement of objects. For example, 3124 is one possible permutation of the digits 1, 2, 3 and 4. If all of the permutations are listed numerically or alphabetically, we call it lexicographic order. The lexicographic permutations of 0, 1 and 2 are:
    ///   012   021   102   120   201   210
    /// What is the millionth lexicographic permutation of the digits 0, 1, 2, 3, 4, 5, 6, 7, 8 and 9?
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lst = new List<int>();

            for (int i = 0; i <= 9; i++)
            {
                lst.Add(i);
            }

            // begin with 0, there're 9*8*7*6*5*4*3*2*1=362880 numbers
            // begin with 1, there're 9*8*7*6*5*4*3*2*1=362880 numbers
            // so we calc the numbers begin with 2

            // second with 0, there're 8*7*6*5*4*3*2*1= 40320
            // second with 1, there're 8*7*6*5*4*3*2*1= 40320
            // ...
            // we check it second with 7, and the lower counts are: 967680

            // ...  27***
            // 7 number can have numbers = 5040
            // so the third is 8, lower counts are 967680+5040*6=997920

            // ..  278**     720,    forth is 3,  lower number counts: 999360
            // ..  2783**    120,    fifth is 9,  lower number counts: 999960
            // ..  27839**    24,    sixth is 1,  lower number counts: 999984
            // ..  278391**    6,    seventh is 5, lower counts: 999996
            // ..  2783915*    2,    eigth is 4

            //     2783915460
         
            Console.WriteLine("Hello World!");
        }
    }
}
