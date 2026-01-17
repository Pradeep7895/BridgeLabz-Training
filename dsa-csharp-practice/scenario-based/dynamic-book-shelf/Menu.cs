using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.dynamic_book_shelf
{
    sealed internal class Menu
    {
        IBooks books = new ShelfUtility();

        public void StartLibrary()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("WELCOME TO THE LIBRARY");
                Console.WriteLine("1.Add a Book");
                Console.WriteLine("2.Delete a Book");
                Console.WriteLine("3.Show all books by genre");
                Console.WriteLine("4.borrow a book");
                Console.WriteLine("5.return a book");
                Console.WriteLine("6.Exit");
                Console.Write("Enter Choice:");

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        books.AddBook();
                        break;
                    case 2:
                        books.DeleteBook();
                        break;
                    case 3:
                        books.DisplayByGenre();
                        break;
                    case 4:
                        books.UpdateStatus();
                        break;
                    case 5:
                        books.UpdateStatus();
                        break;
                    case 6:
                        flag = false;
                        break;
                    default:
                        flag = false;
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
        }
    }
}
