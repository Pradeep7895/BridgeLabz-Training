using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.address_book_system
{
    internal class Program
    {
        static void Main()
        {
            AddressBook addressBook = new AddressBook(5);
            IAddressBook addressBookUtility = new AddressBookUtility(addressBook);

            Menu menu = new Menu(addressBookUtility);
            menu.Start();
        }
    }
}
