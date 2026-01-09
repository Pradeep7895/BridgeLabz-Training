using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.csharp_linkedlist.circular_linkedlist.round_robin_scheduling_algorithm
{
    internal class ProcessNode
    {
        //process details
        public int ProcessId;
        public int BurstTime;
        public int RemainingTime;
        public int Priority;

        // Link to next process
        public ProcessNode Next;

        // Constructor
        public ProcessNode(int id, int burst, int priority)
        {
            ProcessId = id;
            BurstTime = burst;
            RemainingTime = burst;
            Priority = priority;
            Next = null;
        }

    }
}

    