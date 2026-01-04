using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_constructors.level01
{
    internal class Book
    {
        private string title;
        private string author;
        private double price;

        //default constructor
        public Book()
        {
            title = "No Title";
            author = "No Author";
            price = 0.0;
        }

        //Parameterized constructor
        public Book(string title, string author,double price)
        {
            this.title = title;
            this.author = author;
            this.price = price;

        }
        //using getter and setter methods
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public double Price
        {
            get { return price; }
            set
            {
                if (value >= 0)
                    price = value;
                else
                    price = 0;
            }
        }

        //method to display book details
        private void Display()
        {
            Console.WriteLine("\nBook Details: ");
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Price: " + price);   
        }

        public static void Main(string[] args)
        {
            //using default constructor
            Book book1 = new Book();
            book1.Display();

            //using parameterized constructor
            Book book2=new Book("C# Programming", "Jane Smith", 450.50);
            book2.Display();

            //using setter methods
            book1.Title = "Python Programming";
            book1.Author = "Alice Johnson";
            book1.Price = 350.75;
            book1.Display();
        }
    }
}
