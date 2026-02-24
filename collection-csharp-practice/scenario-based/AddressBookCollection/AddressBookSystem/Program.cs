using System;

namespace AddressBookSystem
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                // System level address book (holds multiple address books)
                AddressBook systemBook = new AddressBook(10, 100);

                IDataSource dataSource = new DatabaseDataSource();

                // Utility class implementing IAddressBook
                IAddressBook addressBookUtility = new AddressBookUtility(systemBook, dataSource);

                // Menu
                Menu menu = new Menu(addressBookUtility);

                // Start Application
                await menu.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected Error: " + ex.Message);
            }

            Console.WriteLine("\nApplication Closed.");
        }
    }
}