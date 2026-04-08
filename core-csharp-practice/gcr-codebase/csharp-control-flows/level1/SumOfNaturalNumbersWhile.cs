using System;

class SumOfNaturalNumbersWhile
{
    static void Main()
    {
        // Initialize sum
        Console.Write("Enter a natural number: ");
        int n = int.Parse(Console.ReadLine());
        
        // Sum using while loop
        if(n > 0)
        {  
            // Sum using while loop
            int sum = 0;
            int i = 1;

            while(i <= n)
            {
                sum += i;
                i++;
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
