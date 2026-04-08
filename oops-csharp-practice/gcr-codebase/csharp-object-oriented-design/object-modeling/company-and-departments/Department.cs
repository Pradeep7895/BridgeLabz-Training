using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_object_oriented_design.object_modeling.company_and_departments
{
    internal class Department
    {
        // Department name
        public string DepartmentName { get; private set; }

        // Employees belong to this department
        private List<Employee> employees;

        // Department is created by Company
        public Department(string departmentName)
        {
            DepartmentName = departmentName;
            employees = new List<Employee>();
        }

        // Department creates employees
        public void AddEmployee(string employeeName)
        {
            employees.Add(new Employee(employeeName));
        }

        // Display employees of this department
        public void ShowEmployees()
        {
            Console.WriteLine($"Employees in {DepartmentName}:");
            foreach (Employee emp in employees)
                Console.WriteLine("- " + emp.Name);
        }
    }
}
