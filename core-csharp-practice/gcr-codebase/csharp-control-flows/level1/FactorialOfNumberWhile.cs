using System;

class FactorialOfNumberWhile
{
    static void Main()
    { 
        // Take input from user
        Console.Write("Enter a positive integer: ");
        int number = int.Parse(Console.ReadLine());

        if(number > 0)
        { 
            // Calculate factorial using while loop
            int fact = 1;
            int i = 1;

            while(i <= number)
            {
                fact *= i;
                i++;
            }
            

            // Display result
            Console.WriteLine("Factorial = " + fact);
        }
    }
}
