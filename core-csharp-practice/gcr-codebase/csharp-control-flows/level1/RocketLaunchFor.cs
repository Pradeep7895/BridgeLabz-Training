using System;

class RocketLaunchFor
{
    static void Main()
    {
        // Take input for countdown number
        Console.Write("Enter countdown number: ");
        int counter = int.Parse(Console.ReadLine());


        // Countdown using for loop
        for(int i = counter; i >= 1; i--)
        {
            Console.WriteLine(i);
        }   
    }
}
