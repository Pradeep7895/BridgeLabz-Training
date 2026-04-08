using System;

class Power
{
    static void Main()
    {
        // Take input for number and power
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Enter power: ");
        int power = int.Parse(Console.ReadLine());

        int result = 1;
        
        // Calculate number raised to the power
        for(int i = 1; i <= power; i++)
        {
            result = result * number;
        }

        Console.WriteLine("Result: " + result);
    }
}
