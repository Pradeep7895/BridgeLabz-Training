using System;

namespace BridgeLabz_Training.dsa_csharp_practice.scenario_based.address_book_system
{
    internal class AddressBookUtility : IAddressBook
    {
        private AddressBook systemBook;
        private AddressBook currentBook;

        public AddressBookUtility(AddressBook systemBook)
        {
            this.systemBook = systemBook;
        }

        public void AddContact()
        {
            if (currentBook == null)
            {
                Console.WriteLine("Please open an Address Book first.");
                return;
            }

            if (currentBook.GetContacts().Count >= currentBook.GetMaxSize())
            {
                Console.WriteLine("Address book is full");
                return;
            }

            Console.Write("Enter First name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter Last name: ");
            string lastName = Console.ReadLine();

            if (IsDuplicateContact(firstName, lastName))
            {
                Console.WriteLine("Duplicate contact found.");
                return;
            }

            Console.Write("Enter Address: ");
            string address = Console.ReadLine();

            Console.Write("Enter City: ");
            string city = Console.ReadLine();

            Console.Write("Enter State: ");
            string state = Console.ReadLine();

            Console.Write("Enter Zip: ");
            string zip = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            string phoneNumber = Console.ReadLine();

            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            currentBook.GetContacts()
                .AddLast(new Contact(firstName, lastName, address, city, state, zip, phoneNumber, email));

            Console.WriteLine("Contact added successfully");
        }

        private bool IsDuplicateContact(string firstName, string lastName)
        {
            foreach (var contact in currentBook.GetContacts())
            {
                if (contact.GetFirstName().Equals(firstName, StringComparison.OrdinalIgnoreCase) &&
                    contact.GetLastName().Equals(lastName, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

        public void DisplayAllContacts()
        {
            if (currentBook.GetContacts().Count == 0)
            {
                Console.WriteLine("No contacts Available");
                return;
            }

            Console.WriteLine("\nContact List:");
            foreach (var contact in currentBook.GetContacts())
                Console.WriteLine(contact);
        }

        public void EditContactByName()
        {
            Console.Write("Enter first name of contact to edit: ");
            string name = Console.ReadLine();

            foreach (var contact in currentBook.GetContacts())
            {
                if (contact.GetFirstName().Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("New First Name: ");
                    contact.SetFirstName(Console.ReadLine());
                    Console.Write("New Last Name: ");
                    contact.SetLastName(Console.ReadLine());
                    Console.Write("New Address: ");
                    contact.SetAddress(Console.ReadLine());
                    Console.Write("New City: ");
                    contact.SetCity(Console.ReadLine());
                    Console.Write("New State: ");
                    contact.SetState(Console.ReadLine());
                    Console.Write("New Zip: ");
                    contact.SetZip(Console.ReadLine());
                    Console.Write("New Phone Number: ");
                    contact.SetPhoneNumber(Console.ReadLine());
                    Console.Write("New Email: ");
                    contact.SetEmail(Console.ReadLine());

                    Console.WriteLine("Contact updated successfully.");
                    return;
                }
            }
            Console.WriteLine("Contact not found.");
        }

        public void DeleteContactByName()
        {
            Console.Write("Enter first name of contact to delete: ");
            string name = Console.ReadLine();

            var node = currentBook.GetContacts().First;
            while (node != null)
            {
                if (node.Value.GetFirstName().Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    currentBook.GetContacts().Remove(node);
                    Console.WriteLine("Contact deleted successfully.");
                    return;
                }
                node = node.Next;
            }

            Console.WriteLine("Contact not found.");
        }

        public void AddMultipleContacts()
        {
            Console.Write("How many contacts you want to add: ");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
                AddContact();
        }

        public void CreateAddressBook()
        {
            Console.Write("Enter Address Book name: ");
            string name = Console.ReadLine();

            systemBook.GetAddressBookNames().AddLast(name);
            systemBook.GetAddressBooks().AddLast(new AddressBook(0, 10));

            Console.WriteLine("Address Book Created successfully.");
        }

        public void SelectAddressBook()
        {
            Console.Write("Enter Address Book Name: ");
            string name = Console.ReadLine();

            var bookNode = systemBook.GetAddressBooks().First;
            var nameNode = systemBook.GetAddressBookNames().First;

            while (bookNode != null)
            {
                if (nameNode.Value.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    currentBook = bookNode.Value;
                    Console.WriteLine("Address Book opened successfully.");
                    return;
                }
                bookNode = bookNode.Next;
                nameNode = nameNode.Next;
            }

            Console.WriteLine("Address Book not found.");
        }

        public void DisplayAddressBooks()
        {
            foreach (var name in systemBook.GetAddressBookNames())
                Console.WriteLine($"- {name}");
        }
        
        public bool IsAddressBookSelected()
        {
            return currentBook != null;
        }

        public void SearchPersonByCity()
        {
            Console.Write("Enter City name to search: ");
            string city = Console.ReadLine()!;

            bool found = false;

            // Loop through all Address Books (LinkedList)
            foreach (AddressBook book in systemBook.GetAddressBooks())
            {
                // Loop through all Contacts in Address Book (LinkedList)
                foreach (Contact contact in book.GetContacts())
                {
                    if (contact.GetCity().Equals(city, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine(contact);
                        found = true;
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine("No persons found in this city.");
            }
        }


        public void SearchPersonByState()
        {
            Console.Write("Enter State name to search: ");
            string state = Console.ReadLine()!;

            bool found = false;

            // Loop through all Address Books (LinkedList)
            foreach (AddressBook book in systemBook.GetAddressBooks())
            {
                // Loop through all Contacts in Address Book (LinkedList)
                foreach (Contact contact in book.GetContacts())
                {
                    if (contact.GetState().Equals(state, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine(contact);
                        found = true;
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine("No persons found in this state.");
            }
        }
        public void SearchContactInCityOrState()
        {
            Console.Write("Search by (1) City or (2) State: ");
            int choice = int.Parse(Console.ReadLine()!);

            Console.Write("Enter name: ");
            string input = Console.ReadLine()!;

            bool found = false;

            foreach (AddressBook book in systemBook.GetAddressBooks())
            {
                foreach (Contact contact in book.GetContacts())
                {
                    if (choice == 1 &&
                        contact.GetCity().Equals(input, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine(contact);
                        found = true;
                    }
                    else if (choice == 2 &&
                        contact.GetState().Equals(input, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine(contact);
                        found = true;
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine("No persons found.");
            }
        }
        public void CountContactsByCityOrState()
        {
            Console.WriteLine("\nCount Contacts By City or State : \n");

            Console.Write("Please enter the city or state name: ");
            string search = Console.ReadLine()!;

            int contactsCount = 0;

            foreach (AddressBook book in systemBook.GetAddressBooks())
            {
                foreach (Contact contact in book.GetContacts())
                {
                    if (contact.GetCity().Equals(search, StringComparison.OrdinalIgnoreCase) ||
                        contact.GetState().Equals(search, StringComparison.OrdinalIgnoreCase))
                    {
                        contactsCount++;
                    }
                }
            }

            Console.WriteLine(
                $"\nThe number of contacts persons residing in '{search}' is: {contactsCount}\n"
            );
        }


        public void SortContactsByFirstName()
        {
            Console.WriteLine("\nResult of sorting contacts alphabetically by First Name : \n");

            foreach (AddressBook book in systemBook.GetAddressBooks())
            {
                if (book.GetContacts().Count > 1)
                {
                    // Convert LinkedList → List
                    List<Contact> list = book.GetContacts().ToList();

                    // Sort list
                    list.Sort((a, b) =>
                        string.Compare(a.GetFirstName(), b.GetFirstName(), StringComparison.OrdinalIgnoreCase));

                    // Clear and re-add to LinkedList
                    book.GetContacts().Clear();
                    foreach (var contact in list)
                        book.GetContacts().AddLast(contact);
                }
            }

            DisplayAllContacts();
        }

    }
}