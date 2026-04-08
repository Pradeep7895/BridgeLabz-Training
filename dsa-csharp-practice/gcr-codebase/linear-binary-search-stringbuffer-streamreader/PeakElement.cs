using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.linear_binary_search_stringbuffer_streamreader
{
    internal class PeakElement
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

            int peak = FindPeak(arr);
            Console.WriteLine("Peak element: " + peak);
        }

        static int FindPeak(int[] arr)
        {
            int low = 0, high = arr.Length - 1;

            while (low < high)
            {
                int mid = (low + high) / 2;

                if (arr[mid] < arr[mid + 1])
                    low = mid + 1;
                else
                    high = mid;
            }
            return arr[low];
        }

    }
}

