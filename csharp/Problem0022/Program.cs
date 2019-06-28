using System;
using System.Collections.Generic;

namespace Problem0022
{
    /// <summary>
    /// Using names.txt (right click and 'Save Link/Target As...'), a 46K text file containing over 
    /// five-thousand first names, begin by sorting it into alphabetical order. Then working out the 
    /// alphabetical value for each name, multiply this value by its alphabetical position in the 
    /// list to obtain a name score.
    /// For example, when the list is sorted into alphabetical order, COLIN, which is worth 
    /// 3 + 15 + 12 + 9 + 14 = 53, is the 938th name in the list.So, COLIN would obtain a score of 
    /// 938 × 53 = 49714.
    /// What is the total of all the name scores in the file?
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string contents = System.IO.File.ReadAllText("p022_names.txt");

            string[] namelst = contents.Replace("\"", "").Split(',');

            List<Name> names = new List<Name>();
            foreach(string name in namelst)
            {
                names.Add(new Name(name));
            }

            names.Sort();

            long result = 0;
            int idx = 1;
            foreach(Name name in names)
            {
                result += idx * name.Score;
                idx++;
            }

            Console.WriteLine(result);
        }

        class Name : IComparable<Name>
        {
            public Name(string firstName)
            {
                FirstName = firstName;

                Score = 0;
                foreach(char n in firstName.ToCharArray())
                {
                    Score += n - 'A' + 1;
                }
            }

            public string FirstName { get; set; }
            public int Score { get; set; }

            public int CompareTo(Name other)
            {
                if (other == null)
                {
                    return 1;
                }
                else
                {
                    return FirstName.CompareTo(other.FirstName);
                }
            }
        }
    }
}
