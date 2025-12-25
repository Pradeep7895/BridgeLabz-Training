using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level02
{
    internal class FindTheFactors
    {
        //Method to find all the factors 
        static int[] FindFactors(int number)
        {
            int count = 0;

            // First loop: count number of factors
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                    count++;
            }

            //array to store factors
            int[] factors = new int[count];
            int index = 0;

            // Second loop: store factors in array
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                    factors[index++] = i;
            }

            return factors;
        }

        // Method to calculate sum of factors
        static int Sum(int[] factors)
        {
            int sum = 0;
            foreach (int i in factors)
                sum += i;
            return sum;
        }

        // Method to calculate product of factors
        static long Product(int[] factors)
        {
            long product = 1;
            foreach (int i in factors)
                product *= i;
            return product;
        }

        // Method to calculate sum of squares of factors
        static double SumOfSquares(int[] factors)
        {
            double sum = 0;
            foreach(int i in factors)
                sum += Math.Pow(i, 2);
            return sum;
        }
        static void Main()
        {
            //take input
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            // Get factors array
            int[] factors = FindFactors(number);

            // Display factors
            Console.WriteLine("Factors:");
            foreach (int f in factors)
                Console.Write(f + " ");

            // Display calculations
            Console.WriteLine("\nSum = " + Sum(factors));
            Console.WriteLine("Product = " + Product(factors));
            Console.WriteLine("Sum of Squares = " + SumOfSquares(factors));
        }
    }
}
