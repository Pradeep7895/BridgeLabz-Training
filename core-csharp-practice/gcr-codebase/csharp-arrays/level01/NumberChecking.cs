using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.arrays.level1
{
    internal class NumberChecking
    {
        static void Main(string[] args)
        {
            //Declare and initialise the array
            int[] arr = new int[5];

            //Take user input for array
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Number " + (i + 1) + " is: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            //Loop to check
            for (int i = 0; i < arr.Length; i++)
            {

                // check for positive number
                if (arr[i] > 0)
                {
                    //Check for even or odd
                    if (arr[i] % 2 == 0)
                        Console.WriteLine(arr[i] + " is a even number.");
                    else
                        Console.WriteLine(arr[i] + " is a odd number.");
                }
                //for negative number
                else if (arr[i] < 0)
                    Console.WriteLine(arr[i] + " is negative");
                //number is Zero
                else
                    Console.WriteLine("Number is zero");
            }

            Console.WriteLine("Comaparing first and last elements:");

            //compare first and last element of the array
            if (arr[0] == arr[4])
                Console.WriteLine("Both elements are equal");
            else if (arr[0] > arr[4])
                Console.WriteLine("First element is greater than last element");
            else
                Console.WriteLine("First element is less than last");

        }
    }
}
