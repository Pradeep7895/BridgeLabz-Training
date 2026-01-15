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
                Console.WriteLine("\nAddress Book Menu : ");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Display All Contacts");
                Console.WriteLine("3. Edit Contact By Name");
                Console.WriteLine("4. Delete Contact By Name");
                Console.WriteLine("5. Add Multiple Contacts");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");
                choice = int.Parse(Console.ReadLine());

                switch(choice)
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
            } while (choice != 0);
        }
    }
}
