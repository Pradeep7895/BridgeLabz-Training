using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.stack_queues_hashmap_hashfunctions
{
    internal class SubarraysWithZeroSum
    {
        public static void FindZeroSumSubarrays(int[] arr)
        {
            // Map to store prefix sum and list of indices
            Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();

            int sum = 0;

            // sum 0 at index -1 (for subarrays starting at index 0)
            map[0] = new List<int> { -1 };

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];

                // if sum already exists, zero sum subarray found
                if (map.ContainsKey(sum))
                {
                    foreach (int startIndex in map[sum])
                    {
                        Console.WriteLine($"Zero sum subarray: {startIndex + 1} to {i}");
                    }
                    map[sum].Add(i);
                }
                else
                {
                    map[sum] = new List<int> { i };
                }
            }
        }

        static void Main()
        {
            int[] arr = { 3, 4, -7, 3, 1, 3, -4, -2, -2 };
            FindZeroSumSubarrays(arr);
        }

    }
}

    