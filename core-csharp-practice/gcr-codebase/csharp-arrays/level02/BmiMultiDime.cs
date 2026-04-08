using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.arrays.level2
{
    internal class BmiMultiDime
    {
        static void Main()
        {
            //take input for number
            Console.Write("Enter number of person : ");
            int number = int.Parse(Console.ReadLine());

            //multi dimensional array
            // index0 = height
            // index1 = weight
            // index2 = bmi
            double[][] personData = new double[number][];
            string[] weightStatus = new string[number];

            //inner array
            for(int i = 0; i < number; i++)
            {
                personData[i] = new double[3];
            }

            //input for height and weight
            for(int i = 0; i < number; i++)
            {
                Console.WriteLine("\nPerson " + (i + 1));

                //height input with validation
                while (true)
                {
                    Console.Write("Enter height (metres): ");
                    double height = double.Parse(Console.ReadLine());

                    if(height > 0)
                    {
                        personData[i][0] = height;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Height will be positive.Please re-enter the height.");

                    }
                }

                //weight input and validation
                while (true)
                {
                    Console.Write("Enter weight (kg): ");
                    double weight = double.Parse(Console.ReadLine());

                    if (weight > 0)
                    {
                        personData[i][1] = weight;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Weight will be positive.Please re-enter the weight.");

                    }
                }
            }
            //calculate bmi 
            for(int i = 0; i < number;i++)
            {
                double height = personData[i][0];
                double weight = personData[i][1];

                personData[i][2] = weight/(height*height);

                if (personData[i][2] <= 18.4)
                    weightStatus[i] = "Underweight";
                else if (personData[i][2] >= 18.5 && personData[i][2] <= 24.9)
                    weightStatus[i] = "Normal";
                else if (personData[i][2] >= 25.0 && personData[i][2] <= 39.9)
                    weightStatus[i] = "Overweight";
                else
                    weightStatus[i] = "Obese";
            }

            //Diplay results
            Console.WriteLine("\nBMI REPORT : ");

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("\nPerson " + (i + 1));
                Console.WriteLine("Height : " + personData[i][0] + "meters");
                Console.WriteLine("Weight : " + personData[i][1] + " kg");
                Console.WriteLine("BMI : " + personData[i][2]);
                Console.WriteLine("Status : " + weightStatus[i]);
            }
        }
    }
}
