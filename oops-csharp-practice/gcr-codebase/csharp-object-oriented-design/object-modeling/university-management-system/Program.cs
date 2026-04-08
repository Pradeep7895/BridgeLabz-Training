using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_object_oriented_design.object_modeling.university_management_system
{
    internal class Program
    {
        static void Main()
        {
            // Create professor
            Professor prof = new Professor("Dr. Kumar");

            // Create course
            Course course = new Course("OOPs");

            // Assign professor to course
            course.AssignProfessor(prof);

            // Create student
            Student student = new Student("Anita");

            // Student enrolls in course
            student.EnrollCourse(course);

            Console.WriteLine("University management actions completed.");
        }
    }
}
