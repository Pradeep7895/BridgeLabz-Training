using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.csharp_linkedlist.circular_linkedlist.task_schedular
{
    internal class TaskNode
    {
        // Task details
        public int TaskId;
        public string TaskName;
        public int Priority;
        public string DueDate;

        // Link to next task
        public TaskNode Next;

        // Constructor
        public TaskNode(int taskId, string taskName, int priority, string dueDate)
        {
            TaskId = taskId;        
            TaskName = taskName;    
            Priority = priority;   
            DueDate = dueDate;      
            Next = null;         
        }
    }
}
