using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.generics.university_course_management
{
    internal class Menu
    {
        private CourseUtility utility = new CourseUtility();

        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("\n==== University Course Menu ====");
                Console.WriteLine("1. Add Exam Course");
                Console.WriteLine("2. Add Assignment Course");
                Console.WriteLine("3. View Exam Courses");
                Console.WriteLine("4. View Assignment Courses");
                Console.WriteLine("0. Exit");

                Console.Write("Enter choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        utility.AddExamCourse();
                        break;
                    case 2:
                        utility.AddAssignmentCourse();
                        break;
                    case 3:
                        utility.DisplayExamCourses();
                        break;
                    case 4: 
                        utility.DisplayAssignmentCourses();
                        break;
                    case 0:
                        return;
                    default: 
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }

    }
}

   