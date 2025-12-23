using System;

class GreatestFactor
{
    static void Main()
    {
        // Take input for the number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int greatestFactor = 1;


        // Find the greatest factor except itself
        for(int i = number - 1; i >= 1; i--)
        {
            if(number % i == 0)
            {
                greatestFactor = i;
                break;
            }
        }
        Console.WriteLine("Greatest factor (except itself): " + greatestFactor);
    }
}
