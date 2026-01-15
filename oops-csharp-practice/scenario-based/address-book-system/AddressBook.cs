using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.address_book_system
{
    internal class AddressBook
    {
        private Contact[] Contacts;
        private int MaxSize;
        private int IndexAtCurrent;
        

        public AddressBook(int maxSize)
        {
            MaxSize = maxSize;
            Contacts = new Contact[MaxSize];
            IndexAtCurrent = 0;
          
        }

        //getter and setter
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
        // Overriding ToString .
        public override string ToString()
        {
            return $"Max Size: {MaxSize} | Current Index: {IndexAtCurrent}";
        }

    }
}
