using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level02
{
    internal class LeapYear
    {

        // Method to check leap year
        static bool LeapYearOrNot(int year)
        {
            // Leap year valid only from Gregorian calendar
            if (year < 1582)
                return false;

            // conditions
            return (year % 4 == 0 && year % 100 != 0)
                    || (year % 400 == 0);
        }
        static void Main()
        {
            // Take year input
            Console.Write("Enter year: ");
            int year = int.Parse(Console.ReadLine()!);

            // Display result
            Console.WriteLine(LeapYearOrNot(year)
                ? "Leap Year"
                : "Not a Leap Year");
        }
    }
}
