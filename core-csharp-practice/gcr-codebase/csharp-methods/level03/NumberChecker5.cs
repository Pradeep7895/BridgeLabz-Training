using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level03
{
    internal class NumberChecker5
    {
        // Method to find all factors of a number
        static int[] FindFactors(int n)
        {
            int count = 0;

            // Count factors 
            for (int i = 1; i <= n; i++)
                if (n % i == 0)
                    count++;

            // Create array 
            int[] factors = new int[count];
            int index = 0;

            // Store factors 
            for (int i = 1; i <= n; i++)
                if (n % i == 0)
                    factors[index++] = i;

            return factors;
        }

        // Method for Perfect number
        static bool IsPerfect(int n)
        {
            int sum = 0;

           
            for (int i = 1; i < n; i++)
                if (n % i == 0)
                    sum += i;

            return sum == n;
        }

        // Method for Abundant number
        static bool IsAbundant(int n)
        {
            int sum = 0;

            // Add all divisors
            for (int i = 1; i < n; i++)
                if (n % i == 0)
                    sum += i;

            
            return sum > n;
        }

        // Method for Deficient number
        static bool IsDeficient(int n)
        {
            int sum = 0;

            
            for (int i = 1; i < n; i++)
                if (n % i == 0)
                    sum += i;

            
            return sum < n;
        }

        // Method for Strong number
        static bool IsStrong(int n)
        {
            int temp = n;
            int sum = 0;

            while (temp > 0)
            {
                int d = temp % 10;
                int fact = 1;

                // factorial
                for (int i = 1; i <= d; i++)
                    fact *= i;

                sum += fact;
                temp /= 10;
            }

            
            return sum == n;
        }

        static void Main()
        {
            // Read input number
            Console.Write("Enter number: ");
            int n = int.Parse(Console.ReadLine());

            // Display results
            Console.WriteLine("Perfect: " + IsPerfect(n));
            Console.WriteLine("Abundant: " + IsAbundant(n));
            Console.WriteLine("Deficient: " + IsDeficient(n));
            Console.WriteLine("Strong: " + IsStrong(n));
        }


    }
}
