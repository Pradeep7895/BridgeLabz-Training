using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.encapsulation_polymorphism_interface_abstractclass.employee_management_system
{
    internal abstract class Employee
    {
        // Private instance members
        private int EmployeeId;
        private string Name;
        private double BaseSalary;

        // Getter & Setter methods
        //for id
        public int GetEmployeeId()
        {
            return EmployeeId;
        }

        private void SetEmployeeId(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Employee ID must be positive.");
            }
            EmployeeId = id;
        }

        //for name 
        public string GetName()
        {
            return Name;
        }
        private void SetName(string empName)
        {
            if (string.IsNullOrWhiteSpace(empName))
            {
                throw new ArgumentException("Name cannot be empty.");
            }
            Name = empName;
        }
        protected double GetBaseSalary()
        {
            return BaseSalary;
        }

        //constructor
        protected Employee(int id, string name, double salary)
        {
            SetEmployeeId(id);
            SetName(name);
            BaseSalary = salary;
        }

        // Abstract method
        public abstract double CalculateSalary();

        // Concrete method
        public void DisplayDetails()
        {
            Console.WriteLine(
                $"ID: {GetEmployeeId()}, Name: {GetName()}, Salary: {CalculateSalary()}"
            );
        }

    }
}
