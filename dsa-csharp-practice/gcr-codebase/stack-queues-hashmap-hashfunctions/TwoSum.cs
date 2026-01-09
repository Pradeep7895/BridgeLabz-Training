using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.stack_queues_hashmap_hashfunctions
{
    internal class TwoSum
    {
        public static int[] FindTwoSum(int[] nums, int target)
        {
            // Dictionary to store number and its index
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int required = target - nums[i];

                // Check if required value already exists
                if (map.ContainsKey(required))
                {
                    // Return indices of the pair
                    return new int[] { map[required], i };
                }

                // Store current value with its index
                if (!map.ContainsKey(nums[i]))
                {
                    map[nums[i]] = i;
                }
            }

            // No solution found
            return new int[] { -1, -1 };
        }

        static void Main()
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;

            int[] result = FindTwoSum(nums, target);
            Console.WriteLine($"Indices: {result[0]}, {result[1]}");
        }

    }
}

    