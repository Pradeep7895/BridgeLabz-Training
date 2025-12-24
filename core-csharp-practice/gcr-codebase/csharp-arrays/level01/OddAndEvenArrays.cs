using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.arrays.level1
{
    internal class OddAndEvenArrays
    {
        static void Main()
        {
            //Input number 
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());

            //check for natural number
            if (number <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a natural natural");
                return;
            }

            //Create arrays for odd and even numbers
            int[] odd = new int[number / 2 + 1];
            int[] even = new int[number / 2 + 1];

            //Indexes for odd and even arrays
            int oddIndex = 0;
            int evenIndex = 0;

            //loop from 1 to number
            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    even[evenIndex++] = i;
                }
                else
                {
                    odd[oddIndex++] = i;
                }
            }

            //print odd numbers
            Console.WriteLine("\nOdd Numbers:");
            for (int i = 0; i < oddIndex; i++)
            {
                Console.Write(odd[i] + " ");
            }

            //print even numbers
            Console.WriteLine("\nEven Numbers:");
            for (int i = 0; i < evenIndex; i++)
            {
                Console.Write(even[i] + " ");
            }

        }
    }
}
