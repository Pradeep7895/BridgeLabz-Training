using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.csharp_linkedlist.circular_linkedlist.round_robin_scheduling_algorithm
{
    internal class Scheduler
    {
        private ProcessNode head;
        private ProcessNode tail;
        private int timeQuantum;

        // Total time elapsed
        private int currentTime = 0;

        // Total waiting time
        private int totalWaitingTime = 0;

        // Total turn around time
        private int totalTurnAroundTime = 0;

        // Count of processes
        private int processCount = 0;

        // Constructor
        public Scheduler(int quantum)
        {
            timeQuantum = quantum;   
        }

        // 1️. Add process at end
        public void AddProcess(int id, int burst, int priority)
        {
            ProcessNode newNode = new ProcessNode(id, burst, priority);

            // If list is empty
            if (head == null)
            {
                head = tail = newNode;
                // circular link
                tail.Next = head; 
            }
            else
            {
                tail.Next = newNode;
                newNode.Next = head;
                tail = newNode;
            }
            // increase process count
            processCount++; 
        }

        // 2️. Remove process by ID
        private void RemoveProcess(int id)
        {
            // If list is empty
            if (head == null)
                return;

            // If only one process
            if (head == tail && head.ProcessId == id)
            {
                head = tail = null;
                return;
            }

            // If head process is removed
            if (head.ProcessId == id)
            {
                head = head.Next;
                tail.Next = head;
                return;
            }

            ProcessNode temp = head;

            // Search process
            while (temp.Next != head && temp.Next.ProcessId != id)
            {
                temp = temp.Next;
            }

            // If process found
            if (temp.Next.ProcessId == id)
            {
                if (temp.Next == tail)
                    tail = temp;

                temp.Next = temp.Next.Next;
            }
        }

        // 3️. Simulate Round Robin Scheduling
        public void StartScheduling()
        {
            if (head == null)
            {
                Console.WriteLine("No processes available");
                return;
            }

            ProcessNode current = head;

            // Loop until all processes are completed
            while (head != null)
            {
                DisplayProcesses();

                // If process has remaining time
                if (current.RemainingTime > 0)
                {
                    // If remaining time is greater than quantum
                    if (current.RemainingTime > timeQuantum)
                    {
                        currentTime += timeQuantum;
                        current.RemainingTime -= timeQuantum;
                    }
                    else
                    {
                        // Process finishes execution
                        currentTime += current.RemainingTime;
                        current.RemainingTime = 0;

                        // Calculate times
                        int turnAroundTime = currentTime;
                        int waitingTime = turnAroundTime - current.BurstTime;

                        totalTurnAroundTime += turnAroundTime;
                        totalWaitingTime += waitingTime;

                        // Store next process
                        int completedId = current.ProcessId;
                        current = current.Next;

                        // Remove completed process
                        RemoveProcess(completedId);
                        processCount--;

                        // If no process left
                        if (processCount == 0)
                            break;

                        continue;
                    }
                }

                // Move to next process
                current = current.Next;
            }

            // Display average times
            Console.WriteLine("\nAverage Waiting Time: " +
                (double)totalWaitingTime / (totalWaitingTime == 0 ? 1 : (totalTurnAroundTime / totalWaitingTime)));
            Console.WriteLine("Average Turn Around Time: " +
                (double)totalTurnAroundTime / (totalWaitingTime == 0 ? 1 : (totalTurnAroundTime / totalWaitingTime)));
        }

        // 4️. Display processes in circular list
        private void DisplayProcesses()
        {
            if (head == null)
                return;

            ProcessNode temp = head;

            Console.Write("Queue: ");
            do
            {
                Console.Write("[P" + temp.ProcessId +
                    " RT:" + temp.RemainingTime + "] ");
                temp = temp.Next;
            }
            while (temp != head);

            Console.WriteLine();
        }

    }
}

    