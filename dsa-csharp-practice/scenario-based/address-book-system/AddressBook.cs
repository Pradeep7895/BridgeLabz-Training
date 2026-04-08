using System.Collections.Generic;

namespace BridgeLabz_Training.dsa_csharp_practice.scenario_based.address_book_system
{
    internal class AddressBook
    {
        // LinkedList instead of array
        private LinkedList<Contact> Contacts;
        private int MaxSize;

        // multiple address books
        private LinkedList<AddressBook> addressBooks;
        private LinkedList<string> addressBookNames;

        public AddressBook(int maxBooks, int maxContacts)
        {
            MaxSize = maxContacts;
            Contacts = new LinkedList<Contact>();

            addressBooks = new LinkedList<AddressBook>();
            addressBookNames = new LinkedList<string>();
        }

        // getters
        public int GetMaxSize() => MaxSize;

        public LinkedList<Contact> GetContacts() => Contacts;

        public LinkedList<AddressBook> GetAddressBooks() => addressBooks;

        public LinkedList<string> GetAddressBookNames() => addressBookNames;

        public int GetCurrentIndex() => Contacts.Count;

        public int GetAddressBookCount() => addressBooks.Count;

        public override string ToString()
        {
            return $"Max Size: {MaxSize} | Current Index: {Contacts.Count}";
        }
    }
}