using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.arrays.level2
{
    internal class StudentGrade
    { 
        static void Main()
        {
            //take input for numbers
            Console.Write("Enter number of students: ");
            int n = int.Parse(Console.ReadLine());

            //Arrays to store data
            int[] physics = new int[n];
            int[] chemistry = new int[n];
            int[] maths = new int[n];
            double[] percentage = new double[n];
            char[] grade = new char[n];

            //take input for marks
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("\nStudent " + (i + 1));

                Console.Write("Enter Physics marks: ");
                physics[i] = int.Parse(Console.ReadLine());

                Console.Write("Enter Chemistry marks: ");
                chemistry[i] = int.Parse(Console.ReadLine());

                Console.Write("Enter Maths marks: ");
                maths[i] = int.Parse(Console.ReadLine());

                // Validation for negative marks
                if (physics[i] < 0 || chemistry[i] < 0 || maths[i] < 0)
                {
                    Console.WriteLine("Marks cannot be negative. Please re-enter.");
                    i--; // repeat the same student
                    continue;
                }
            }

            // claculate grade anf percent
            for (int i = 0; i < n; i++)
            {

                int total = physics[i] + chemistry[i] + maths[i];

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

            //display result
            Console.WriteLine("\nSTUDENT RESULT : ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nStudent " + (i + 1));
                Console.WriteLine("Physics : " + physics[i]);
                Console.WriteLine("Chemistry : " + chemistry[i]);
                Console.WriteLine("Maths : " + maths[i]);
                Console.WriteLine("Percentage: " + percentage[i]);
                Console.WriteLine("Grade : " + grade[i]);
            }
        }
    }
}
