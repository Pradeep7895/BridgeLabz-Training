using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.algorithm_and_big_o_notation
{
    internal class SearchAlgorithm
    {
        // Linear Search
        static int LinearSearch(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                    return i;
            }
            return -1;
        }

        // Binary Search (array must be sorted)
        static int BinarySearch(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == target)
                    return mid;
                else if (arr[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return -1;
        }

        static void Main()
        {
            int[] datasetSizes = { 1000, 10000, 1000000 };
            int target = -1;

            foreach (int size in datasetSizes)
            {
                int[] data = new int[size];

                // Fill array with sorted values
                for (int i = 0; i < size; i++)
                    data[i] = i;

                target = size - 1; // worst-case target

                Console.WriteLine($"\nDataset Size: {size}");

                // Linear Search timing
                Stopwatch sw = Stopwatch.StartNew();
                LinearSearch(data, target);
                sw.Stop();
                Console.WriteLine($"Linear Search Time: {sw.ElapsedMilliseconds} ms");

                // Binary Search timing
                sw.Restart();
                BinarySearch(data, target);
                sw.Stop();
                Console.WriteLine($"Binary Search Time: {sw.ElapsedMilliseconds} ms");
            }
        }

    }
}

