using System;

class YoungAndTall
{
    static void Main()
    {
        // Take input for Amar, Akbar, and Anthony
        Console.Write("Enter Amar's Age: ");
        int amarAge = int.Parse(Console.ReadLine());
        Console.Write("Enter Amar's Height: ");
        int amarHeight = int.Parse(Console.ReadLine());

        Console.Write("Enter Akbar's Age: ");
        int akbarAge = int.Parse(Console.ReadLine());
        Console.Write("Enter Akbar's Height: ");
        int akbarHeight = int.Parse(Console.ReadLine());

        Console.Write("Enter Anthony's Age: ");
        int anthonyAge = int.Parse(Console.ReadLine());
        Console.Write("Enter Anthony's Height: ");
        int anthonyHeight = int.Parse(Console.ReadLine());

        // Youngest
        if(amarAge <= akbarAge && amarAge <= anthonyAge)
            Console.WriteLine("Amar is the youngest");
        else if(akbarAge <= amarAge && akbarAge <= anthonyAge)
            Console.WriteLine("Akbar is the youngest");
        else
            Console.WriteLine("Anthony is the youngest");

        // Tallest
        if(amarHeight >= akbarHeight && amarHeight >= anthonyHeight)
            Console.WriteLine("Amar is the tallest");
        else if(akbarHeight >= amarHeight && akbarHeight >= anthonyHeight)
            Console.WriteLine("Akbar is the tallest");
        else
            Console.WriteLine("Anthony is the tallest");
    }
}
