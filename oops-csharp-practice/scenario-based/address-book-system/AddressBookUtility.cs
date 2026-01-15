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

            Console.WriteLine("Enter First name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter Last name: ");
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
        
    }
}
