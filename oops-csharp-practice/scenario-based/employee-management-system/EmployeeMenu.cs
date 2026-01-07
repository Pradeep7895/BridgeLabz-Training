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
            employeeUtility = new EmployeeUtilityImpl();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nEmployee Menu :");
                Console.WriteLine("1. Check Attendance");
                Console.WriteLine("2. Calculate Daily Wage");
                Console.WriteLine("3. Calculate Part-Time Wage");
                Console.WriteLine("4. Calculate Monthly Wage");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\nResult: ");
                        Console.WriteLine(employeeUtility.CheckAttendance());
                        break;

                    case 2:
                        Console.WriteLine("\nResult: ");
                        Console.WriteLine(employeeUtility.CalculateDailyWage());
                        break;

                    case 3:
                        Console.WriteLine("\nResult: ");
                        Console.WriteLine(employeeUtility.CalculatePartTimeWage());
                        break;
                    case 4:
                        Console.WriteLine("\nResult: ");
                        Console.WriteLine(employeeUtility.CalculateMonthlyWage());
                        break;
                    case 0:
                        exit = true;
                        Console.WriteLine("Exit Menu.");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice.");
                        break;
                }
            }
        }
    }
}