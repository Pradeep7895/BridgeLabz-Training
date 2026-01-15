using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.address_book_system
{
    internal interface IAddressBook
    {
        void AddContact();
        void DisplayAllContacts();
        void EditContactByName();
        void DeleteContactByName();
    }
}
