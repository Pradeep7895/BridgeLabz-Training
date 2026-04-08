using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.stack_queues_hashmap_hashfunctions
{
    internal class StockSpan
    {
        public static void CalculateSpan(int[] prices)
        {
            int n = prices.Length;
            int[] span = new int[n];

            // Stack to store indices of prices
            Stack<int> stack = new Stack<int>();

            // First day span is always 1
            span[0] = 1;
            stack.Push(0);

            // Calculate span for remaining days
            for (int i = 1; i < n; i++)
            {
                // Remove prices smaller or equal to current price
                while (stack.Count > 0 && prices[stack.Peek()] <= prices[i])
                {
                    stack.Pop();
                }

                // If stack is empty, price is highest so far
                span[i] = (stack.Count == 0) ? (i + 1) : (i - stack.Peek());

                // Push current index
                stack.Push(i);
            }

            // Print result
            Console.WriteLine("Stock Spans:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(span[i] + " ");
            }
        }

        static void Main()
        {
            int[] prices = { 100, 80, 60, 70, 60, 75, 85 };
            CalculateSpan(prices);
        }
    }
}

   

