using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_object_oriented_design.object_modeling.library_and_books
{
    internal class Library
    {
        //library name
        public string LibraryName { get; private set; }
        // Library HAS books
        private List<Book> books;

        // Constructor to initialize library name and book list
        public Library(string libraryName)
        {
            LibraryName = libraryName;
            books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            // Adding existing book
            books.Add(book);   
        }

        // Method to display all books in the library
        public void ShowBooks()
        {
            Console.WriteLine($"\nBooks in {LibraryName}:");
            foreach (Book book in books)
                book.DisplayBook();
        }
    }
}
