using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_inheritance
{
    internal class Employee
    {
        // Attributes
        public string Name;
        public int Id;
        public double Salary;

        // Method
        public virtual void DisplayDetails()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Salary: " + Salary);
        }
    }
    //Manager subclass
    class Manager : Employee
    {
        public int TeamSize;

        public override void DisplayDetails()
        {
            
            base.DisplayDetails();
            Console.WriteLine("Team Size: "+ TeamSize);
        }
    }
    // Developer subclass
    class Developer : Employee
    {
        public string ProgrammingLanguage;

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Programming Language: " + ProgrammingLanguage);
        }
    }
    // Intern subclass
    class Intern : Employee
    {
        public string InternshipDuration;

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Internship Duration: " + InternshipDuration);
        }
    }
    class Program
    {
        static void Main()
        {
            Employee manager = new Manager
            {
                Name = "Pradeep",
                Id = 101,
                Salary = 80000,
                TeamSize = 10
            };

            Employee developer = new Developer
            {
                Name = "Rahul",
                Id = 102,
                Salary = 60000,
                ProgrammingLanguage = "C#"
            };
            Employee intern = new Intern
            {
                Name = "Abhishek",
                Id = 103,
                Salary = 15000,
                InternshipDuration = "6 Months"
            };

            manager.DisplayDetails();
            Console.WriteLine();

            developer.DisplayDetails();
            Console.WriteLine();

            intern.DisplayDetails();
        }
    }
}
