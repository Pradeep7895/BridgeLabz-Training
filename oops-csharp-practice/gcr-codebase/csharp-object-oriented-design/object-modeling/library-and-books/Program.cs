using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_object_oriented_design.object_modeling.library_and_books
{
    internal class Program
    {
        static void Main()
        {
            // Books created independently
            Book book1 = new Book("Clean Code", "Robert C. Martin");
            Book book2 = new Book("The Java Programmer", "Andrew Hunt");

            // Libraries
            Library cityLibrary = new Library("GLA Library");
            Library collegeLibrary = new Library("College Library");

            // Same book added to multiple libraries
            cityLibrary.AddBook(book1);
            cityLibrary.AddBook(book2);
            collegeLibrary.AddBook(book1);

            cityLibrary.ShowBooks();
            collegeLibrary.ShowBooks();
        }
    }
}
