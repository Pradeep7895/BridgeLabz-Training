using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.core_csharp_practice.scenario_based
{
    internal class EduQuiz
    {
        //method to take answers from the student
        public string[] GetStudentAns(int totalQuestion)
        {
            string[] results = new string[totalQuestion];
            for (int i = 0; i < totalQuestion; i++)
            {
                Console.Write("Enter answer for Question " + (i + 1) + ": ");
                results[i] = Console.ReadLine();
            }
            return results;
        }

        //Method to check answers
        //and also calculate score
        public int CheckAnswers(string[] correctAnswers, string[] studentAnswers)
        {
            int score = 0;

            for (int i = 0; i < correctAnswers.Length; i++)
            {
                // Compare answers (case-insensitive)
                if (studentAnswers[i].Equals(correctAnswers[i], StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Question " + (i + 1) + ": Correct");
                    score++;
                }
                else
                {
                    Console.WriteLine("Question " + (i + 1) + ": Incorrect");
                }
            }

            return score;
        }
        static void Main()
        {
            //object of the class
            EduQuiz quiz = new EduQuiz();

            //totalQuestions
            int totalQuestions = 10;

            //correct answeers foe the quiz
            string[] correctAnswers =
            {
            "A", "C", "B", "D", "A", 
            "B", "C", "D", "A", "B" 
            };

            Console.WriteLine("Welcome to EduQuiz!");
            Console.WriteLine("Please answer the following questions:\n");

            // Get student answers
            string[] studentAnswers = quiz.GetStudentAns(totalQuestions);

            Console.WriteLine("\nChecking your answers...\n");

            // Check answers and get score
            int score = quiz.CheckAnswers(correctAnswers, studentAnswers);

            // Calculate percentage
            double percentage = (score * 100.0) / totalQuestions;

            // Show final result
            Console.WriteLine("\nYour Score: " + score + "/" + totalQuestions);
            Console.WriteLine("Percentage: " + percentage + "%");

            // Pass or fail
            if (percentage >= 50)
            {
                Console.WriteLine("Result: PASS");
            }
            else
            {
                Console.WriteLine("Result: FAIL");
            }

        }
    }
}
