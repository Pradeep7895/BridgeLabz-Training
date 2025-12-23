using System;
class SpringSeason
{
    static void Main(string[] args)
    {
        //Enter month number 
        Console.WriteLine("Enter month number:");
        int month = int.Parse(Console.ReadLine());

        //Enter day number
        Console.WriteLine("Enter day number:");
        int day = int.Parse(Console.ReadLine());

        //Check if the given date falls in spring season (March 20 to June 20)
        bool isSpring = (month==3 && day>=20 ) ||
                        (month==4) ||
                        (month==5) ||
                        (month==6 && day<=20);

        if(isSpring)
            Console.WriteLine("Its a Spring Season");
        else
            Console.WriteLine("Its not a Spring Season");
    }
}


