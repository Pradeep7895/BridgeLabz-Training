using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.collections_and_system_design.queue_interface
{
    internal class HospitalTriageSystem
    {
        static void Main()
        {
            PriorityQueue<string, int> pq = new PriorityQueue<string, int>();

            // Enqueue patients 
            pq.Enqueue("John", -3);
            pq.Enqueue("Alice", -5);
            pq.Enqueue("Bob", -2);

            Console.WriteLine("Treatment Order:");
            while (pq.Count > 0)
            {
                Console.WriteLine(pq.Dequeue());
            }
        }
    }
}
