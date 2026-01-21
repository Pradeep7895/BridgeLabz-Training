using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.collections_and_system_design.queue_interface
{
    internal class BinaryUsingQueue
    {
        static void GenerateBinary(int n)
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("1");

            for (int i = 0; i < n; i++)
            {
                string current = queue.Dequeue();
                Console.Write(current + " ");

                queue.Enqueue(current + "0");
                queue.Enqueue(current + "1");
            }
        }
        static void Main()
        {
            int n = 5;
            GenerateBinary(n);
        }

    }
}
