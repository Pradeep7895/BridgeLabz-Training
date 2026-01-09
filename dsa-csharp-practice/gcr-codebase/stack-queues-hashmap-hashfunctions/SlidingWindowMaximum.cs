using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.stack_queues_hashmap_hashfunctions
{
    internal class SlidingWindowMaximum
    {
        public static void FindMaxInWindows(int[] nums, int k)
        {
            if (nums.Length == 0 || k <= 0)
                return;

            // Deque to store indices
            LinkedList<int> deque = new LinkedList<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                // Remove indices that are out of current window
                if (deque.Count > 0 && deque.First.Value < i - k + 1)
                {
                    deque.RemoveFirst();
                }

                // Remove smaller elements from back
                while (deque.Count > 0 && nums[deque.Last.Value] <= nums[i])
                {
                    deque.RemoveLast();
                }

                // Add current index
                deque.AddLast(i);

                // Print max when window size is reached
                if (i >= k - 1)
                {
                    Console.Write(nums[deque.First.Value] + " ");
                }
            }
        }

        static void Main()
        {
            int[] nums = { 1, 3, -1, -3, 5, 3, 6, 7 };
            int k = 3;

            FindMaxInWindows(nums, k);
        }

    }
}

    