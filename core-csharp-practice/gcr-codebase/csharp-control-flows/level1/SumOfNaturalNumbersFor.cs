using System;

class SumOfNaturalNumbersFor
{
    static void Main()
    {
        // Take input from user
        Console.Write("Enter a natural number: ");
        int n = int.Parse(Console.ReadLine());
        

        // Sum using for loop
        if(n > 0)
        {
            int sum = 0;

            for(int i = 1; i <= n; i++)
            {
                sum += i;
            }
            

            // Sum using formula
            int sumFormula = n*(n + 1)/2;
            
            // Display results
            Console.WriteLine("Sum using loop = " + sum);
            Console.WriteLine("Sum using formula = " + sumFormula);
        }
        else
        {
            Console.WriteLine("Please enter a natural number.");
        }
    }
}
