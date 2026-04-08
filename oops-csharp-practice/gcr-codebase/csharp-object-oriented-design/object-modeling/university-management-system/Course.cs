using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_object_oriented_design.object_modeling.university_management_system
{
    internal class Course
    {
        public string CourseName { get; private set; }

        // Assigned professor for the course
        public Professor Instructor { get; private set; }

        // Constructor to initialize course
        public Course(string courseName)
        {
            CourseName = courseName;
        }

        // Association
        public void AssignProfessor(Professor professor)
        {
            Instructor = professor;
        }
    }
}
