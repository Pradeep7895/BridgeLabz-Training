using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.stack_queues_hashmap_hashfunctions
{
    internal class QueueUsingStacks
    {
        // Stack used for enqueue operation
        private Stack<int> inStack = new Stack<int>();

        // Stack used for dequeue operation
        private Stack<int> outStack = new Stack<int>();

        // Method to add an element into the queue
        public void Enqueue(int value)
        {
            // Push the value into inStack
            // This keeps enqueue operation fast (O(1))
            inStack.Push(value);

            Console.WriteLine($"{value} enqueued");
        }

        // Method to remove an element from the queue
        public int Dequeue()
        {
            // If outStack is empty, we need to move elements
            // from inStack to outStack
            if (outStack.Count == 0)
            {
                // If both stacks are empty, queue has no elements
                if (inStack.Count == 0)
                {
                    Console.WriteLine("Queue is empty");
                    return -1;
                }

                // Move all elements from inStack to outStack
                // This reverses the order to maintain FIFO
                while (inStack.Count > 0)
                {
                    outStack.Push(inStack.Pop());
                }
            }

            // Pop element from outStack (front of queue)
            return outStack.Pop();
        }
    }
    class Program
    {
        static void Main()
        {
            // Create queue object
            QueueUsingStacks queue = new QueueUsingStacks();

            // Add elements to queue
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            // Remove elements from queue
            Console.WriteLine(queue.Dequeue()); // Output: 10
            Console.WriteLine(queue.Dequeue()); // Output: 20
        }
    }

}



