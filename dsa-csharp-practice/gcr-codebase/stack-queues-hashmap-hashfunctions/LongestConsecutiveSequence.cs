using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.stack_queues_hashmap_hashfunctions
{
    internal class LongestConsecutiveSequence
    {
        public static int FindLongestSequence(int[] nums)
        {
            // Store all numbers in a HashSet
            HashSet<int> set = new HashSet<int>(nums);

            int longest = 0;

            // Traverse each number
            foreach (int num in set)
            {
                // Check if this number is the start of a sequence
                if (!set.Contains(num - 1))
                {
                    int currentNum = num;
                    int count = 1;

                    // Count consecutive numbers
                    while (set.Contains(currentNum + 1))
                    {
                        currentNum++;
                        count++;
                    }

                    // Update longest length
                    longest = Math.Max(longest, count);
                }
            }

            return longest;
        }

        static void Main()
        {
            int[] nums = { 100, 4, 200, 1, 3, 2 };
            Console.WriteLine("Longest Consecutive Sequence Length: " + FindLongestSequence(nums));
        }

    }
}

   