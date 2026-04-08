using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level03
{
    internal class Calender
    {
        // Method to get month name using array
        static string GetMonthName(int month)
        {
            string[] months =
            {
                "January", "February", "March", "April", "May", "June",
                "July", "August", "September", "October", "November", "December"
            };

            return months[month - 1];
        }

        //check leap year
        static bool IsLeapYear(int year)
        {
            
            return (year % 4 == 0 && year % 100 != 0)
                    || (year % 400 == 0);
        }

        // Method to get number of days in a month
        static int GetDaysInMonth(int month, int year)
        {
            int[] days =
            {
                //January ----> December
                31,
                28, 
                31,
                30, 
                31,
                30, 
                31,
                31, 
                30, 
                31, 
                30, 
                31  
            };

            // Check for February in leap year
            if (month == 2 && IsLeapYear(year))
                return 29;

            return days[month - 1];
        }

        //using Gregorian algorithm
        // 0 = Sunday, 1 = Monday, ..., 6 = Saturday
        static int GetFirstDayOfMonth(int month, int year)
        {
            int d = 1; // First day of the month

            int y0 = year - (14 - month) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = month + 12 * ((14 - month) / 12) - 2;
            int d0 = (d + x + (31 * m0) / 12) % 7;

            return d0;
        }

        static void Main()
        {
            // Take input from user
            Console.Write("Enter month (1-12): ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Enter year: ");
            int year = int.Parse(Console.ReadLine());

            // Get month name and days

            string monthName = GetMonthName(month);
            int daysInMonth = GetDaysInMonth(month, year);


            // Get first day of the month
            int firstDay = GetFirstDayOfMonth(month, year);

            // Display calendar header
            Console.WriteLine($"\n{monthName} {year}");
            Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

            // First loop: indentation before first day
            for (int i = 0; i < firstDay; i++)
            {
                Console.Write("    ");
            }

            // Second loop: print days of the month
            for (int day = 1; day <= daysInMonth; day++)
            {

                Console.Write($"{day,3} ");

                if ((day + firstDay) % 7 == 0)
                {
                    Console.WriteLine();
                }
            }

            Console.WriteLine(); 
        }

    }
}

        