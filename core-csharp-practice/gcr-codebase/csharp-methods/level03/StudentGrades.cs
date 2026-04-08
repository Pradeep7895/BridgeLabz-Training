using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level03
{
    internal class StudentGrades
    {
        // generate random 2-digit scores for PCM
        public static int[,] PCMScores(int numberOfStudents)
        {
            // Column 0 -> Physics
            // Column 1 -> Chemistry
            // Column 2 -> Math
            int[,] scores = new int[numberOfStudents, 3];
            Random random = new Random();

            for (int i = 0; i < numberOfStudents; i++)
            {
                //2-digit marks (10 to 99)
                scores[i, 0] = random.Next(10, 100);
                scores[i, 1] = random.Next(10, 100);
                scores[i, 2] = random.Next(10, 100);
            }

            return scores;
        }

        //calculate Total, Average, and Percentage

        public static double[,] Results(int[,] scores)
        {
            // Column 0 -> Total
            // Column 1 -> Average
            // Column 2 -> Percentage
            int students = scores.GetLength(0);
            double[,] results = new double[students, 3];

            for (int i = 0; i < students; i++)
            {
                int total = scores[i, 0] + scores[i, 1] + scores[i, 2];
                double average = total / 3.0;
                double percentage = (total / 300.0) * 100;

                // Round off to 2 decimal places
                results[i, 0] = Math.Round((double)total, 2);
                results[i, 1] = Math.Round(average, 2);
                results[i, 2] = Math.Round(percentage, 2);
            }

            return results;
        }

        //determine grade 
        public static string Grade(double percentage)
        {
            if (percentage >= 80)
                return "A";
            else if (percentage >= 70)
                return "B";
            else if (percentage >= 60)
                return "C";
            else if (percentage >= 50)
                return "D";
            else if (percentage >= 40)
                return "E";
            else
                return "R";
        }

        // display in tabular format
        public static void Scorecard(int[,] scores, double[,] results)
        {
            int students = scores.GetLength(0);

            Console.WriteLine("\nStudent\tPhysics\tChemistry\tMath\tTotal\tAverage\tPercentage\tGrade");

            for (int i = 0; i < students; i++)
            {
                string grade = Grade(results[i, 2]);

                Console.WriteLine(
                    $"{i + 1}\t{scores[i, 0]}\t{scores[i, 1]}\t\t{scores[i, 2]}\t" +
                    $"{results[i, 0]}\t{results[i, 1]}\t{results[i, 2]}\t\t{grade}"
                );
            }
        }

        static void Main()
        {
            //number of students
            Console.Write("Enter number of students: ");
            int numberOfStudents = int.Parse(Console.ReadLine());

            //Generate PCM scores
            int[,] scores = PCMScores(numberOfStudents);

            // Calculate results
            double[,] results = Results(scores);

            // Step 3: Display scorecard
            Scorecard(scores, results);
        }

    }
}

