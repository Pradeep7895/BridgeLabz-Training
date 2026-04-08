using System;
class LeapYearTwo
{
    static void Main(string[] args)
    {
        //Enter year
        Console.WriteLine("Enter year:");
        int year = int.Parse(Console.ReadLine());

        //Check if the given year is a leap year
        if(year >=1582 && (year%400==0 || (year%4==0 && year%100 != 0)))
        {
            Console.WriteLine("It's a leap year.");
        }
        else
        {
            Console.WriteLine("It's not a leap year.");
        }
    }
}