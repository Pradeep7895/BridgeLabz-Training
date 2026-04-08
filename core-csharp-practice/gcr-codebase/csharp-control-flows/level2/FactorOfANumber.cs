using System;

class FactorOfANumber
{
    static void Main()
    {
        // Take input for the number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Factors are:");


        // Find factor of the number
        for(int i = 1; i < number; i++)
        {
            if(number % i == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
