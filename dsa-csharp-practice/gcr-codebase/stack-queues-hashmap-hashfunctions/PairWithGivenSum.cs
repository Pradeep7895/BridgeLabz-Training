using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.stack_queues_hashmap_hashfunctions
{
    internal class PairWithGivenSum
    {
        public static bool HasPair(int[] arr, int target)
        {
            // Set to store visited numbers
            HashSet<int> seen = new HashSet<int>();

            foreach (int num in arr)
            {
                int required = target - num;

                // Check if required number already exists
                if (seen.Contains(required))
                {
                    Console.WriteLine($"Pair found: {required}, {num}");
                    return true;
                }

                // Store current number
                seen.Add(num);
            }

            return false;
        }

        static void Main()
        {
            int[] arr = { 8, 1, 6, 2 };
            int target = 10;

            bool result = HasPair(arr, target);
            Console.WriteLine(result ? "Pair exists" : "No pair found");
        }

    }
}

  