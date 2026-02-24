using System.Collections.Generic;

namespace AddressBookSystem
{
    internal class AddressBook
    {
        private List<Contact> Contacts;
        private int MaxSize;

        private List<AddressBook> addressBooks;
        private List<string> addressBookNames;

        public AddressBook(int maxBooks, int maxContacts)
        {
            MaxSize = maxContacts;
            Contacts = new List<Contact>();
            addressBooks = new List<AddressBook>();
            addressBookNames = new List<string>();
        }

        public int GetMaxSize() => MaxSize;

        public List<Contact> GetContacts() => Contacts;

        public List<AddressBook> GetAddressBooks() => addressBooks;

        public List<string> GetAddressBookNames() => addressBookNames;

        public int GetCurrentIndex() => Contacts.Count;

        public int GetAddressBookCount() => addressBooks.Count;

        public override string ToString()
        {
            return $"Max Size: {MaxSize} | Current Contacts: {Contacts.Count}";
        }
    }
}