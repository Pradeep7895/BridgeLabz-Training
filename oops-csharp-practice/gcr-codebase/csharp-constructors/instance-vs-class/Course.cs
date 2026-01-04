using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_constructors.instance_vs_class
{
    internal class Course
    {
        //instance variables
        private string courseName;
        private int duration;
        private double fee;

        //class variable
        private static string instituteName = "GLA";

        //constructor
        public Course(string courseName, int duration, double fee)
        {
            this.courseName = courseName;
            this.duration = duration;
            this.fee = fee;

        }
        // Instance method
        public void DisplayCourseDetails()
        {
            Console.WriteLine("Course Name : " + courseName);
            Console.WriteLine("Duration   : " + duration + " months");
            Console.WriteLine("Fee      : " + fee);
            Console.WriteLine("Institute  : " + instituteName);
        }
        //class method
        public static void UpdateInstituteName(string newName)
        {
            instituteName = newName;
        }

        public static void Main()
        {
            Course c1 = new Course("C# programming", 5, 10000);
            Course c2 = new Course("Java Full Stack", 6, 15000);

            Console.WriteLine("Details before updating Institute Name: ");
            c1.DisplayCourseDetails();
            Console.WriteLine();
            c2.DisplayCourseDetails();

            //call class method
            Console.WriteLine("\nUpdating Institute Name...\n");
            Course.UpdateInstituteName("GLA University");

            Console.WriteLine("Details After updating Institute Name: ");
            c1.DisplayCourseDetails();
            Console.WriteLine();
            c2.DisplayCourseDetails();
        }

    }
}
