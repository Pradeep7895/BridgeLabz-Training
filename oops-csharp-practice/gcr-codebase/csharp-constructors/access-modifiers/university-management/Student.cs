using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_constructors.access_modifiers.university_management
{
    internal class Student
    {
        public int rollNumber;
        protected string name;
        private double CGPA;

        // Constructor
        public Student(int rollNumber, string name, double cgpa)
        {
            this.rollNumber = rollNumber;
            this.name = name;
            this.CGPA = cgpa;
        }

        // Public method to get CGPA
        public double GetCGPA()
        {
            return CGPA;
        }

        // Public method to update CGPA
        public void SetCGPA(double cgpa)
        {
            if (cgpa >= 0 && cgpa <= 10)
            {
                CGPA = cgpa;
            }
        }
    }
}
