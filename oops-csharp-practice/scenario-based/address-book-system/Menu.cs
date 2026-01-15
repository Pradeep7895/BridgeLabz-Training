using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.address_book_system
{
    internal class Menu
    {
        private IAddressBook addressBook;

        public Menu(IAddressBook addressBook)
        {
            this.addressBook = addressBook;
        }

        public void Start()
        {
            int choice;
            do
            {
                Console.WriteLine("\n=====Address Book System=====");
                Console.WriteLine("1. Create Address Book");
                Console.WriteLine("2. Open Address Book");
                Console.WriteLine("3. Display Address Books");
                Console.WriteLine("4. Manage Contacts");
                Console.WriteLine("5. Search Person By City");
                Console.WriteLine("6. Search Person By State");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");

                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        addressBook.CreateAddressBook();
                        break;
                    case 2:
                        addressBook.SelectAddressBook();
                        break;
                    case 3:
                        addressBook.DisplayAddressBooks(); 
                        break;
                    case 4:
                        if (!addressBook.IsAddressBookSelected())
                        {
                            Console.WriteLine("Please open an Address Book first.");
                        }
                        else
                        {
                            ShowContactMenu();
                        }
                        break;
                    case 5:
                        addressBook.SearchPersonByCity();
                        break;

                    case 6:
                        addressBook.SearchPersonByState();
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
        private void ShowContactMenu()
        {
            int option;

            do
            {
                Console.WriteLine("\nContact Menu : ");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Display All Contacts");
                Console.WriteLine("3. Edit Contact By Name");
                Console.WriteLine("4. Delete Contact By Name");
                Console.WriteLine("5. Add Multiple Contacts");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");
                option = int.Parse(Console.ReadLine());

                switch(option)
                {
                    case 1:
                        addressBook.AddContact();
                        break;
                    case 2:
                        addressBook.DisplayAllContacts();
                        break;
                    case 3:
                        addressBook.EditContactByName();
                        break;
                    case 4:
                        addressBook.DeleteContactByName();
                        break;
                    case 5:
                        addressBook.AddMultipleContacts();
                        break;
                    case 0:
                        Console.WriteLine("Exit..");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            } while (option != 0);
        }
    }
}
