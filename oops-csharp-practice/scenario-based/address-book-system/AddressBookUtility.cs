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
        private AddressBook addressBook;

        //constructor 
        public AddressBookUtility(AddressBook addressBook)
        {
            this.addressBook = addressBook;
        }

        //method to add contact 
        public void AddContact()
        {
            if(addressBook.GetCurrentIndex() >= addressBook.GetMaxSize())
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

            addressBook.GetContacts()[addressBook.GetCurrentIndex()] = contact;
            addressBook.SetCurrentIndex(addressBook.GetCurrentIndex() + 1);

            Console.WriteLine("Contact added successfully");
        }

        public void DisplayAllContacts()
        {
            if(addressBook.GetCurrentIndex()==0)
            {
                Console.WriteLine("No contacts Available");
                return;
             
            }
            Console.WriteLine("\nContact List: ");
            for(int i=0;i<addressBook.GetCurrentIndex();i++)
            {
                Console.WriteLine(addressBook.GetContacts()[i]);
            }

        }
        public void EditContactByName()
        {
            Console.Write("Enter first name of contact to edit: ");
            string searchName = Console.ReadLine();

            for(int i = 0; i < addressBook.GetCurrentIndex(); i++)
            {
                Contact contact = addressBook.GetContacts()[i];

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

            for(int i = 0;i < addressBook.GetCurrentIndex(); i++)
            {
                //check for the first name in the array of contact to be equal to the name provided 
                if (addressBook.GetContacts()[i].GetFirstName().Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    //shift the contact to left
                    for(int j=i;j<addressBook.GetCurrentIndex();j++)
                    {
                        addressBook.GetContacts()[j] = addressBook.GetContacts()[j + 1];
                    }
                    //set the contact to null
                    addressBook.GetContacts()[addressBook.GetCurrentIndex() - 1] = null;
                    addressBook.SetCurrentIndex(addressBook.GetCurrentIndex() - 1);

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
               addressBook.GetMaxSize() - addressBook.GetCurrentIndex();

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

    }
}
