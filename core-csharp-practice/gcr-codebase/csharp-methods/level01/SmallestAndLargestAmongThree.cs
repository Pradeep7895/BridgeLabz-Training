using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level01
{
    internal class SmallestAndLargestAmongThree
    {
        public static int[] FindSmallestAndLargest(int number1, int number2, int number3)
        {

            // Find smallest number
            int smallest = Math.Min(number1, Math.Min(number2, number3));

            // Find largest number
            int largest = Math.Max(number1, Math.Max(number2, number3));

            // Return results as array
            return new int[] { smallest, largest };
        }

        static void Main()
        {

            // Input numbers
            Console.Write("Enter first number: ");
            int number1 = int.Parse(Console.ReadLine()!);

            Console.Write("Enter second number: ");
            int number2 = int.Parse(Console.ReadLine()!);

            Console.Write("Enter third number: ");
            int number3 = int.Parse(Console.ReadLine()!);


            // Call method
            int[] result = FindSmallestAndLargest(number1, number2, number3);


            // Display results
            Console.WriteLine("Smallest = " + result[0]);
            Console.WriteLine("Largest = " + result[1]);
        }
    }
}
