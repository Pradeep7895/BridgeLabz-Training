using BridgeLabzTraining.dsa_csharp_practice.csharp_linkedlist.circular_linkedlist.task_schedular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.csharp_linkedlist.circular_linkedlist.task_schedular
{
    internal class TaskCircularList
    {
        // Head points to first task
        private TaskNode head;

        // Tail points to last task
        private TaskNode tail;

        // 1️. Add task at beginning
        public void AddAtBeginning(int id, string name, int priority, string date)
        {
            // Create new task
            TaskNode newNode = new TaskNode(id, name, priority, date);

            // If list is empty
            if (head == null)
            {
                head = tail = newNode;
                // circular link
                tail.Next = head;
                return;
            }
            // Insert before head
            newNode.Next = head;
            head = newNode;
            // maintain circular link
            tail.Next = head; 
        }

        // 2️. Add task at end
        public void AddAtEnd(int id, string name, int priority, string date)
        {
            TaskNode newNode = new TaskNode(id, name, priority, date);

            // If list is empty
            if (head == null)
            {
                head = tail = newNode;
                tail.Next = head;
                return;
            }
            // Add after tail
            tail.Next = newNode;
            newNode.Next = head;
            tail = newNode;
        }

        // 3️. Add task at specific position
        public void AddAtPosition(int position, int id, string name, int priority, string date)
        {
            // If position is first
            if (position == 1)
            {
                AddAtBeginning(id, name, priority, date);
                return;
            }

            TaskNode newNode = new TaskNode(id, name, priority, date);
            TaskNode temp = head;

            // Move to previous position
            for (int i = 1; i < position - 1 && temp.Next != head; i++)
            {
                temp = temp.Next;
            }
            // Insert task
            newNode.Next = temp.Next;
            temp.Next = newNode;

            // If added at end, update tail
            if (temp == tail)
                tail = newNode;
        }

        // 4️. Remove task by Task ID
        public void RemoveByTaskId(int id)
        {
            // If list is empty
            if (head == null)
            {
                Console.WriteLine("No tasks available");
                return;
            }

            // If only one task
            if (head == tail && head.TaskId == id)
            {
                head = tail = null;
                Console.WriteLine("Task removed");
                return;
            }

            // If head task is to be deleted
            if (head.TaskId == id)
            {
                head = head.Next;
                tail.Next = head;
                Console.WriteLine("Task removed");
                return;
            }

            TaskNode temp = head;
            // Search task
            while (temp.Next != head && temp.Next.TaskId != id)
            {
                temp = temp.Next;
            }

            // If task not found
            if (temp.Next == head)
            {
                Console.WriteLine("Task not found");
                return;
            }
            // If deleting last task
            if (temp.Next == tail)
                tail = temp;

            // Remove task
            temp.Next = temp.Next.Next;
            Console.WriteLine("Task removed");
        }

        // 5️. View current task and move to next
        public void ViewCurrentAndMoveNext()
        {
            if (head == null)
            {
                Console.WriteLine("No tasks available");
                return;
            }

            PrintTask(head);

            // move to next task
            head = head.Next; 
            tail.Next = head;
        }

        // 6️. Display all tasks
        public void DisplayAll()
        {
            if (head == null)
            {
                Console.WriteLine("No tasks available");
                return;
            }

            TaskNode temp = head;

            // Loop until we reach head again
            do
            {
                PrintTask(temp);
                temp = temp.Next;
            }
            while (temp != head);
        }

        // 7️.  Search task by priority
        public void SearchByPriority(int priority)
        {
            if (head == null)
            {
                Console.WriteLine("No tasks available");
                return;
            }

            TaskNode temp = head;
            bool found = false;
            // Check each task
            do
            {
                if (temp.Priority == priority)
                {
                    PrintTask(temp);
                    found = true;
                }
                temp = temp.Next;
            }
            while (temp != head);

            if (!found)
                Console.WriteLine("No task found with this priority");
        }

        // Print one task
        private void PrintTask(TaskNode t)
        {
            Console.WriteLine(
                "Task ID: " + t.TaskId +
                ", Name: " + t.TaskName +
                ", Priority: " + t.Priority +
                ", Due Date: " + t.DueDate
            );
        }

    }
}

    