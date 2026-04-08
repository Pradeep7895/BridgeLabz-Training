using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.linear_binary_search_stringbuffer_streamreader
{
    internal class ChallengeProblem
    {
        static void Main()
        {
            // Take array size
            Console.Write("Enter number of elements: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            // Take array elements
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter element " + (i + 1) + ": ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            // Linear Search Part 
            int missing = FindFirstMissingPositive(arr);
            Console.WriteLine("First missing positive integer: " + missing);

            // Binary Search Part
            Console.Write("Enter target number to search: ");
            int target = int.Parse(Console.ReadLine());

            Array.Sort(arr); 

            int index = BinarySearch(arr, target);

            Console.WriteLine("Index of target (after sorting): " + index);
        }

        // Linear Search logic for first missing positive
        static int FindFirstMissingPositive(int[] arr)
        {
            int n = arr.Length;
            bool[] present = new bool[n + 1];

            // Mark existing positive numbers
            for (int i = 0; i < n; i++)
            {
                if (arr[i] > 0 && arr[i] <= n)
                {
                    present[arr[i]] = true;
                }
            }


            // Find first missing positive
            for (int i = 1; i <= n; i++)
            {
                if (!present[i])
                    return i;
            }

            return n + 1;
        }

        // Binary Search method
        static int BinarySearch(int[] arr, int target)
        {
            int low = 0, high = arr.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (arr[mid] == target)
                    return mid;
                else if (arr[mid] < target)
                    low = mid + 1;
                else
                    high = mid - 1;
            }

            return -1;
        }

    }
}

    