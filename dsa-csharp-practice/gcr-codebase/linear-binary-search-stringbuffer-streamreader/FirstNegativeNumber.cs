using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.linear_binary_search_stringbuffer_streamreader
{
    internal class FirstNegativeNumber
    {
        static void Main()
        {
            // Ask user for array size
            Console.Write("Enter number of elements: ");
            int size = int.Parse(Console.ReadLine());

            int[] numbers = new int[size];

            // Take array elements from user
            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter element " + (i + 1) + ": ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            // Linear search for first negative number
            bool found = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    Console.WriteLine("First negative number: " + numbers[i]);
                    found = true;
                    break;
                }
            }

            // If no negative number found
            if (!found)
            {
                Console.WriteLine("No negative number found in the array.");
            }
        }
    }
}

    

   
