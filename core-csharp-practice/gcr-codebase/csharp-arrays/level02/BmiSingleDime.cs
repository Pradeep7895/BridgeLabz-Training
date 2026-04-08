using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.arrays.level2
{
    internal class BmiSingleDime
    {
        static void Main()
        {
            //take input for number of persons
            Console.Write("Enter total number of persons: ");
            int n = int.Parse(Console.ReadLine());

            //Arrays to store weight,height,BMI and status
            double[] weight = new double[n];
            double[] height = new double[n];
            double[] bmi = new double[n];
            string[] status = new string[n];

            //User input for height and weight

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("\nPesron " + (i + 1));

                Console.Write("Enter height (metres): ");
                height[i] = double.Parse(Console.ReadLine()!);

                Console.Write("Enter weight (kg): ");
                weight[i] = int.Parse(Console.ReadLine()!);

            }

            //calculate bmi and check the weight status

            for (int i = 0; i < n; i++)
            {
                //bmi= w/h*h
                bmi[i] = weight[i] / (height[i] * height[i]);

                if (bmi[i] <= 18.4)
                    status[i] = "Underweight";
                else if (bmi[i] >= 18.5 && bmi[i] <= 24.9)
                    status[i] = "Normal";
                else if (bmi[i] >= 25 && bmi[i] <= 39.9)
                    status[i] = "Overweight";
                else
                    status[i] = "Obese";
            }

            //Display result
            Console.WriteLine("\nBMI REPORT : ");

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("\nPerson " + (i + 1));
                Console.WriteLine("Height : " + height[i] + "meters");
                Console.WriteLine("Weight : " + weight[i] + " kg");
                Console.WriteLine("BMI : " + bmi[i]);
                Console.WriteLine("Status : " + status[i]);
            }
        }
    }
}
