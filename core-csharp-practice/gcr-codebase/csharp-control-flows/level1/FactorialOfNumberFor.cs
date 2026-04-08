using System;

class FactorialOfNumberFor
{
    static void Main()
    {

        // Take input from user
        Console.Write("Enter a positive integer: ");
        int num = int.Parse(Console.ReadLine());

        // Calculate factorial using for loop
        if(num > 0)
        {
            int fact = 1;

            for(int i = 1; i <= num; i++)
            {
                fact *= i;
            }
            

            // Display result
            Console.WriteLine("Factorial = " + fact);
        }
    }
}
