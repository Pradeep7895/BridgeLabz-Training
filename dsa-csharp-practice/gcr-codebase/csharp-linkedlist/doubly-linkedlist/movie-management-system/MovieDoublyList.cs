using BridgeLabzTraining.dsa_csharp_practice.csharp_linkedlist.doubly_linkedlist.movie_management_system;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.csharp_linkedlist.doubly_linkedlist.movie_management_system
{
    internal class MovieDoublyList
    {
        // Head points to first movie
        private MovieNode head;

        // Tail points to last movie
        private MovieNode tail;

        // 1️.  Add movie at beginning
        public void AddAtBeginning(string title, string director, int year, double rating)
        {
            MovieNode newNode = new MovieNode(title, director, year, rating);

            // If list is empty
            if (head == null)
            {
                head = tail = newNode;
                return;
            }

            // Link new node with current head
            newNode.Next = head;
            head.Prev = newNode;
            head = newNode;
        }

        // 2️. Add movie at end
        public void AddAtEnd(string title, string director, int year, double rating)
        {
            MovieNode newNode = new MovieNode(title, director, year, rating);

            // If list is empty
            if (head == null)
            {
                head = tail = newNode;
                return;
            }

            // Attach new node after tail
            tail.Next = newNode;
            newNode.Prev = tail;
            tail = newNode;
        }

        // 3️. Add movie at specific position 
        public void AddAtPosition(int position, string title, string director, int year, double rating)
        {
            if (position == 1)
            {
                AddAtBeginning(title, director, year, rating);
                return;
            }

            MovieNode newNode = new MovieNode(title, director, year, rating);
            MovieNode temp = head;

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

            // Insert node
            newNode.Next = temp.Next;
            newNode.Prev = temp;

            if (temp.Next != null)
                temp.Next.Prev = newNode;
            else
                tail = newNode;

            temp.Next = newNode;
        }

        // 4️. Remove movie by title
        public void RemoveByTitle(string title)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            MovieNode temp = head;

            // Search movie
            while (temp != null && temp.Title != title)
            {
                temp = temp.Next;
            }

            // Movie not found
            if (temp == null)
            {
                Console.WriteLine("Movie not found");
                return;
            }

            // If deleting head
            if (temp == head)
            {
                head = head.Next;
                if (head != null)
                    head.Prev = null;
                else
                    tail = null;
            }

            // If deleting tail
            else if (temp == tail)
            {
                tail = tail.Prev;
                tail.Next = null;
            }

            // Deleting middle node
            else
            {
                temp.Prev.Next = temp.Next;
                temp.Next.Prev = temp.Prev;
            }

            Console.WriteLine("Movie removed successfully");
        }

        // 5️. Search movie by Director
        public void SearchByDirector(string director)
        {
            MovieNode temp = head;
            bool found = false;


            // Traverse list
            while (temp != null)
            {
                if (temp.Director == director)
                {
                    PrintMovie(temp);
                    found = true;
                }
                temp = temp.Next;
            }

            if (!found)
                Console.WriteLine("No movies found for this director");
        }

        // 6️. Search movie by Rating
        public void SearchByRating(double rating)
        {
            MovieNode temp = head;
            bool found = false;


            // Traverse list
            while (temp != null)
            {
                if (temp.Rating == rating)
                {
                    PrintMovie(temp);
                    found = true;
                }
                temp = temp.Next;
            }

            if (!found)
                Console.WriteLine("No movies found with this rating");
        }

        // 7️. Update rating by movie title
        public void UpdateRating(string title, double newRating)
        {
            MovieNode temp = head;

            // Search movie
            while (temp != null)
            {
                if (temp.Title == title)
                {
                    temp.Rating = newRating;
                    Console.WriteLine("Rating updated successfully");
                    return;
                }
                temp = temp.Next;
            }

            Console.WriteLine("Movie not found");
        }

        // 8️. Display movies in forward order
        public void DisplayForward()
        {
            if (head == null)
            {
                Console.WriteLine("No movies available");
                return;
            }

            MovieNode temp = head;
            // Traverse forward
            while (temp != null)
            {
                PrintMovie(temp);
                temp = temp.Next;
            }
        }

        // 9️.  Display movies in reverse order
        public void DisplayReverse()
        {
            if (tail == null)
            {
                Console.WriteLine("No movies available");
                return;
            }

            MovieNode temp = tail;

            // Traverse backward
            while (temp != null)
            {
                PrintMovie(temp);
                temp = temp.Prev;
            }
        }

        // method to print one movie
        private void PrintMovie(MovieNode m)
        {
            Console.WriteLine(
                "Title: " + m.Title +
                ", Director: " + m.Director +
                ", Year: " + m.Year +
                ", Rating: " + m.Rating
            );
        }

    }
}

   