using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_object_oriented_design.object_modeling.university_management_system
{
    internal class Student
    {
        // Student name
        public string Name { get; private set; }

        // List of courses the student is enrolled in
        private List<Course> courses;

        // Constructor to initialize student
        public Student(string name)
        {
            Name = name;
            courses = new List<Course>();
        }

        // Student enrolls in a course
        public void EnrollCourse(Course course)
        {
            courses.Add(course);
        }
    }
}
