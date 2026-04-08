using System;

class CheckAbundantNumber
{
    static void Main()
    {

        // Input number from user
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Calculate sum 
        int sum = 0;

        for(int i = 1; i < number; i++)
        {
            // Check if i is a divisor of number
            if(number % i == 0)
            {
                // Add divisor to sum
                sum += i;
            }
        }

        // Check if sum of divisors is greater than the number
        if(sum > number)
            Console.WriteLine(number + " is an Abundant Number");
        else
            Console.WriteLine(number + " is NOT an Abundant Number");
    }
}
