using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level03
{
    internal class NumberChecker1
    {
        // Count digits in a number
        static int CountDigits(int number)
        {
            int count = 0;
            while (number > 0)
            {
                count++;
                number /= 10;
            }
            return count;
        }

        // Store digits in array
        static int[] StoreDigits(int number)
        {
            int count = CountDigits(number);
            int[] digits = new int[count];

            for (int i = count - 1; i >= 0; i--)
            {
                digits[i] = number % 10;
                number /= 10;
            }
            return digits;
        }

        // Check Duck Number (contains at least one non-zero digit)
        static bool IsDuckNumber(int[] digits)
        {
            foreach (int d in digits)
                if (d != 0)
                    return true;
            return false;
        }

        // Check Armstrong Number
        static bool IsArmstrong(int number, int[] digits)
        {
            int sum = 0;
            int power = digits.Length;

            foreach (int d in digits)
                sum += (int)Math.Pow(d, power);

            return sum == number;
        }

        // Find largest and second largest digit
        static int[] LargestAndSecondLargest(int[] digits)
        {
            int largest = Int32.MinValue;
            int secondLargest = Int32.MinValue;

            foreach (int d in digits)
            {
                if (d > largest)
                {
                    secondLargest = largest;
                    largest = d;
                }
                else if (d > secondLargest && d != largest)
                {
                    secondLargest = d;
                }
            }
            return new int[] { largest, secondLargest };
        }

        // Find smallest and second smallest digit
        static int[] SmallestAndSecondSmallest(int[] digits)
        {
            int smallest = Int32.MaxValue;
            int secondSmallest = Int32.MaxValue;

            foreach (int d in digits)
            {
                if (d < smallest)
                {
                    secondSmallest = smallest;
                    smallest = d;
                }
                else if (d < secondSmallest && d != smallest)
                {
                    secondSmallest = d;
                }
            }
            return new int[] { smallest, secondSmallest };
        }

        static void Main()
        {
            //input number
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            //method call
            int[] digits = StoreDigits(number);

            //display results
            Console.WriteLine("Duck Number: " + IsDuckNumber(digits));
            Console.WriteLine("Armstrong Number: " + IsArmstrong(number, digits));

            int[] max = LargestAndSecondLargest(digits);
            Console.WriteLine("Largest = " + max[0] + ", Second Largest = " + max[1]);

            int[] min = SmallestAndSecondSmallest(digits);
            Console.WriteLine("Smallest = " + min[0] + ", Second Smallest = " + min[1]);
        }
    }
}



