using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_object_oriented_design.object_modeling.school_and_students_with_courses
{
    // School aggregates students
    internal class School
    {
        public string Name { get; private set; }

        // List of students in the school
        private List<Student> students;

        // Constructor to initialize school
        public School(string name)
        {
            Name = name;
            students = new List<Student>();
        }

        // Add an existing student to the school
        public void AddStudent(Student student)
        {
            students.Add(student);
        }
    }
}
