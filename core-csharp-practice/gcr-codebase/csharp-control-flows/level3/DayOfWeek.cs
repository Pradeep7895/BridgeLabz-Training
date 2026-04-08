using System;

class DayOfWeekCalc
{
    static void Main(string[] args)
    {

        // Input: month, day, year
        int m = Convert.ToInt32(args[0]); // Month
        int d = Convert.ToInt32(args[1]); // Day
        int y = Convert.ToInt32(args[2]); // Year


        // for the Gregorian calendar,
        int y0 = y - (14 - m) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = m + 12 * ((14 - m) / 12) - 2;
        int d0 = (d + x + (31 * m0) / 12) % 7;

        Console.WriteLine("Day of Week = " + d0);
    }
}
