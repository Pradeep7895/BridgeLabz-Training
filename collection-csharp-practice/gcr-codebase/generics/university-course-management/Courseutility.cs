using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.generics.university_course_management
{
    internal class CourseUtility
    {
        private Course<ExamCourse> examCourses = new();
        private Course<AssignmentCourse> assignmentCourses = new();

        public void AddExamCourse()
        {
            Console.Write("Enter Course ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter Course Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Max Marks: ");
            int marks = int.Parse(Console.ReadLine());

            ExamCourse course = new ExamCourse(id, name, marks);
            examCourses.AddCourse(course);
        }

        public void AddAssignmentCourse()
        {
            Console.Write("Enter Course ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter Course Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Assignment Count: ");
            int count = int.Parse(Console.ReadLine());

            AssignmentCourse course = new AssignmentCourse(id, name, count);
            assignmentCourses.AddCourse(course);
        }

        public void DisplayExamCourses()
        {
            examCourses.DisplayCourses();
        }

        public void DisplayAssignmentCourses()
        {
            assignmentCourses.DisplayCourses();
        }
    }

}
