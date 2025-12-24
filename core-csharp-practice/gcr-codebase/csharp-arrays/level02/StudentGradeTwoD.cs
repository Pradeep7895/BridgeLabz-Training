using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.arrays.level2
{
    internal class StudentGradeTwoD
    {
        static void Main()
        {
            //Take input for number
            Console.Write("Enter number of students: ");
            int n = Convert.ToInt32(Console.ReadLine());

            //2D array 
            // Column 0 -> Physics, 1 -> Chemistry, 2 -> Maths

            int[,] marks = new int[n, 3];

            // Arrays to store percentage and grade
            double[] percentage = new double[n];
            char[] grade = new char[n];

            // Take input for marks

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nStudent " + (i + 1));

                Console.Write("Enter Physics marks: ");
                marks[i, 0] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Chemistry marks: ");
                marks[i, 1] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Maths marks: ");
                marks[i, 2] = Convert.ToInt32(Console.ReadLine());

                // Validation for negative marks
                if (marks[i, 0] < 0 || marks[i, 1] < 0 || marks[i, 2] < 0)
                {
                    Console.WriteLine("Marks cannot be negative. Re-enter details.");
                    i--; // repeat same student
                    continue;
                }
            }

            //Calculate percentage and grade
            for (int i = 0; i < n; i++)
            {
                int total = marks[i, 0] + marks[i, 1] + marks[i, 2];
                percentage[i] = total / 3.0;

                if (percentage[i] >= 80)
                    grade[i] = 'A';
                else if (percentage[i] >= 70)
                    grade[i] = 'B';
                else if (percentage[i] >= 60)
                    grade[i] = 'C';
                else if (percentage[i] >= 50)
                    grade[i] = 'D';
                else if (percentage[i] >= 40)
                    grade[i] = 'E';
                else
                    grade[i] = 'R';
            }

            //display results
            Console.WriteLine("\nSTUDENT RESULTS : ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nStudent " + (i + 1));
                Console.WriteLine("Physics   : " + marks[i, 0]);
                Console.WriteLine("Chemistry : " + marks[i, 1]);
                Console.WriteLine("Maths     : " + marks[i, 2]);
                Console.WriteLine("Percentage: " + percentage[i]);
                Console.WriteLine("Grade     : " + grade[i]);
            }
        }
    }
}
