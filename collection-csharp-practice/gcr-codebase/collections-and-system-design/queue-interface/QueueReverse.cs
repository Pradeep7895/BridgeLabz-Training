using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.collections_and_system_design.queue_interface
{
    internal class QueueReverse
    {
        static void Reverse(Queue<int> queue)
        {
            if (queue.Count == 0)
                return;

            int first = queue.Dequeue();
            //recursion
            Reverse(queue);
            queue.Enqueue(first);
        }
        static void Main()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);

            Reverse(queue);

            foreach (int item in queue)
            {
                Console.Write(item + " ");
            }
        }
    }
}
