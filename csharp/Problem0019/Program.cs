using System;

namespace Problem0019
{
    /// <summary>
    /// You are given the following information, but you may prefer to do some research for yourself.
    ///     1 Jan 1900 was a Monday.
    ///     Thirty days has September,
    ///     April, June and November.
    ///     All the rest have thirty-one,
    ///     Saving February alone,
    ///     Which has twenty-eight, rain or shine.
    ///     And on leap years, twenty-nine.
    ///     A leap year occurs on any year evenly divisible by 4, but not on a century unless it is divisible by 400.
    /// How many Sundays fell on the first of the month during the twentieth century (1 Jan 1901 to 31 Dec 2000)?
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int sunday_year = 1900;
            int sunday_month = 1;
            int sunday_day = 7;

            int c = 0;
            int[] mon_days = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            while (sunday_day<=31 && sunday_month<=12 && sunday_year <= 2000)
            {
                sunday_day += 7;

                if (sunday_month == 2)
                {
                    int d = mon_days[sunday_month - 1];
                    if (sunday_year % 4 == 0)
                    {
                        d++;
                    }

                    if (sunday_day > d)
                    {
                        sunday_day -= d;
                        sunday_month += 1;
                    }
                }
                else
                {
                    if (sunday_day > mon_days[sunday_month - 1])
                    {
                        sunday_day -= mon_days[sunday_month - 1];
                        sunday_month += 1;
                    }

                    if (sunday_month > 12)
                    {
                        sunday_year++;
                        sunday_month -= 12;
                    }
                }

                if (sunday_year >= 1901 && sunday_day == 1)
                {
                    c++;
                }
            }


            Console.WriteLine(c);
        }

        static int CountMondays()
        {
            DateTime dt = new DateTime(1901, 1, 1);
            DateTime end = new DateTime(2000, 12, 31);

            int c = 0;
            for (; dt < end; dt = dt.AddMonths(1))
            {
                if (dt.DayOfWeek == DayOfWeek.Sunday)
                {
                    c++;
                }
            }

            return c;
        }
    }
}
