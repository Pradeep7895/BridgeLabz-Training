using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.csharp_linkedlist.doubly_linkedlist.movie_management_system
{
    internal class Program
    {
        static void Main()
        {
            MovieDoublyList movies = new MovieDoublyList();

            movies.AddAtBeginning("Inception", "Nolan", 2010, 8.8);
            movies.AddAtEnd("Interstellar", "Nolan", 2014, 8.6);
            movies.AddAtEnd("Avatar", "Cameron", 2009, 7.8);

            Console.WriteLine("\nAll Movies:");
            movies.DisplayForward();

            Console.WriteLine("\nAll Movies:");
            movies.DisplayReverse();

            Console.WriteLine("\nSearch by Director:");
            movies.SearchByDirector("Nolan");

            Console.WriteLine("\nUpdate Rating of Avatar:");
            movies.UpdateRating("Avatar", 8.0);

            Console.WriteLine("\nAfter Update:");
            movies.DisplayForward();

            Console.WriteLine("\nRemove Movie:");
            movies.RemoveByTitle("Interstellar");

            Console.WriteLine("\nFinal Movie List:");
            movies.DisplayForward();
        }

    }
}

    