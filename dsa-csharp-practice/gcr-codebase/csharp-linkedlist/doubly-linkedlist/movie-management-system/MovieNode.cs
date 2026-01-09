using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.csharp_linkedlist.doubly_linkedlist.movie_management_system
{
    internal class MovieNode
    {
        // Movie details
        public string Title;
        public string Director;
        public int Year;
        public double Rating;

        // Links for doubly linked list
        public MovieNode Next;
        public MovieNode Prev;

        // Constructor to initialize movie data
        public MovieNode(string title, string director, int year, double rating)
        {
            Title = title;
            Director = director;
            Year = year;
            Rating = rating;
            Next = null;
            Prev = null;
        }
    }
}
