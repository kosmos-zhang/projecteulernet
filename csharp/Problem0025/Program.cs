using System;
using System.Collections.Generic;

namespace Problem0025
{
    /// <summary>
    /// The Fibonacci sequence is defined by the recurrence relation:
    /// Fn = Fn−1 + Fn−2, where F1 = 1 and F2 = 1.
    /// Hence the first 12 terms will be:
    /// F1 = 1
    /// F2 = 1
    /// F3 = 2
    /// F4 = 3
    /// F5 = 5
    /// F6 = 8
    /// F7 = 13
    /// F8 = 21
    /// F9 = 34
    /// F10 = 55
    /// F11 = 89
    /// F12 = 144
    /// The 12th term, F12, is the first term to contain three digits.
    /// What is the index of the first term in the Fibonacci sequence to contain 1000 digits?
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lst1 = new List<int>();
            List<int> lst2 = new List<int>();

            lst1.Add(1);
            lst2.Add(1);

            int i = 2;
            bool iseven = false;
            while (lst1.Count<1000 && lst2.Count < 1000)
            {
                if (iseven)
                {
                    int j = 0;
                    int m = 0;
                    for (; j < lst1.Count && j<lst2.Count; j++)
                    {
                        int k = lst1[j] + lst2[j] + m;
                        if (k >= 10)
                        {
                            lst1[j] = k - 10;
                            m = 1;
                        }
                        else
                        {
                            lst1[j] = k;
                            m = 0;
                        }
                    }
                    while (j<lst1.Count)
                    {
                        int k = lst1[j] + m;
                        if (k >= 10)
                        {
                            lst1[j] = k - 10;
                            m = 1;
                        }
                        else
                        {
                            lst1[j] = k;
                            m = 0;
                        }
                        j++;
                    }
                    while (j < lst2.Count)
                    {
                        int k = lst2[j] + m;
                        if (k >= 10)
                        {
                            lst1.Add(k - 10);
                            m = 1;
                        }
                        else
                        {
                            lst1.Add(k);
                            m = 0;
                        }
                        j++;
                    }
                    if (m > 0)
                    {
                        lst1.Add(m);
                    }
                }
                else
                {
                    int j = 0;
                    int m = 0;
                    for (; j < lst1.Count && j < lst2.Count; j++)
                    {
                        int k = lst1[j] + lst2[j] + m;
                        if (k >= 10)
                        {
                            lst2[j] = k - 10;
                            m = 1;
                        }
                        else
                        {
                            lst2[j] = k;
                            m = 0;
                        }
                    }
                    while (j < lst2.Count)
                    {
                        int k = lst2[j] + m;
                        if (k >= 10)
                        {
                            lst2[j] = k - 10;
                            m = 1;
                        }
                        else
                        {
                            lst2[j] = k;
                            m = 0;
                        }
                        j++;
                    }
                    while (j < lst1.Count)
                    {
                        int k = lst1[j] + m;
                        if (k >= 10)
                        {
                            lst2.Add(k - 10);
                            m = 1;
                        }
                        else
                        {
                            lst2.Add(k);
                            m = 0;
                        }
                        j++;
                    }
                    if (m>0)
                    {
                        lst2.Add(m);
                    }
                }

                iseven = !iseven;
                i++;
            }

            Console.WriteLine(i);
        }
    }
}
