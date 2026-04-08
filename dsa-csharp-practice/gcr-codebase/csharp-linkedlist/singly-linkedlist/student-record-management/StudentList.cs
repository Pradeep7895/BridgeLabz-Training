using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.csharp_linkedlist.singly_linkedlist.student_record_management
{
    internal class StudentList
    {
        // Head always points to the first student
        private StudentNode head;

        //1. Add student at the beginning of the list
        public void AddAtBeginning(int rollNo, string name, int age, char grade)
        {
            // create new student node
            StudentNode newNode = new StudentNode(rollNo, name, age, grade);

            // New node points to current head
            newNode.Next = head;
            // head points to new node
            head = newNode;
        }


        // 2️. Add student at the end of the list
        public void AddAtEnd(int rollNo, string name, int age, char grade)
        {
            // Create new student node
            StudentNode newNode = new StudentNode(rollNo, name, age, grade);

            // If list is empty, make new node as head
            if (head == null)
            {
                head = newNode;
                return;
            }

            // Traverse till last node
            StudentNode temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }

            // link last node to new node
            temp.Next = newNode;
        }
        

        // 3️. Add student at a specific position
        public void AddAtPosition(int position, int rollNo, string name, int age, char grade)
        {
            // If position is 1, insert at beginning
            if (position == 1)
            {
                AddAtBeginning(rollNo, name, age, grade);
                return;
            }

            // Create new student node
            StudentNode newNode = new StudentNode(rollNo, name, age, grade);
            StudentNode temp = head;

            // Move to the node before the given position
            for (int i = 1; i < position - 1 && temp != null; i++)
            {
                temp = temp.Next;
            }

            // If is invalid
            if (temp == null)
            {
                Console.WriteLine("Invalid position");
                return;
            }
            // Insert node 
            newNode.Next = temp.Next;
            temp.Next = newNode;
        }

        // 4️. Delete student record using Roll Number
        public void DeleteByRollNo(int rollNo)
        {
            // If list is empty
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            // If first student is to be deleted
            if (head.RollNo == rollNo)
            {
                head = head.Next;
                Console.WriteLine("Student record deleted");
                return;
            }

            // Traverse to find the student
            StudentNode temp = head;
            while (temp.Next != null && temp.Next.RollNo != rollNo)
            {
                temp = temp.Next;
            }

            // If student not found
            if (temp.Next == null)
            {
                Console.WriteLine("Student not found");
                return;
            }

            // Delete student 
            temp.Next = temp.Next.Next;
            Console.WriteLine("Student record deleted");
        }

        // 5️.  Search student by Roll Number
        public void SearchByRollNo(int rollNo)
        {
            StudentNode temp = head;

            // Traverse list to search student
            while (temp != null)
            {
                if (temp.RollNo == rollNo)
                {
                    PrintStudent(temp);
                    return;
                }
                temp = temp.Next;
            }

            // If student not found
            Console.WriteLine("Student not found");
        }

        // 6️. Update student's grade using Roll Number
        public void UpdateGrade(int rollNo, char newGrade)
        {
            StudentNode temp = head;

            // Traverse list to find student
            while (temp != null)
            {
                if (temp.RollNo == rollNo)
                {
                    temp.Grade = newGrade;
                    Console.WriteLine("Grade updated successfully");
                    return;
                }
                temp = temp.Next;
            }

            // If student not found
            Console.WriteLine("Student not found");
        }

        // 7️.  Display all student records
        public void DisplayAll()
        {
            // If list is empty
            if (head == null)
            {
                Console.WriteLine("No student records available");
                return;
            }

            StudentNode temp = head;

            // Traverse and print all students
            while (temp != null)
            {
                PrintStudent(temp);
                temp = temp.Next;
            }
        }

        // Helper method to print one student record
        private void PrintStudent(StudentNode s)
        {
            Console.WriteLine(
                "Roll No: " + s.RollNo +
                ", Name: " + s.Name +
                ", Age: " + s.Age +
                ", Grade: " + s.Grade
            );
        }

    }
}

    