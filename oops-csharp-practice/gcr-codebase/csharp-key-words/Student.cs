using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_key_words
{
    internal class Student
    {
        // static variable
        private static string UniversityName = "GLA University";
        private static int totalStudents = 0;

        // readonly variable
        private readonly int RollNumber;

        // instance variables
        private string Name;
        private char Grade;

        // constructor using this keyword
        public Student(int RollNumber, string Name, char Grade)
        {
            this.RollNumber = RollNumber;
            this.Name = Name;
            this.Grade = Grade;
            totalStudents++;
        }

        // static method
        public static void DisplayTotalStudents()
        {
            Console.WriteLine("Total Students: " + totalStudents);
        }

        // is operator usage
        public static void DisplayStudent(object obj)
        {
            //directly type casting
            //instead of (Student s =(Student)obj)
            if (obj is Student s)
            {
                Console.WriteLine("\nUniversity   : " + UniversityName);
                Console.WriteLine("Roll Number  : " + s.RollNumber);
                Console.WriteLine("Name         : " + s.Name);
                Console.WriteLine("Grade        : " + s.Grade);
            }
            else
            {
                Console.WriteLine("Object is not a Student");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            //object creation
            Student s1 = new Student(1, "Pradeep", 'A');
            Student s2 = new Student(2, "Neha", 'B');

            //calling using class name because the method is static
            Student.DisplayStudent(s1);
            Student.DisplayStudent(s2);

            Console.WriteLine();
            //total number of students
            //calculate with help of constructor
            Student.DisplayTotalStudents();
            
        }
    }
}

    

