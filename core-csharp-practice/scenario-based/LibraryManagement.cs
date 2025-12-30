using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

//3.Library Management System – Book Search and Checkout
//Scenario: You’re designing a system for a small library to manage books and track checkouts.
//Problem Requirements:
//● Store book details (title, author, status) in a Array.
//● Allow searching by partial title using String operations.
//● Store book data in an Array.
//● Use methods for searching, displaying, and updating book status (checked out or
//available).


namespace BridgeLabzTraining.core_csharp_practice.scenario_based
{
    internal class LibraryManagement
    {
        // method to add book details
        public void AddBook(string[,] books, int idx)
        {
            //take book details from user
            Console.Write("Enter book title: ");
            books[idx, 0] = Console.ReadLine();

            Console.Write("Enter book author: ");
            books[idx, 1] = Console.ReadLine();

            books[idx, 2] = "Available";

        }
        //for book display
        public void DisplayBooks(string[,] books)
        {
            //display book details
            Console.WriteLine("\nBook List:");
            bool anyBook = false;

            for(int i = 0; i < books.GetLength(0); i++)
            {
                if (books[i,0] != null)
                {
                    Console.WriteLine(i + 1 + ". " + books[i, 0] + " by " + books[i, 1] + " - " + books[i, 2]);
                    anyBook = true;
                }
            }
            if (!anyBook)
            {
                Console.WriteLine("No books available");
            }

        }
        
        //method to Search book 
        public void SearchBook(string[,] books)
        {
            //input for the word to be searched
            Console.Write("\nEnter partial title: ");
            string searchTerm = Console.ReadLine();

            //flag to check if book found
            //false: means book not found
            //true: means book found
            bool isFound = false;

            for(int i = 0; i < books.GetLength(0); i++)
            {
                //check for book exists or not 
                //IndexOf method to search partial title
                //StringComparison.OrdinalIgnoreCase for case insensitive search
                if (books[i,0] != null && books[i,0].IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) != -1)
                {
                    //display if books found
                    Console.WriteLine("Found: " + books[i, 0] + " by " + books[i, 1] + " - " + books[i, 2]);
                    isFound = true;
                }
            }
            //if books not found 
            if (!isFound)
            {
                Console.WriteLine("No books found.");
            }

        }

        // Find next empty slot in books array
        public int GetNextEmptyIndex(string[,] books)
        {
            for (int i = 0; i < books.GetLength(0); i++)
            {
                if (books[i, 0] == null)
                {
                    return i;
                }
            }
            return -1; // Library full
        }


        //method for update book
        public void UpdateBook(string[,] books)
        {
            Console.Write("Enter book number for updation: ");
            int index = int.Parse(Console.ReadLine()) - 1;

            //check for if book exista or not
            if ( books[index, 0] == null)
            {
                Console.WriteLine("Book not exist.");
                return;
            }

            // Using AddBook method
            AddBook(books, index);

            Console.WriteLine("Book updated successfully.");
        }

        // to delete book  
        public void DeleteBook(string[,] books)
        {
            Console.Write("Enter book number to delete: ");
            int index = int.Parse(Console.ReadLine()) - 1;

            //check for if book exista or not
            if (books[index, 0] == null)
            {
                Console.WriteLine("Book does not exist.");
                return;
            }
            //make book details null to delete
            books[index, 0] = null;
            books[index, 1] = null;
            books[index, 2] = null;
            Console.WriteLine("Book deleted successfully.");
        }

        //method for book checkout
        //make available book to checked out
        public void BookAvailableAndCheckOut(string[,] books)
        {
            Console.WriteLine("\nEnter book number to checkout: ");
            int idx = int.Parse(Console.ReadLine()) -1;

            //check for if book is available or not
            if (books[idx,2] == "Available")
            {
                //update status to checked out
                books[idx, 2] = "Checked Out";
                Console.WriteLine("You have successfully checked out " + books[idx, 0] + "book.");
            }
            else
            {
                Console.WriteLine("Book already checked out.");
            }
        }

        static void Main()
        {

            LibraryManagement library = new LibraryManagement();

            //Input number of books
            Console.WriteLine("Enter number of books available in library: ");
            int n = int.Parse(Console.ReadLine()!);

            string[,] books = new string[n, 3];


            int choiceRole;
            do
            {
                Console.WriteLine("\nSelect Role: ");
                Console.WriteLine("1. Admin");
                Console.WriteLine("2. User");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Enter choice: ");
                choiceRole = int.Parse(Console.ReadLine());

                if (choiceRole == 1)
                {
                    int admin;
                    do
                    {
                        Console.WriteLine("\nAdmin menu:");
                        Console.WriteLine("1. Display Books");
                        Console.WriteLine("2. Add Book");
                        Console.WriteLine("3. Update Books");
                        Console.WriteLine("4. Delete Books");
                        Console.WriteLine("5. Exit");
                        admin = int.Parse(Console.ReadLine());

                        switch (admin)
                        {
                            case 1:
                                library.DisplayBooks(books);
                                break;
                            case 2:
                                int idx = library.GetNextEmptyIndex(books);
                                if(idx == -1)
                                {
                                    Console.WriteLine("Library is full.");
                                }
                                else
                                {
                                    library.AddBook(books, idx);
                                    Console.WriteLine("Book added successfully.");
                                }
                                    break;
                            case 3:
                                library.UpdateBook(books);
                                break;
                            case 4:
                                library.DeleteBook(books);
                                break;
                        }
                    } while (admin != 5);
                }
                else if (choiceRole == 2)
                {
                    int user;
                    do
                    {
                        Console.WriteLine("\nUser Menu:");
                        Console.WriteLine("1. Display Books");
                        Console.WriteLine("2. Search Book");
                        Console.WriteLine("3. Checkout Book");
                        Console.WriteLine("4. Exit");
                        user = int.Parse(Console.ReadLine());

                        switch (user)
                        {
                            case 1:
                                library.DisplayBooks(books);
                                break;
                            case 2:
                                library.SearchBook(books);
                                break;
                            case 3:
                                library.BookAvailableAndCheckOut(books);
                                break;
                        }
                    } while (user != 4);
                }
            } while (choiceRole !=3);
        }
    }
}

