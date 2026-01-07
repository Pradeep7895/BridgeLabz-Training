using BridgeLabzTraining.oops_csharp_practice.gcr_codebase.encapsulation_polymorphism_interface_abstractclass.employee_management_system;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.encapsulation_polymorphism_interface_abstractclass.employee_management_system
{
    internal class Menu
    {
        //list of employees
        private List<Employee> Employees = new List<Employee>();

        public void Start()
        {
            while (true)
            {
                Console.WriteLine("\nEmployee Management System :");
                Console.WriteLine("1. Add Full-Time Employee");
                Console.WriteLine("2. Add Part-Time Employee");
                Console.WriteLine("3. Display All Employees");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddFullTimeEmployee();
                        break;
                    case 2:
                        AddPartTimeEmployee();
                        break;
                    case 3:
                        DisplayEmployees();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }
        //method to add full time employee details
        private void AddFullTimeEmployee()
        {
            Console.Write("Enter ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Fixed Salary: ");
            double salary = double.Parse(Console.ReadLine());

            Console.Write("Enter Department: ");
            string dept = Console.ReadLine();

            Employee emp = new FullTimeEmployee(id, name, salary);
            ((IDepartment)emp).AssignDepartment(dept);

            Employees.Add(emp);
            Console.WriteLine("Full-Time Employee added successfully.");
        }
        //method to add part time employee details
        private void AddPartTimeEmployee()
        {
            Console.Write("Enter ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Work Hours: ");
            int hours = int.Parse(Console.ReadLine());

            Console.Write("Enter Hourly Rate: ");
            double rate = double.Parse(Console.ReadLine());

            Console.Write("Enter Department: ");
            string dept = Console.ReadLine();

            Employee emp = new PartTimeEmployee(id, name, hours, rate);
            ((IDepartment)emp).AssignDepartment(dept);

            Employees.Add(emp);
            Console.WriteLine("Part-Time Employee added successfully.");
        }
        //method to display details of employees
        private void DisplayEmployees()
        {
            if (Employees.Count == 0)
            {
                Console.WriteLine("No employees found.");
                return;
            }

            Console.WriteLine("\nEmployee List : ");
            foreach (Employee emp in Employees)
            {
                emp.DisplayDetails();
            }
        }

    }
}

   