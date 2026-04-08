using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_object_oriented_design.object_modeling.university_with_faculty_and_depart
{
    internal class Program
    {
        static void Main()
        {
            // Create faculty members
            Faculty f1 = new Faculty("Dr. Sharma");
            Faculty f2 = new Faculty("Dr. Mehta");

            // Create university
            University uni = new University("Tech University");

            // University creates departments
            uni.AddDepartment("CSE");
            uni.AddDepartment("ECE");

            // Deleting university removes its departments (composition)
            uni = null;

            // Faculty objects still exist independently
            Console.WriteLine("Faculty objects still exist.");
        }
    }
}
