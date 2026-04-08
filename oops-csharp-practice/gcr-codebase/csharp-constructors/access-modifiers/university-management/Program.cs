using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_constructors.access_modifiers.university_management
{
    internal class Program
    {
        public static void Main()
        {
            PostgraduateStudent pg = new PostgraduateStudent(1, "Pradeep", 8.5, "Computer Science");

            pg.DisplayPostgraduateDetails();

            Console.WriteLine("\nUpdating CGPA...");
            pg.SetCGPA(9.1);

            Console.WriteLine("Updated CGPA: " + pg.GetCGPA());

            Console.WriteLine();

            pg.DisplayPostgraduateDetails();
        }
    }
}
