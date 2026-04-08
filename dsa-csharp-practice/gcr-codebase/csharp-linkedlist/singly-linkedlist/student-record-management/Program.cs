using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.csharp_linkedlist.singly_linkedlist.student_record_management
{
    internal class Program
    {
        static void Main()
        {
            // Create linked list object
            StudentList list = new StudentList();

            // Add students
            list.AddAtBeginning(1, "Amit", 20, 'A');
            list.AddAtEnd(2, "Neha", 21, 'B');
            list.AddAtPosition(2, 3, "Rahul", 22, 'C');

            Console.WriteLine("\nAll Student Records:");
            list.DisplayAll();

            Console.WriteLine("\nSearch Student :");
            list.SearchByRollNo(2);

            Console.WriteLine("\nUpdate Grade :");
            list.UpdateGrade(3, 'A');

            Console.WriteLine("\nAfter Grade Update:");
            list.DisplayAll();

            Console.WriteLine("\nDelete Student :");
            list.DeleteByRollNo(1);

            Console.WriteLine("\nFinal Student List:");
            list.DisplayAll();
        }

    }
}

    