using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_object_oriented_design.object_modeling.school_and_students_with_courses
{
    internal class Program
    {
        static void Main()
        {
            // Create school
            School school = new School("Green Valley School");

            // Create students
            Student s1 = new Student("Rahul");
            Student s2 = new Student("Anita");

            // Create courses
            Course math = new Course("Mathematics");
            Course science = new Course("Science");

            // Add students to school
            school.AddStudent(s1);
            school.AddStudent(s2);

            // Students enroll in courses
            s1.EnrollCourse(math);
            s1.EnrollCourse(science);
            s2.EnrollCourse(math);

            // Display results
            s1.ShowCourses();
            math.ShowStudents();
        }
    }
}
