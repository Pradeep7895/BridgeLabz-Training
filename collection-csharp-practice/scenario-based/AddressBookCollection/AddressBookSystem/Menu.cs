using System;

namespace AddressBookSystem
{
    internal class Menu
    {
        private IAddressBook addressBook;

        public Menu(IAddressBook addressBook)
        {
            this.addressBook = addressBook;
        }

        public async Task Start()
        {
            int choice;
            do
            {
                Console.WriteLine("\n===== Address Book System =====");
                Console.WriteLine("1. Create Address Book");
                Console.WriteLine("2. Open Address Book");
                Console.WriteLine("3. Display Address Books");
                Console.WriteLine("4. Manage Contacts");
                Console.WriteLine("5. Search Person By City");
                Console.WriteLine("6. Search Person By State");
                Console.WriteLine("7. Search Person By City / State");
                Console.WriteLine("8. Count Persons By City and State");
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
                            Console.WriteLine("Please open an Address Book first.");
                        else
                            ShowContactMenu();
                        break;
                    case 5:
                        addressBook.SearchPersonByCity();
                        break;
                    case 6:
                        addressBook.SearchPersonByState();
                        break;
                    case 7:
                        addressBook.SearchContactInCityOrState();
                        break;
                    case 8:
                        addressBook.CountContactsByCityOrState();
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

        private async Task ShowContactMenu()
        {
            int option;
            do
            {
                Console.WriteLine("\nContact Menu:");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Display All Contacts");
                Console.WriteLine("3. Edit Contact");
                Console.WriteLine("4. Delete Contact");
                Console.WriteLine("5. Add Multiple Contacts");
                Console.WriteLine("6. Sort Contacts By First Name");
                Console.WriteLine("7. Sort Contacts By City");
                Console.WriteLine("8. Sort Contacts By State");
                Console.WriteLine("9. Sort Contacts By Zip");
                Console.WriteLine("10. Write Contacts To File");
                Console.WriteLine("11. Read Contacts From File");
                Console.WriteLine("12. Write Contacts To CSV");
                Console.WriteLine("13. Read Contacts From CSV");
                Console.WriteLine("14. Write Contacts To JSON");
                Console.WriteLine("15. Read Contacts From JSON");
                Console.WriteLine("16. Save To Database");
                Console.WriteLine("17. Load From Database");
                Console.WriteLine("18. Delete Contact From Database");
                Console.WriteLine("0. Exit");

                Console.Write("Enter choice: ");
                option = int.Parse(Console.ReadLine());

                switch (option)
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
                    case 6:
                        addressBook.SortContactsByFirstName();
                        break;
                    case 7:
                        addressBook.SortContactsByCity();
                        break;
                    case 8:
                        addressBook.SortContactsByState();
                        break;
                    case 9:
                        addressBook.SortContactsByZip();
                        break;
                    case 10:
                        addressBook.WriteContactsToFile();
                        break;
                    case 11:
                        addressBook.ReadContactsFromFile();
                        break;
                    case 12:
                        await addressBook.WriteContactsToCSVAsync();
                        break;

                    case 13:
                        await addressBook.ReadContactsFromCSVAsync();
                        break;

                    case 14:
                        await addressBook.WriteContactsToJSONAsync();
                        break;

                    case 15:
                        await addressBook.ReadContactsFromJSONAsync();
                        break;
                    case 16:
                        await addressBook.SaveToDatabaseAsync();
                        break;

                    case 17:
                        await addressBook.LoadFromDatabaseAsync();
                        break;
                    case 18:
                        await addressBook.DeleteContactFromDatabaseAsync();
                        break;
                    case 0:
                        Console.WriteLine("Exiting Contact Menu...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

            } while (option != 0);
        }
    }
}