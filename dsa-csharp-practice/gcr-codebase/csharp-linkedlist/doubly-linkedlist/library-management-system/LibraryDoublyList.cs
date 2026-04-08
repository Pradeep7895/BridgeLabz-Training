using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.csharp_linkedlist.doubly_linkedlist.library_management_system
{
    internal class LibraryDoublyList
    {
        // Head points to first book
        private BookNode head;

        // Tail points to last book
        private BookNode tail;

        // 1️. Add book at beginning
        public void AddAtBeginning(int id, string title, string author, string genre, bool available)
        {
            BookNode newNode = new BookNode(id, title, author, genre, available);

            // If list is empty
            if (head == null)
            {
                head = tail = newNode;
                return;
            }

            // Insert before head
            newNode.Next = head;
            head.Prev = newNode;
            head = newNode;
        }

        // 2️. Add book at end
        public void AddAtEnd(int id, string title, string author, string genre, bool available)
        {
            BookNode newNode = new BookNode(id, title, author, genre, available);

            // If list is empty
            if (head == null)
            {
                head = tail = newNode;
                return;
            }

            // Insert after tail
            tail.Next = newNode;
            newNode.Prev = tail;
            tail = newNode;
        }

        // 3️. Add book at specific position
        public void AddAtPosition(int position, int id, string title, string author, string genre, bool available)
        {
            // If position is first
            if (position == 1)
            {
                AddAtBeginning(id, title, author, genre, available);
                return;
            }

            BookNode newNode = new BookNode(id, title, author, genre, available);
            BookNode temp = head;

            // Move to previous position
            for (int i = 1; i < position - 1 && temp != null; i++)
            {
                temp = temp.Next;
            }

            // Invalid position
            if (temp == null)
            {
                Console.WriteLine("Invalid position");
                return;
            }

            // Insert book
            newNode.Next = temp.Next;
            newNode.Prev = temp;

            if (temp.Next != null)
                temp.Next.Prev = newNode;
            else
                tail = newNode;

            temp.Next = newNode;
        }

        // 4️. Remove book by Book ID
        public void RemoveByBookId(int id)
        {
            // If list is empty
            if (head == null)
            {
                Console.WriteLine("Library is empty");
                return;
            }

            BookNode temp = head;

            // Search book
            while (temp != null && temp.BookId != id)
            {
                temp = temp.Next;
            }

            // If book not found
            if (temp == null)
            {
                Console.WriteLine("Book not found");
                return;
            }

            // If first book
            if (temp == head)
            {
                head = head.Next;
                if (head != null)
                    head.Prev = null;
                else
                    tail = null;
            }
            // If last book
            else if (temp == tail)
            {
                tail = tail.Prev;
                tail.Next = null;
            }
            // If middle book
            else
            {
                temp.Prev.Next = temp.Next;
                temp.Next.Prev = temp.Prev;
            }

            Console.WriteLine("Book removed");
        }

        // 5️. Search book by title
        public void SearchByTitle(string title)
        {
            BookNode temp = head;
            bool found = false;

            // Traverse list
            while (temp != null)
            {
                if (temp.Title == title)
                {
                    PrintBook(temp);
                    found = true;
                }
                temp = temp.Next;
            }


            // If not found
            if (!found)
                Console.WriteLine("Book not found");
        }

        // 6️. Search book by author
        public void SearchByAuthor(string author)
        {
            BookNode temp = head;
            bool found = false;

            while (temp != null)
            {
                if (temp.Author == author)
                {
                    PrintBook(temp);
                    found = true;
                }
                temp = temp.Next;
            }


            // If not found
            if (!found)
                Console.WriteLine("Book not found");
        }

        // 7️. Update availability status
        public void UpdateAvailability(int id, bool status)
        {
            BookNode temp = head;

            while (temp != null)
            {
                if (temp.BookId == id)
                {
                    temp.IsAvailable = status;
                    Console.WriteLine("Availability updated");
                    return;
                }
                temp = temp.Next;
            }

            Console.WriteLine("Book not found");
        }

        // 8️. Display books forward
        public void DisplayForward()
        {
            BookNode temp = head;

            // Traverse forward
            while (temp != null)
            {
                PrintBook(temp);
                temp = temp.Next;
            }
        }

        // 9️. Display books in reverse
        public void DisplayReverse()
        {
            BookNode temp = tail;


            // Traverse backward
            while (temp != null)
            {
                PrintBook(temp);
                temp = temp.Prev;
            }
        }

        //10. Count total books
        public void CountBooks()
        {
            int count = 0;
            BookNode temp = head;


            // Count each node
            while (temp != null)
            {
                count++;
                temp = temp.Next;
            }

            Console.WriteLine("Total Books: " + count);
        }

        // Print one book
        private void PrintBook(BookNode b)
        {
            Console.WriteLine(
                "ID: " + b.BookId +
                ", Title: " + b.Title +
                ", Author: " + b.Author +
                ", Genre: " + b.Genre +
                ", Available: " + b.IsAvailable
            );
        }

    }
}

    