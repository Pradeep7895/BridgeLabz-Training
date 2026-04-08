using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_object_oriented_design.object_modeling.library_and_books
{
    internal class Book
    {
        //book title
        public string Title { get; private set; }
        //book author
        public string Author { get; private set; }

        //constructor
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
        //method to display info.
        public void DisplayBook()
        {
            Console.WriteLine($"Book: {Title}, Author: {Author}");
        }
    }
}
