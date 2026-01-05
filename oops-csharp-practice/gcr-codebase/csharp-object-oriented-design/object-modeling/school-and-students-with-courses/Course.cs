using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_object_oriented_design.object_modeling.school_and_students_with_courses
{
    // Course class – can have multiple students
    internal class Course
    {
        public string CourseName { get; private set; }
        // List of students enrolled in this course
        private List<Student> students;

        public Course(string courseName)
        {
            CourseName = courseName;
            students = new List<Student>();
        }

        // Add a student to the course
        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        // Display students enrolled in the course
        public void ShowStudents()
        {
            Console.WriteLine($"Students in {CourseName}:");
            foreach (Student s in students)
                Console.WriteLine("- " + s.Name);
        }
    }
}
