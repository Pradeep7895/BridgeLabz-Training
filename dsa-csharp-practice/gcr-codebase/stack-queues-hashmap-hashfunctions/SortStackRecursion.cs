using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.stack_queues_hashmap_hashfunctions
{
    internal class SortStackRecursion
    {
        // Method to sort the stack
        public static void SortStack(Stack<int> stack)
        {
            // Base case: if stack is empty, return
            if (stack.Count == 0)
                return;

            // Remove the top element
            int top = stack.Pop();

            // Recursively sort the remaining stack
            SortStack(stack);

            // Insert the popped element in sorted order
            InsertSorted(stack, top);
        }

        // Method to insert an element into sorted stack
        private static void InsertSorted(Stack<int> stack, int value)
        {
            // If stack is empty or value is greater than top,
            // push value directly
            if (stack.Count == 0 || stack.Peek() <= value)
            {
                stack.Push(value);
                return;
            }

            // Remove the top element
            int top = stack.Pop();

            // Recursively find correct position
            InsertSorted(stack, value);

            // Push the removed element back
            stack.Push(top);
        }

        static void Main()
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(3);
            stack.Push(1);
            stack.Push(4);
            stack.Push(2);

            // Sort the stack
            SortStack(stack);

            // Print sorted stack
            Console.WriteLine("Sorted Stack:");
            while (stack.Count > 0)
            {
                Console.Write(stack.Pop() + " ");
            }
        }

    }
}

    