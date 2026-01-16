using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.address_book_system
{
    internal interface IAddressBook
    {
        //for contacts
        void AddContact();
        void DisplayAllContacts();
        void EditContactByName();
        void DeleteContactByName();
        void AddMultipleContacts();

        //for multiple address books
        void CreateAddressBook();
        void SelectAddressBook();
        void DisplayAddressBooks();
        bool IsAddressBookSelected();

         // UC-8
        void SearchPersonByCity();
        void SearchPersonByState();
        
         //UC-9
        void SearchContactInCityOrState();
        
    }
}
