using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_constructors.level01
{
    internal class LibraryBook
    {
        //attributes
        private string title;
        private string author;
        private double price;
        private bool availability;

        //constructor
        public LibraryBook(string title,  string author, double price)
        {
            this.title = title;
            this.author = author;
            this.price = price;
            this.availability = true;
        }

        //method to borrow book
        public void BorrowBook()
        {
            if (availability)
            {
                availability = false;
                Console.WriteLine("Book borrowed successfully.");
            }
            else
            {
                Console.WriteLine("Book is not available.");
            }
        }

        //method to display book
        public void Display()
        {
            Console.WriteLine("\nBook Details: ");
            Console.WriteLine("Title       : " + title);
            Console.WriteLine("Author      : " + author);
            Console.WriteLine("Price       : " + price);
            Console.WriteLine("Available   : " + availability);
        }
        
        public static void Main(string[] args)
        {
            LibraryBook book = new LibraryBook("C# Basics", "John Smith", 450);
            book.Display();

            Console.WriteLine();
            book.BorrowBook();

            Console.WriteLine();
            book.Display();
        }
    }

}
