using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.review.library_management_system
{
    internal class Menu
    {
        public void Start()
        {
            // Store books in Array
            Book[] books = new Book[]
            {
            new Book("C# Basics", "Pradeep"),
            new Book("Data Structures", "Abhay"),
            new Book("Algorithms", "Prakhar"),
            new Book("Java", "Pushpak")
            };
            // Utility object using interface
            ICheckable library = new BookUtility(books);

            while (true)
            {
                Console.WriteLine("Libarary Management:");
                Console.WriteLine("1. Display Books");
                Console.WriteLine("2. Search book");
                Console.WriteLine("3. Book Checkout");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        library.DisplayBooks();
                        break;
                    case 2:
                        library.SearchByTitle("C#");
                        break;
                    case 3:
                        library.CheckoutBook("java");
                        break;
                    case 4:
                        return;

                }
            }
        }
    }
}

   