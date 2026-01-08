using BridgeLabzTraining.oops_csharp_practice.gcr_codebase.encapsulation_polymorphism_interface_abstractclass.library_management_system;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.encapsulation_polymorphism_interface_abstractclass.library_management_system
{
    internal class Menu
    {
        private LibraryUtility Utility = new LibraryUtility();

        public void Start()
        {
            while (true)
            {
                Console.WriteLine("\nLibrary Management System : ");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Add Magazine");
                Console.WriteLine("3. Add DVD");
                Console.WriteLine("4. Display All Items");
                Console.WriteLine("5. Reserve Item");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Utility.AddBook();
                        break;
                    case 2:
                        Utility.AddMagazine();
                        break;
                    case 3:
                        Utility.AddDVD();
                        break;
                    case 4:
                        Utility.DisplayItems();
                        break;
                    case 5:
                        Utility.ReserveItem();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }

    }
}

   