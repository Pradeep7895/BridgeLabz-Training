using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_constructors.access_modifiers.book_library_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EBook ebook = new EBook("875-01320000084", "Clean Code", "Robert C. Martin", 7.5);
             

            ebook.DisplayDetails();

            Console.WriteLine("\nUpdating Author...");
            ebook.SetAuthor("Uncle Bob");

            Console.WriteLine();
            ebook.DisplayDetails();
        }
    }
}
