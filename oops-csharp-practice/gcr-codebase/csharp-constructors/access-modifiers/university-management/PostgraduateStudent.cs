using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_constructors.access_modifiers.university_management
{
    internal class PostgraduateStudent : Student
    {
        private string specialization;

        //constructor
        public PostgraduateStudent(int rollNumber, string name, double cgpa, string specialization)
            : base(rollNumber, name, cgpa)
        {
            this.specialization = specialization;
        }

        // Method demonstrating access to protected member
        public void DisplayPostgraduateDetails()
        {
            Console.WriteLine("Roll Number     : " + rollNumber); // public
            Console.WriteLine("Name            : " + name);       // protected
            Console.WriteLine("Specialization  : " + specialization);
            Console.WriteLine("CGPA            : " + GetCGPA());  // private via public method
        }
    }
}
