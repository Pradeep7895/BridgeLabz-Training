using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_key_words
{
    internal class Employee
    {
        // static members
        private static string CompanyName = "Google";
        private static int totalEmployees = 0;

        // readonly field
        private readonly int Id;

        // instance fields
        private string Name;
        private string Designation;

        // constructor using this keyword
        public Employee(int Id, string Name, string Designation)
        {
            this.Id = Id;
            this.Name = Name;
            this.Designation = Designation;
            totalEmployees++;
        }
        //static method
        public static void DisplayTotalEmployees()
        {
            Console.WriteLine("Total Employees: " + totalEmployees);
        }
        // is operator usage
        public static void DisplayEmployee(object obj)
        {
            if (obj is Employee)
            {
                Employee emp = (Employee)obj;
                Console.WriteLine("\nCompany Name : " + CompanyName);
                Console.WriteLine("Employee ID  : " + emp.Id);
                Console.WriteLine("Name         : " + emp.Name);
                Console.WriteLine("Designation  : " + emp.Designation);
            }
            else
            {
                Console.WriteLine("Object is not an Employee");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Employee e1 = new Employee(1, "Pradeep", "Developer");
            Employee e2 = new Employee(2, "Rahul", "Tester");

            Employee.DisplayEmployee(e1);
            Employee.DisplayEmployee(e2);

            Console.WriteLine();

            Employee.DisplayTotalEmployees();
            
        }
    }
}
