using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.exam_proctor
{
    internal class Menu
    {
        public void Start()
        {
            IExam exam = new ExamUtility();
            int choice;

            do
            {
                Console.WriteLine("\n====Exam Proctor Menu====");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Visit Question");
                Console.WriteLine("3. Answer Question");
                Console.WriteLine("4. Go Back");
                Console.WriteLine("5. Submit Exam");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        exam.AddStudent();
                        break;
                    case 2:
                        exam.VisitQuestion();
                        break;
                    case 3:
                        exam.AnswerQuestion();
                        break;
                    case 4:
                        exam.GoBack();
                        break;
                    case 5:
                        exam.SubmitExam();
                        break;
                    case 0:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

            } while (choice != 0);
        }

    }
}

    