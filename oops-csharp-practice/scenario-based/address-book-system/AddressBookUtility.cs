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


    }
}
