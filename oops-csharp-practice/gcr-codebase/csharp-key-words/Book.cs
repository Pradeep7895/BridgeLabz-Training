using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_key_words
{
    internal class Book
    {
        //static variable
        private static string LibraryName = "GLA Library";

        //instance variables
        private string title;
        private string author;

        //readonly variable
        private readonly string ISBN;

        public Book(string ISBN, string title, string author)
        {
            this.ISBN = ISBN;       
            this.title = title;     
            this.author = author;
        }
        // static method to display library name
        public static void DisplayLibraryName()
        {
            Console.WriteLine("Library Name: " + LibraryName);
        }
        // method for display book details sing is operator
        public void DisplayBookDetails(object obj)
        {
            if (obj is Book)
            {
                Book book = (Book)obj;
                Console.WriteLine("\nBook Title : " + book.title);
                Console.WriteLine("Author     : " + book.author);
                Console.WriteLine("ISBN       : " + book.ISBN);
            }
            else
            {
                Console.WriteLine("Object is not a Book");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book.DisplayLibraryName();

            Book b1 = new Book("875-013000000084", "Clean Code", "Robert C. Martin");

            b1.DisplayBookDetails(b1);
            b1.DisplayBookDetails("Not a Book");

            Console.ReadLine();
        }
    }
}
