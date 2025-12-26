using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level02
{
    internal class BmiCalculator
    {

        //Calculate bmi and stote in 3rd column
        // col 0-> weight , col 1 --> height , col 2 --> BMI
        public static void Bmi(double[,] eachPersonData)
        {
            for (int i = 0; i < eachPersonData.GetLength(0); i++)
            {
                // Convert height from cm to meters
                double heightMeters = eachPersonData[i, 1] / 100;

                // BMI formula: weight / (height * height)
                eachPersonData[i, 2] = eachPersonData[i, 0] / (heightMeters * heightMeters);
            }
        }

        // bmi status of each person
        public static string[] BMIStatus(double[,] eachPersonData)
        {
            string[] status = new string[eachPersonData.GetLength(0)];

            for (int i = 0; i < eachPersonData.GetLength(0); i++)
            {
                double bmi = eachPersonData[i, 2];

                // BMI status
                if (bmi <= 18.4)
                    status[i] = "Underweight";
                else if (bmi >= 18.5 && bmi <= 24.9)
                    status[i] = "Normal";
                else if (bmi >= 25.0 && bmi <= 39.9)
                    status[i] = "Overweight";
                else
                    status[i] = "Obese";
            }

            return status;
        }

        static void Main()
        {
            //2D array to store details 
            double[,] eachPersonData = new double[10, 3];

            // Take input for 10 persons
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"\nEnter details for Person {i + 1}:");

                // Input weight in kg
                Console.Write("Enter weight (kg): ");
                eachPersonData[i, 0] = double.Parse(Console.ReadLine());

                // Input height in cm
                Console.Write("Enter height (cm): ");
                eachPersonData[i, 1] = double.Parse(Console.ReadLine());

            }

            // Calculate BMI 
            Bmi(eachPersonData);

            // Get BMI status 
            string[] bmiStatus = BMIStatus(eachPersonData);

            // Display final results
            Console.WriteLine("\nBMI REPORT : ");
            Console.WriteLine("Person\tWeight\tHeight\tBMI\t\tStatus");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(
                    $"{i + 1}\t{eachPersonData[i, 0]}\t{eachPersonData[i, 1]}\t" +
                    $"{eachPersonData[i, 2]:F2}\t\t{bmiStatus[i]}"
                );
            }
        }
    }
}
