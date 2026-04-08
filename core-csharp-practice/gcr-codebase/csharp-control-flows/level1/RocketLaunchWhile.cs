using System;

class RocketLaunchWhile
{
    static void Main()
    {
        // Take input for countdown number
        Console.Write("Enter countdown number: ");
        int counter = Convert.ToInt32(Console.ReadLine());

        
        // Countdown using while loop
        while(counter >= 1)
        {
            Console.WriteLine(counter);
            counter--;
        }
    }
}
