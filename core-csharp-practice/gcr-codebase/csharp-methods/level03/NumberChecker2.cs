using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level03
{
    internal class NumberChecker2
    {
        // Method to store each digit in an array
        static int[] StoreDigits(int number)
        {
            int temp = number, count = 0;

            // Count number of digits
            while (temp > 0)
            {
                count++;
                temp /= 10;
            }

            // Create array
            int[] digits = new int[count];

            // Store digits
            for (int i = count - 1; i >= 0; i--)
            {
                digits[i] = number % 10;
                number /= 10;
            }

            return digits;
        }

        // calculate sum of digits
        static int SumOfDigits(int[] digits)
        {
            int sum = 0;

            // Add each digit
            foreach (int d in digits)
                sum += d;

            return sum;
        }

        // calculate sum of squares
        static int SumOfSquares(int[] digits)
        {
            int sum = 0;

            // Square each digit and add
            foreach (int d in digits)
                sum += (int)Math.Pow(d, 2);

            return sum;
        }

        // Method to check Harshad number
        static bool IsHarshad(int number, int[] digits)
        {
            // Harshad number
            return number % SumOfDigits(digits) == 0;
        }

        // Method to find frequency of each digit (0–9)
        static int[,] DigitFrequency(int[] digits)
        {
            // 2D array
            int[,] freq = new int[10, 2];

            // Initialize first column 
            for (int i = 0; i < 10; i++)
                freq[i, 0] = i;

            // frequency of each digit
            foreach (int d in digits)
                freq[d, 1]++;

            return freq;
        }

        static void Main()
        {
            // Read input number from user
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            // Store digits 
            int[] digits = StoreDigits(number);

            // Display sum 
            Console.WriteLine("Sum of Digits = " + SumOfDigits(digits));

            // Display sum of squares 
            Console.WriteLine("Sum of Squares = " + SumOfSquares(digits));

            //display if Harshad number
            Console.WriteLine("Harshad Number = " + IsHarshad(number, digits));

            // display digit frequency
            int[,] freq = DigitFrequency(digits);
            Console.WriteLine("Digit Frequency:");

            for (int i = 0; i < 10; i++)
                Console.WriteLine(i + " -> " + freq[i, 1]);
        }
    }
}