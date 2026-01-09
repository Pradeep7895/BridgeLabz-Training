using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.csharp_linkedlist.circular_linkedlist.round_robin_scheduling_algorithm
{
    internal class Program
    {
        static void Main()
        {
            // Create scheduler with time quantum = 3
            Scheduler scheduler = new Scheduler(3);

            // Add processes
            scheduler.AddProcess(1, 10, 1);
            scheduler.AddProcess(2, 5, 2);
            scheduler.AddProcess(3, 8, 1);

            // Start round robin scheduling
            scheduler.StartScheduling();
        }

    }
}

    