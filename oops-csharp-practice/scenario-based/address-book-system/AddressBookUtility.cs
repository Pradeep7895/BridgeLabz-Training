using BridgeLabzTraining.oops_csharp_practice.scenario_based.address_book_system;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.address_book_system
{
    internal class AddressBookUtility : IAddressBook
    {
        private AddressBook systemBook;
        private AddressBook currentBook;

        //constructor 
        public AddressBookUtility(AddressBook systemBook)
        {
            this.systemBook = systemBook;
        }

        //method to add contact 
        public void AddContact()
        {
            //check for if currentbook is empty or not
            if (currentBook == null)
            {
                Console.WriteLine("Please open an Address Book first.");
                return;
            }

            if (currentBook.GetCurrentIndex() >= currentBook.GetMaxSize())
            {
                Console.WriteLine("Address book is full");
                return;
            }

            Console.Write("Enter First name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter Last name: ");
            string lastName = Console.ReadLine();

            //UC-7 DUPLICATE CHECK
            if (IsDuplicateContact(firstName, lastName))
            {
                Console.WriteLine("Duplicate contact found. Contact not added.");
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

            Contact contact = new Contact(firstName, lastName, address, city, state, zip, phoneNumber, email);

            currentBook.GetContacts()[currentBook.GetCurrentIndex()] = contact;
            currentBook.SetCurrentIndex(currentBook.GetCurrentIndex() + 1);

            Console.WriteLine("Contact added successfully");
        }
        //UC-7
        //helper method to check for duplicate names
        //if exists, return true
        //else returns false;
        private bool IsDuplicateContact(string firstName, string lastName)
        {
            for (int i = 0; i < currentBook.GetCurrentIndex(); i++)
            {
                Contact existing = currentBook.GetContacts()[i];

                if (existing.GetFirstName().Equals(firstName, StringComparison.OrdinalIgnoreCase) &&
                    existing.GetLastName().Equals(lastName, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }


        public void DisplayAllContacts()
        {
            if(currentBook.GetCurrentIndex()==0)
            {
                Console.WriteLine("No contacts Available");
                return;
             
            }
            Console.WriteLine("\nContact List: ");
            for(int i=0;i<currentBook.GetCurrentIndex();i++)
            {
                Console.WriteLine(currentBook.GetContacts()[i]);
            }

        }
        public void EditContactByName()
        {
            Console.Write("Enter first name of contact to edit: ");
            string searchName = Console.ReadLine();

            for(int i = 0; i < currentBook.GetCurrentIndex(); i++)
            {
                Contact contact = currentBook.GetContacts()[i];

                if(contact.GetFirstName().Equals(searchName, StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("Contact is found. Enter the updated values");

                    Console.Write("\nNew First Name: ");
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

        //UC -4 delete contact by name
        public void DeleteContactByName()
        {
            Console.Write("Enter first name of the contact to delete: ");
            string name = Console.ReadLine();

            for(int i = 0;i < currentBook.GetCurrentIndex(); i++)
            {
                //check for the first name in the array of contact to be equal to the name provided 
                if (currentBook.GetContacts()[i].GetFirstName().Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    //shift the contact to left
                    for(int j=i;j<currentBook.GetCurrentIndex();j++)
                    {
                        currentBook.GetContacts()[j] = currentBook.GetContacts()[j + 1];
                    }
                    //set the contact to null
                    currentBook.GetContacts()[currentBook.GetCurrentIndex() - 1] = null;
                    currentBook.SetCurrentIndex(currentBook.GetCurrentIndex() - 1);

                    Console.WriteLine("Contact deleted successfully.");
                    return;
                }
            }
            Console.WriteLine("Contact not found.");
        }

        // Add multiple contacts using array
        public void AddMultipleContacts()
        {
            //find the remaining number for add contacts
            int remainingSlots =
               currentBook.GetMaxSize() - currentBook.GetCurrentIndex();

            //if slots are equal to 0 , then address book is full, we can not add more contacts
            if (remainingSlots == 0)
            {
                Console.WriteLine("Address Book is full. Cannot add more contacts.");
                return;
            }

            Console.WriteLine($"You can add up to {remainingSlots} more contact(s).");
            Console.Write("How many contacts do you want to add? ");
            int count = int.Parse(Console.ReadLine());

            if (count > remainingSlots)
            {
                Console.WriteLine("Not space in Address Book.");
                return;
            }
            //to add more contacts in address bbok
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"\nAdding contact {i + 1}:");
                AddContact();
            }
        }

        //UC-6 for multiple address book'
        //method to create addrress book
        public void CreateAddressBook()
        {
            //to check if address book is empty or full
            if(systemBook.GetAddressBookCount() >= systemBook.GetAddressBooks().Length)
            {
                Console.WriteLine("Maximum address books limit reached.");
                return;
            }

            Console.Write("Enter Address Book name: ");
            string name  = Console.ReadLine();

            //check for if address book is already exists or not with same name
            for(int i=0;i<systemBook.GetAddressBookCount();i++)
            {
                if (systemBook.GetAddressBookNames()[i].Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Address Book already exists.");
                    return;
                }
            }

            Console.Write("Enter max contacts for this Address book: ");
            int size = int.Parse(Console.ReadLine());

            //create a new address book
            AddressBook newBook = new AddressBook(0, size);

            //assigning newbook and name to the current index of address book
            int index = systemBook.GetAddressBookCount();
            systemBook.GetAddressBooks()[index] = newBook;
            systemBook.GetAddressBookNames()[index] = name;
            systemBook.SetAddressbookCount(index + 1);

            Console.WriteLine("Address Book Created successfully.");
        }

        //method to select a address book
        public void SelectAddressBook()
        {
            Console.Write("Enter Address Book Name to open: ");
            string name = Console.ReadLine();

            for (int i = 0; i < systemBook.GetAddressBookCount(); i++)
            {
                //check for address book exists with same name , if exists open it otherwise book not found
                if (systemBook.GetAddressBookNames()[i]
                    .Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    currentBook = systemBook.GetAddressBooks()[i];
                    Console.WriteLine("Address Book opened successfully.");
                    return;
                }
            }

            Console.WriteLine("Address Book not found.");
        }

        //method to display address books 
        public void DisplayAddressBooks()
        {
            //check for availabity 
            if (systemBook.GetAddressBookCount() == 0)
            {
                Console.WriteLine("No Address Books available.");
                return;
            }
            //here displaying available address books
            Console.WriteLine("Available Address Books:");
            for (int i = 0; i < systemBook.GetAddressBookCount(); i++)
            {
                Console.WriteLine($"- {systemBook.GetAddressBookNames()[i]}");
            }
        }
        //check whether address book is selected or not 
        public bool IsAddressBookSelected()
        {
            return currentBook != null;
        }

        // UC-8 SEARCH BY CITY 
        public void SearchPersonByCity()
        {
            Console.Write("Enter City name to search: ");
            string city = Console.ReadLine();

            // Flag to check whether any matching person is found
            bool found = false;

            // Loop through all Address Books
            for (int i = 0; i < systemBook.GetAddressBookCount(); i++)
            {
                // Get one Address Book
                AddressBook book = systemBook.GetAddressBooks()[i];

                // Loop through all contacts inside the current Address Book
                for (int j = 0; j < book.GetCurrentIndex(); j++)
                {
                    Contact contact = book.GetContacts()[j];

                    if (contact.GetCity().Equals(city, StringComparison.OrdinalIgnoreCase))
                    {
                        // Print contact details if match is found
                        Console.WriteLine(contact);
                        found = true;
                    }
                }
            }
            // If no matching contact
            if (!found)
            {
                Console.WriteLine("No persons found in this city.");
            }
        }

        // UC-8 SEARCH BY STATE 
        public void SearchPersonByState()
        {
            Console.Write("Enter State name to search: ");
            string state = Console.ReadLine();

            // Flag to check whether any matching person is found
            bool found = false;

            // Loop through all Address Books in the system
            for (int i = 0; i < systemBook.GetAddressBookCount(); i++)
            {
                AddressBook book = systemBook.GetAddressBooks()[i];

                // Loop through all contacts inside the current Address Book
                for (int j = 0; j < book.GetCurrentIndex(); j++)
                {
                    // Get the contact at current index
                    Contact contact = book.GetContacts()[j];

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
        // UC-9 VIEW PERSONS BY CITY OR STATE 
        public void SearchContactInCityOrState()
        {
            Console.Write("Search by (1) City or (2) State: ");
            int choice = int.Parse(Console.ReadLine());

            Console.Write("Enter name: ");
            string input = Console.ReadLine();

            bool found = false;

            // Loop through all Address Books
            for (int i = 0; i < systemBook.GetAddressBookCount(); i++)
            {
                AddressBook book = systemBook.GetAddressBooks()[i];

                // Loop through contacts of each Address Book
                for (int j = 0; j < book.GetCurrentIndex(); j++)
                {
                    Contact contact = book.GetContacts()[j];

                    // Search by City
                    if (choice == 1 &&
                        contact.GetCity().Equals(input, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine(contact);
                        found = true;
                    }

                    // Search by State
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

            // Take input from user (can be either city or state)
            Console.Write("Please enter the city or state name: ");
            string search = Console.ReadLine();

            int contactsCount = 0;

            // Loop through all Address Books
            for (int i = 0; i < systemBook.GetAddressBookCount(); i++)
            {
                AddressBook book = systemBook.GetAddressBooks()[i];

                // Loop through all contacts in each Address Book
                for (int j = 0; j < book.GetCurrentIndex(); j++)
                {
                    Contact contact = book.GetContacts()[j];

                    // Check if city OR state matches the search input
                    if (contact.GetCity().Equals(search, StringComparison.OrdinalIgnoreCase) ||
                        contact.GetState().Equals(search, StringComparison.OrdinalIgnoreCase))
                    {
                        contactsCount++;
                    }
                }
            }

            // Display final count
            Console.WriteLine(
                $"\nThe number of contacts persons residing in '{search}' is: {contactsCount}\n"
            );
        }

        //UC-11
        public void SortContactsByFirstName()
        {
            Console.WriteLine("\nResult of sorting contacts alphabetically by First Name : \n");

            // Loop through all Address Books
            for (int i = 0; i < systemBook.GetAddressBookCount(); i++)
            {
                AddressBook book = systemBook.GetAddressBooks()[i];

                if (book.GetCurrentIndex() > 1)
                {
                    QuickSort(book.GetContacts(), 0, book.GetCurrentIndex() - 1);
                }
            }

            // Display all contacts after sorting
            DisplayAllContacts();
        }
        private void QuickSort(Contact[] contacts, int left, int right)
        {
            if (left >= right)
            {
                return;
            }

            int pivotIndex = Partition(contacts, left, right);

            QuickSort(contacts, left, pivotIndex - 1);
            QuickSort(contacts, pivotIndex + 1, right);
        }
        private int Partition(Contact[] contacts, int left, int right)
        {
            Contact pivot = contacts[right];
            int boundary = left - 1;

            for (int i = left; i <= right - 1; i++)
            {
                // Compare First Names (case-insensitive)
                if (string.Compare(
                        contacts[i].GetFirstName(),
                        pivot.GetFirstName(),
                        StringComparison.OrdinalIgnoreCase) < 0)
                {
                    boundary++;

                    // Swap contacts[i] and contacts[boundary]
                    Contact temp = contacts[i];
                    contacts[i] = contacts[boundary];
                    contacts[boundary] = temp;
                }
            }

            // Place pivot in correct position
            contacts[right] = contacts[boundary + 1];
            contacts[boundary + 1] = pivot;

            return boundary + 1;
        }
    }
}
