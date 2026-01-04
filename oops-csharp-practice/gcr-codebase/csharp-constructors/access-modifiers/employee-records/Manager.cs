using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_constructors.access_modifiers.employee_records
{
    internal class Manager : Employee
    {
        private int teamSize;

        // Constructor
        public Manager(int employeeID, string department, double salary, int teamSize)
            : base(employeeID, department, salary)
        {
            this.teamSize = teamSize;
        }
        // Methodto access public and protected
        public void DisplayDetails()
        {
            Console.WriteLine("Employee ID : " + employeeID);   
            Console.WriteLine("Department: " + department);   
            Console.WriteLine("Salary  : " + GetSalary());  
            Console.WriteLine("Team Size : " + teamSize);
        }
    }
}
