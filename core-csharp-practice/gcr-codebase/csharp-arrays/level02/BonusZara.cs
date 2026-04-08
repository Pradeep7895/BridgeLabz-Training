using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.arrays.level2
{
    internal class BonusZara
    {
        static void Main()
        {
            //array to store salary and years of service
            double[] salary = new double[10];
            double[] service = new double[10];

            //array to store bonus amount and new salary
            double[] bonus = new double[10];
            double[] newSalary = new double[10];

            double totalBonus = 0;
            double totalOldSalary = 0;
            double totalNewSalary = 0;

            //input loop
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("\nEmployee " + (i + 1));

                Console.Write("Enter salary: ");
                salary[i] = double.Parse(Console.ReadLine());

                Console.Write("Enter years of service: ");
                service[i] = double.Parse(Console.ReadLine());

                //validate input
                if (salary[i] <=0 || service[i] < 0)
                {
                    Console.WriteLine("Invalid input. Please re-enter your details. ");
                    //repeat the same index
                    i--;
                }

            }

            //Bonus Calculation 
            for (int i = 0; i < 10; i++)
            {
                if (service[i] > 5)
                    bonus[i] = salary[i] * 0.05;
                else
                    bonus[i] = salary[i] * 0.02;

                newSalary[i] = salary[i] + bonus[i];

                totalBonus += bonus[i];
                totalOldSalary += salary[i];
                totalNewSalary += newSalary[i];
            }
            //Display results
            Console.WriteLine("\nTotal bonus paid = " + totalBonus);
            Console.WriteLine("total old salary = " + totalOldSalary);
            Console.WriteLine("Total new Salary = " + totalNewSalary);

        }
    }
}
