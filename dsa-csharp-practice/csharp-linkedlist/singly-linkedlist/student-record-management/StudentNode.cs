using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.csharp_linkedlist.singly_linkedlist.student_record_management
{
    internal class StudentNode
    {
        // Student details
        public int RollNo;
        public string Name;
        public int Age;
        public char Grade;

        // Reference to next student node
        public StudentNode Next;

        // Constructor to initialize student data
        public StudentNode(int rollNo, string name, int age, char grade)
        {
            RollNo = rollNo;     
            Name = name;         
            Age = age;          
            Grade = grade;     
            Next = null;        
        }
    }
}
