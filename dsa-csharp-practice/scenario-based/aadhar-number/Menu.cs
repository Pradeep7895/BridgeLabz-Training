using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.aadhar_number
{
    internal class Menu
    {
        public void Start()
        {
            AadharUtility utility = new AadharUtility();
            int choice;

            do
            {
                Console.WriteLine("\n====== AADHAR MANAGEMENT ======");
                Console.WriteLine("1. Add Aadhar Details");
                Console.WriteLine("2. Display Aadhar Numbers");
                Console.WriteLine("3. Sort Aadhar Numbers (Radix Sort)");
                Console.WriteLine("4. Search Aadhar Number (Binary Search)");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");

                choice = int.Parse(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        utility.AddAadharDetails();
                        break;
                    case 2:
                        utility.Display();
                        break;
                    case 3:
                        utility.SortAadharNum();
                        break;
                    case 4:
                        utility.SearchAadhar();
                        break;
                    case 0:
                        Console.WriteLine("Exit...");
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break ;
                }

            } while (choice != 0);
        }
    }
}
