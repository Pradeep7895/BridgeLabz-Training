using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.employee_management_system
{
    
    sealed class EmployeeMenu 
    {
        private IEmployee employeeUtility;

        public void Choice()
        {
            // Assign implementation to interface reference
            employeeUtility = new EmployeeUtilityImpl();

            Console.WriteLine("Employee Menu: ");
            Console.WriteLine("1. Check Attendance");
            Console.WriteLine("2. Calculate Daily Wage");
            Console.WriteLine("3. Calculate Part-Time Wage");
            Console.Write("Enter your choice: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Employee emp = employeeUtility.CheckAttendance();
                    Console.WriteLine("Result :");
                    Console.WriteLine(emp);
                    break;
                case 2:
                    Employee emp2 = employeeUtility.CalculateDailyWage();
                    Console.WriteLine("Result :");
                    Console.WriteLine(emp2);
                    break;
                case 3:
                    Console.WriteLine("Result");
                    Console.WriteLine(employeeUtility.CalculatePartTimeWage());
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}