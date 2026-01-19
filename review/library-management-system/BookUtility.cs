using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.review.library_management_system
{
    internal class BookUtility: ICheckable
    {
        private Book[] books;

        // Constructor receives book array
        public BookUtility(Book[] books)
        {
            this.books = books;
        }

        // Display all books
        public void DisplayBooks()
        {
            Console.WriteLine("\nLibrary Books: ");
            foreach (Book book in books)
            {
                string status = book.GetIsAvailable() ? "Available" : "Checked Out";
                Console.WriteLine($"{book.GetTitle()} | {book.GetAuthor()} | {status}");
            }
        }

        // Search book by partial title
        public void SearchByTitle(string keyword)
        {
            Console.WriteLine("\nSearch Results : ");
            foreach (Book book in books)
            {
                
                if (book.GetTitle().ToLower().Contains(keyword.ToLower()))
                {
                    Console.WriteLine($"{book.GetTitle()} --- {book.GetAuthor()}");
                }
            }
        }

        // method to checkout a book
        public void CheckoutBook(string title)
        {
            foreach (Book book in books)
            {
                if (book.GetTitle().ToLower().Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    if (book.GetIsAvailable())
                    {
                        book.SetIsAvailable(false);
                        Console.WriteLine($"{book.GetTitle()} checked out.");
                    }
                    else
                    {
                        Console.WriteLine($"{book.GetTitle()} is not available.");
                    }
                    return;
                }
            }
            Console.WriteLine("Book not found.");
        }

    }
}

   