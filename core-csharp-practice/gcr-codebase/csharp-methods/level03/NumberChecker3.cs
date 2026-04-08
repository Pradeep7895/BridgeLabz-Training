using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level03
{
    internal class NumberChecker3
    {
        // Method to store digits in array
        static int[] StoreDigits(int number)
        {
            int temp = number, count = 0;

            // Count digits
            while (temp > 0)
            {
                count++;
                temp /= 10;
            }

            //array to store digits
            int[] digits = new int[count];

            // Store digits
            for (int i = count - 1; i >= 0; i--)
            {
                digits[i] = number % 10;
                number /= 10;
            }

            return digits;
        }

        // reverse the digits array
        static int[] ReverseArray(int[] digits)
        {
            int[] rev = new int[digits.Length];

            // Copy elements in reverse
            for (int i = 0; i < digits.Length; i++)
                rev[i] = digits[digits.Length - 1 - i];

            return rev;
        }

        // if two arrays are equal
        static bool AreArraysEqual(int[] a, int[] b)
        {
            // Compare
            for (int i = 0; i < a.Length; i++)
                if (a[i] != b[i])
                    return false;

            return true;
        }

        //if the number is a palindrome
        static bool IsPalindrome(int[] digits)
        {
           
            return AreArraysEqual(digits, ReverseArray(digits));
        }

        // if the number is a Duck number
        static bool IsDuckNumber(int[] digits)
        {
            
            foreach (int d in digits)
                if (d != 0)
                    return true;

            return false;
        }

        static void Main()
        {
            // Read input number
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            // Store digits in an array
            int[] digits = StoreDigits(number);

            //display results
            Console.WriteLine("Palindrome: " + IsPalindrome(digits));

            Console.WriteLine("Duck Number: " + IsDuckNumber(digits));
        }
    }

}
