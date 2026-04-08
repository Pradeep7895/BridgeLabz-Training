using Collections.collection_csharp_practice.gcr_codebase.generics.resume_screening_system;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.generics.resume_screening_system
{
    internal class ResumeMenu
    {
        private ResumeUtility utility = new ResumeUtility();

        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("\n==== Resume Screening Menu ====");
                Console.WriteLine("1. Add Software Engineer Resume");
                Console.WriteLine("2. Add Data Scientist Resume");
                Console.WriteLine("3. View Software Engineer Resumes");
                Console.WriteLine("4. View Data Scientist Resumes");
                Console.WriteLine("0. Exit");

                Console.Write("Enter choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        utility.ProcessResume(
                            utility.GetSoftwareEngineers(),
                            CreateSoftwareEngineer());
                        break;

                    case 2:
                        utility.ProcessResume(
                            utility.GetDataScientists(),
                            CreateDataScientist());
                        break;

                    case 3:
                        utility.DisplayResumes(
                            utility.GetSoftwareEngineers().GetCandidates());
                        break;

                    case 4:
                        utility.DisplayResumes(
                            utility.GetDataScientists().GetCandidates());
                        break;

                    case 0:
                        return;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }

        private SoftwareEngineer CreateSoftwareEngineer()
        {
            Console.Write("Candidate ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Candidate Name: ");
            string name = Console.ReadLine();

            Console.Write("Coding Score: ");
            int score = int.Parse(Console.ReadLine());

            return new SoftwareEngineer(id, name, score);
        }

        private DataScientist CreateDataScientist()
        {
            Console.Write("Candidate ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Candidate Name: ");
            string name = Console.ReadLine();

            Console.Write("ML Score: ");
            int score = int.Parse(Console.ReadLine());

            return new DataScientist(id, name, score);
        }
    }

}
