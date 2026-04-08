using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_class_objects.level01
{
    internal class Book
    {
        //fields
        private string title;
        private string author;
        private int price;

        // Constructor
        public Book(string title, string author, int price)
        {
            this.title = title;
            this.author = author;
            this.price = price; 
        }
        //method to display book details
        public void Display()
        {
            Console.WriteLine("\nBook Details: ");
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Price: " + price);     
        }

        public static void Main(string[] args)
        {
            Book book1 = new Book("Java Programming", "John Doe", 300);
            book1.Display();
        }
    }
}
