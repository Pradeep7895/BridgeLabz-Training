using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_constructors.access_modifiers.employee_records
{
    internal class Employee
    {
        // Public member
        public int employeeID;

        // Protected member
        protected string department;

        // Private member
        private double salary;

        // Constructor
        public Employee(int employeeID, string department, double salary)
        {
            this.employeeID = employeeID;
            this.department = department;
            this.salary = salary;
        }

        // Public method to update salary
        public void SetSalary(double newSalary)
        {
            if (newSalary > 0)
            {
                salary = newSalary;
            }
        }
        // Public method to get salary
        public double GetSalary()
        {
            return salary;
        }
    }
}
