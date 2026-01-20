using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.exam_proctor
{
    internal class Student
    {
        private int StudentId;
        private string Name;

        public Student(int id, string name)
        {
            StudentId = id;
            Name = name;
        }

        public int GetStudentId() {  return StudentId; }
        public void SetStudentId(int id) { StudentId = id; }

        public string GetName() { return Name; }
        public void SetName(string name) { Name = name; }

        public void Display()
        {
            Console.WriteLine("\nStudent Details:");
            Console.WriteLine($"Student ID : {StudentId}");
            Console.WriteLine($"Name       : {Name}");
        }

    }
}

   
