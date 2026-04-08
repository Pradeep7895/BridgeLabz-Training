using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.csharp_linkedlist.circular_linkedlist.task_schedular
{
    internal class Program
    {
        static void Main()
        {
            TaskCircularList tasks = new TaskCircularList();

            // Add tasks
            tasks.AddAtBeginning(1, "Design", 1, "10-Apr");
            tasks.AddAtEnd(2, "Coding", 2, "15-Apr");
            tasks.AddAtEnd(3, "Testing", 1, "20-Apr");

            Console.WriteLine("\nAll Tasks:");
            tasks.DisplayAll();

            Console.WriteLine("\nCurrent Task:");
            tasks.ViewCurrentAndMoveNext();

            Console.WriteLine("\nSearch Priority:");
            tasks.SearchByPriority(1);

            Console.WriteLine("\nRemove Task:");
            tasks.RemoveByTaskId(2);

            Console.WriteLine("\nFinal Task List:");
            tasks.DisplayAll();
        }

    }
}

    