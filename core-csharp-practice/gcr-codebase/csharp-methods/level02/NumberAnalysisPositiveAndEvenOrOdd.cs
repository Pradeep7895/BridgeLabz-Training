using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level02
{
    internal class NumberAnalysisPositiveAndEvenOrOdd
    {

        //check for positive number
        static bool IsPositive(int num)
        {
            return num >= 0;
        }

        //check for even number
        static bool IsEven(int num)
        {
            return num % 2 == 0;
        }

        //compare two numbers
        static int Compare(int num1, int num2)
        {
            if (num1 > num2)
                return 1;
            if (num1 == num2)
                return 0;
            return -1;
        }

        static void Main()
        {
            // Create array to store 5 numbers
            int[] numbers = new int[5];

            // Loop to take input
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine()!);

                // Check if number is positive or negative
                if (IsPositive(numbers[i]))
                {
                    // If positive, check even or odd
                    if (IsEven(numbers[i]))
                        Console.WriteLine("Positive Even");
                    else
                        Console.WriteLine("Positive Odd");
                }
                else
                {
                    // If number is negative
                    Console.WriteLine("Negative");
                }
            }

            // Compare first and last number
            int result = Compare(numbers[0], numbers[4]);

            // Display result
            if (result == 1)
                Console.WriteLine("First element is greater than last element");
            else if (result == 0)
                Console.WriteLine("First and last elements are equal");
            else
                Console.WriteLine("First element is less than last element");
        }
    }
}
