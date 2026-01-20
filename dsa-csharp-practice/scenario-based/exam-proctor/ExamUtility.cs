using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.exam_proctor
{
    internal class ExamUtility : IExam
    {
        private StackLinkedList Stack = new StackLinkedList();
        private Student student;

        // Dictionary to store correct answers
        private Dictionary<int, string> correctAnswers = new Dictionary<int, string>()
            {
            { 1, "A" },
            { 2, "D" },
            { 3, "C" },
            { 4, "D" },
            { 5, "A" },
            { 6, "A" },
            { 7, "C" },
            { 8, "D" },
            { 9, "C" },
            { 10, "B" },
            };

        // Dictionary to store students answers
        private Dictionary<int, string> studentAnswers = new Dictionary<int, string>();

        // Add student
        public void AddStudent()
        {
            Console.Write("Enter Student ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();

            student = new Student(id, name);
            Console.WriteLine("Student registered successfully.");
        }

        // Visit a question
        public void VisitQuestion()
        {
            Console.Write("Enter Question ID to visit (1-10): ");
            int qid = int.Parse(Console.ReadLine());

            if (!correctAnswers.ContainsKey(qid))
            {
                Console.WriteLine("Invalid Question ID.");
                return;
            }

            Stack.Push(qid);
            Console.WriteLine($"Visited Question {qid}");
        }

        // Answer current question
        public void AnswerQuestion()
        {
            int currentQuestion = Stack.Peek();

            if (currentQuestion == -1)
            {
                Console.WriteLine(" No question visited.");
                return;
            }

            Console.Write($"Enter answer for {currentQuestion}: ");
            string answer = Console.ReadLine();

            studentAnswers[currentQuestion] = answer;
            Console.WriteLine(" Answer saved.");
        }

        // Go back to previous question
        public void GoBack()
        {
            if (Stack.IsEmpty())
            {
                Console.WriteLine("No previous question.");
                return;
            }

            Stack.Pop();
            int current = Stack.Peek();

            if (current != -1)
                Console.WriteLine($"Returned to Question {current}");
            else
                Console.WriteLine("No active question.");
        }

        // Submit exam
        public void SubmitExam()
        {
            if (student == null)
            {
                Console.WriteLine("No student registered.");
                return;
            }

            student.Display();
            int score = CalculateScore();

            Console.WriteLine($"\nFinal Score: {score}/{correctAnswers.Count}");
        }

        // Function to calculate score
        private int CalculateScore()
        {
            int score = 0;

            foreach (var entry in correctAnswers)
            {
                int questionId = entry.Key;
                string correctAnswer = entry.Value;

                if (studentAnswers.ContainsKey(questionId) &&
                    studentAnswers[questionId]
                        .Equals(correctAnswer, StringComparison.OrdinalIgnoreCase))
                {
                    score++;
                }
            }
            return score;
        }

    }
}

    