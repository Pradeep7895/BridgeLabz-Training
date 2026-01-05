using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_object_oriented_design.object_modeling.school_and_students_with_courses
{

    // Student class – can enroll in multiple courses
    internal class Student
    {
        public string Name { get; private set; }
        // Courses this student is enrolled in
        private List<Course> courses;   

        public Student(string name)
        {
            Name = name;
            courses = new List<Course>();
        }

        // Association: student enrolls in a course
        public void EnrollCourse(Course course)
        {
            // Add course to student's list
            courses.Add(course);
            // Add student to course's list
            course.AddStudent(this); 
        }

        // Display all courses of the student
        public void ShowCourses()
        {
            Console.WriteLine($"{Name}'s Courses:");
            foreach (Course c in courses)
                Console.WriteLine("- " + c.CourseName);
        }
    }
}
