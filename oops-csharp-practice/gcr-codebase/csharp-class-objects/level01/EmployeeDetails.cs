using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_class_objects.level01
{
    internal class EmployeeDetails
    {
        //fields
        private string name;
        private int id;
        private int salary;

        // Constructor
        public EmployeeDetails(string name, int id , int salary)
        {
            this.name = name;
            this.id = id;
            this.salary = salary;
        }
        //method to display employee details
        public void DisplayDetails()
        {
            Console.WriteLine("Employee Name: " + name);
            Console.WriteLine("Employee ID: " + id);
            Console.WriteLine("Employee Salary: " + salary);
        }
        public static void Main(string[] args)
        {
            EmployeeDetails emp1 = new EmployeeDetails("Pradeep", 1, 100000);

            Console.WriteLine("\nEmployee Details:");
            emp1.DisplayDetails();
        }
    }
}
