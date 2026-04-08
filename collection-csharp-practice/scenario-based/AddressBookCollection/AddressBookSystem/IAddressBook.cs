using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal interface IAddressBook
    {
        void AddContact();
        void DisplayAllContacts();
        // for UC-3 editing contact method signature
        void EditContactByName();
        // for UC-4 deleting contact method signature
        void DeleteContactByName();
        void AddMultipleContacts();

        void CreateAddressBook();
        void SelectAddressBook();
        void DisplayAddressBooks();
        bool IsAddressBookSelected();

        void SearchPersonByCity();
        void SearchPersonByState();
        void SearchContactInCityOrState();
        // for UC-10 counting person by city or state accross multiple address book
        void CountContactsByCityOrState();
        // for UC-11 sorting contacts alphabetically
        void SortContactsByFirstName();

        //for UC-12 sorting 
        void SortContactsByCity();
        void SortContactsByState();
        void SortContactsByZip();

        // UC-13
        void WriteContactsToFile();
        void ReadContactsFromFile();

        // UC-14 CSV
        Task WriteContactsToCSVAsync();
        Task ReadContactsFromCSVAsync();

        // UC-15 JSON
        Task WriteContactsToJSONAsync();
        Task ReadContactsFromJSONAsync();

        //uc- 18
        Task SaveToDatabaseAsync();
        Task LoadFromDatabaseAsync();
        Task DeleteContactFromDatabaseAsync();
    }
}