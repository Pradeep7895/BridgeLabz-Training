using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level03
{
    internal class EmployeeBonus
    {
        // Column 0 -> Old Salary
        // Column 1 -> Years of Service
        public static double[,] EmployeeData()
        {
            double[,] employeeData = new double[10, 2];
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                employeeData[i, 0] = random.Next(10000, 100000);

                employeeData[i, 1] = random.Next(1, 11);
            }

            return employeeData;
        }

        // Method to calculate bonus and new salary
        
        public static double[,] BonusAndNewSalary(double[,] employeeData)
        {
            // Column 0 -> Old Salary
            // Column 1 -> Years of Service
            // Column 2 -> Bonus Amount
            // Column 3 -> New Salary
            double[,] res = new double[10, 4];

            for (int i = 0; i < 10; i++)
            {
                double oldSalary = employeeData[i, 0];
                double years = employeeData[i, 1];
                double bonus;

               
                if (years > 5)
                    bonus = oldSalary * 0.05;  
                else
                    bonus = oldSalary * 0.02;  

                double newSalary = oldSalary + bonus;

                // Store results
                res[i, 0] = oldSalary;
                res[i, 1] = years;
                res[i, 2] = bonus;
                res[i, 3] = newSalary;
            }

            return res;
        }

        //display totals in tabular format
        public static void SalarySummary(double[,] data)
        {
            double totalOldSalary = 0;
            double totalBonus = 0;
            double totalNewSalary = 0;

            Console.WriteLine("\nEmployee\tOld Salary\tYears\tBonus\t\tNew Salary");

            for (int i = 0; i < 10; i++)
            {
                totalOldSalary += data[i, 0];
                totalBonus += data[i, 2];
                totalNewSalary += data[i, 3];

                Console.WriteLine(
                    $"{i + 1}\t\t{data[i, 0]:F0}\t\t{data[i, 1]:F0}\t{data[i, 2]:F2}\t\t{data[i, 3]:F2}"
                );
            }

            Console.WriteLine("\n--- Company Summary ---");
            Console.WriteLine("Total Old Salary  = " + totalOldSalary);
            Console.WriteLine("Total Bonus Paid = " + totalBonus);
            Console.WriteLine("Total New Salary = " + totalNewSalary);
        }

        static void Main()
        {
            // Step 1: Generate salary and service data
            double[,] employeeData = EmployeeData();

            // Step 2: Calculate bonus and new salary
            double[,] finalData = BonusAndNewSalary(employeeData);

            // Step 3: Display results in tabular format
            SalarySummary(finalData);
        }

    }
}

       