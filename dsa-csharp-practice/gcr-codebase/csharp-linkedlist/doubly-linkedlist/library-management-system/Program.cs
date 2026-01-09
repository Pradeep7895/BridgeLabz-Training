using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.csharp_linkedlist.doubly_linkedlist.library_management_system
{
    internal class Program
    {
        static void Main()
        {
            // Create library object
            LibraryDoublyList library = new LibraryDoublyList();

            // Add books
            library.AddAtBeginning(1, "Java Basics", "James", "Programming", true);
            library.AddAtEnd(2, "C# Guide", "Microsoft", "Programming", true);
            library.AddAtEnd(3, "DBMS", "Navathe", "Database", false);

            // Display books
            Console.WriteLine("All Books:");
            library.DisplayForward();

            // Search book
            Console.WriteLine("\nSearch by Author:");
            library.SearchByAuthor("James");

            // Update availability
            Console.WriteLine("\nUpdate Availability:");
            library.UpdateAvailability(3, true);

            // Display reverse
            Console.WriteLine("\nBooks in Reverse:");
            library.DisplayReverse();

            // Count books
            library.CountBooks();
        }

    }
}

   