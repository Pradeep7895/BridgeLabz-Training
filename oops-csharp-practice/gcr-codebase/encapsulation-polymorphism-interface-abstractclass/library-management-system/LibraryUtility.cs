using BridgeLabzTraining.oops_csharp_practice.gcr_codebase.encapsulation_polymorphism_interface_abstractclass.library_management_system;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.encapsulation_polymorphism_interface_abstractclass.library_management_system
{
    // Utility class contains all library operations
    internal class LibraryUtility
    {
        // Private data store
        private List<LibraryItem> Items = new List<LibraryItem>();

        //method to add book
        public void AddBook()
        {
            Items.Add(CreateItem("Book"));
            Console.WriteLine("Book added successfully.");
        }
        //method to add magazine
        public void AddMagazine()
        {
            Items.Add(CreateItem("Magazine"));
            Console.WriteLine("Magazine added successfully.");
        }
        //method to add dvd
        public void AddDVD()
        {
            Items.Add(CreateItem("DVD"));
            Console.WriteLine("DVD added successfully.");
        }

        //method to create item or item details and add them in the list 
        private LibraryItem CreateItem(string type)
        {
            Console.Write("Item ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Title: ");
            string title = Console.ReadLine();

            Console.Write("Author: ");
            string author = Console.ReadLine();

            //add according to the type of them
            if (type == "Book")
                return new Book(id, title, author);
            if (type == "Magazine")
                return new Magazine(id, title, author);

            return new DVD(id, title, author);
        }

        //method to display items from the list
        public void DisplayItems()
        {
            if (Items.Count == 0)
            {
                Console.WriteLine("No items available.");
                return;
            }

            foreach (LibraryItem item in Items)
            {
                item.GetItemDetails();
                Console.WriteLine("Loan Duration: " + item.GetLoanDuration() + " days");
            }
        }

        //methosd to reserve items 
        public void ReserveItem()
        {
            Console.Write("Enter Item ID: ");
            int id = int.Parse(Console.ReadLine());

            foreach (LibraryItem item in Items)
            {
                if (item.GetItemId() == id && item is IReservable reservable)
                {
                    //first check availability then reserve them
                    if (reservable.CheckAvailability())
                    {
                        Console.Write("Enter Borrower Name: ");
                        string name = Console.ReadLine();
                        reservable.ReserveItem(name);
                        Console.WriteLine("Item reserved successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Item already borrowed.");
                    }
                    return;
                }
            }

            Console.WriteLine("Item not found.");
        }
        
    }

}
