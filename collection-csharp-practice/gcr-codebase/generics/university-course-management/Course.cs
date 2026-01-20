using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.generics.university_course_management
{
    internal class Course<T> where T : CourseType
    {
        private List<T> courses = new List<T>();

        public void AddCourse(T course)
        {
            courses.Add(course);
            Console.WriteLine("Course added successfully.");
        }

        public void DisplayCourses()
        {
            if (courses.Count == 0)
            {
                Console.WriteLine("No courses available.");
                return;
            }

            foreach (T course in courses)
            {
                course.Evaluate();
            }
        }

        // Variance-ready method 
        public IEnumerable<CourseType> GetAllCourses()
        {
            return courses;
        }
    }

}
