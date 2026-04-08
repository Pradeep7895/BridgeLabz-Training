using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.address_book_system
{
    internal class AddressBook
    {
        //for contacts 
        private Contact[] Contacts;
        private int MaxSize;
        private int IndexAtCurrent;

        //for multiple address books
        private AddressBook[] addressBooks;
        private string[] addressBookNames;
        private int addressBookCount;
        

        public AddressBook(int maxBooks, int maxContacts)
        {
            MaxSize = maxContacts;
            Contacts = new Contact[MaxSize];
            IndexAtCurrent = 0;

            addressBooks = new AddressBook[maxBooks];
            addressBookNames = new string[maxBooks];
            addressBookCount = 0;
          
        }

        //getter and setter
        //for contacts
        public int GetMaxSize()
        {
            return MaxSize;
        }

        public Contact[] GetContacts()
        {
            return Contacts;
        }

        public int GetCurrentIndex()
        {
            return IndexAtCurrent;
        }

        public void SetCurrentIndex(int index)
        {
            IndexAtCurrent = index;

        }
        //for multiple address books
        public AddressBook[] GetAddressBooks()
        {
            return addressBooks;
        }
        public string[] GetAddressBookNames()
        {
            return addressBookNames;
        }
        public int GetAddressBookCount()
        {
            return addressBookCount;
        }
        public void SetAddressbookCount(int count)
        {
            addressBookCount = count;
        }

        // Overriding ToString .
        public override string ToString()
        {
            return $"Max Size: {MaxSize} | Current Index: {IndexAtCurrent}";
        }

    }
}
