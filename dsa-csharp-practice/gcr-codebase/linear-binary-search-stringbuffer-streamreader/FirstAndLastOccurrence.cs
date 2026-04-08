using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.linear_binary_search_stringbuffer_streamreader
{
    internal class FirstAndLastOccurrence
    {
        static void Main()
        {
            Console.Write("Enter array size: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter element " + (i + 1) + ": ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter target element: ");
            int target = int.Parse(Console.ReadLine());

            Console.WriteLine("First Index: " + FindFirst(arr, target));
            Console.WriteLine("Last Index: " + FindLast(arr, target));
        }

        static int FindFirst(int[] arr, int target)
        {
            int low = 0, high = arr.Length - 1, result = -1;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (arr[mid] == target)
                {
                    result = mid;
                    high = mid - 1;
                }
                else if (arr[mid] < target)
                    low = mid + 1;
                else
                    high = mid - 1;
            }
            return result;
        }

        static int FindLast(int[] arr, int target)
        {
            int low = 0, high = arr.Length - 1, result = -1;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (arr[mid] == target)
                {
                    result = mid;
                    low = mid + 1;
                }
                else if (arr[mid] < target)
                    low = mid + 1;
                else
                    high = mid - 1;
            }
            return result;
        }

    }
}

    
