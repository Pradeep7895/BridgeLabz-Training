using BridgeLabzTraining.oops_csharp_practice.scenario_based.movie_schedule_manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.movie_schedule_manager
{
    // Handles cinema business logic
    internal class Cinema : ICinemaOperations
    {
        private CinemaStore store;

        public Cinema(CinemaStore store)
        {
            this.store = store;
        }

        // Add movie
        public void AddMovie(string title, string time)
        {
            //validate time
            if (!IsValidTime(time))
                throw new InvalidTimeFormatException("Invalid time format: " + time);

            //check storage
            if (store.MovieCount == store.MovieTitles.Length)
                throw new Exception("Movie storage is full.");

            //stote data
            store.MovieTitles[store.MovieCount] = title;
            store.MovieTimes[store.MovieCount] = time;
            store.MovieCount++;

            Console.WriteLine("Movie added successfully.");
        }

        // Search movie by keyword
        public void SearchMovie(string keyword)
        {
            bool found = false;

            for (int i = 0; i < store.MovieCount; i++)
            {
                if (store.MovieTitles[i]
                    .ToLower()
                    .Contains(keyword.ToLower()))
                {
                    Console.WriteLine(
                        "Movie: " + store.MovieTitles[i] +
                        " | Time: " + store.MovieTimes[i]
                    );
                    found = true;
                }
            }

            if (!found)
                Console.WriteLine("No movie found.");
        }

        // Display all movies
        public void DisplayAllMovies()
        {
            if (store.MovieCount == 0)
            {
                Console.WriteLine("No movies available.");
                return;
            }

            for (int i = 0; i < store.MovieCount; i++)
            {
                Console.WriteLine(
                    $"Movie: {store.MovieTitles[i]} | Time: {store.MovieTimes[i]}"
                );
            }
        }

        // Generate printable report
        public void GenerateReport()
        {
            for (int i = 0; i < store.MovieCount; i++)
            {
                Console.WriteLine(
                    store.MovieTitles[i] + " at " + store.MovieTimes[i]
                );
            }
        }

        // Time validation (HH:MM)
        private bool IsValidTime(string time)
        {
            if (!Regex.IsMatch(time, @"^\d{2}:\d{2}$"))
                return false;

            string[] parts = time.Split(':');
            int hour = int.Parse(parts[0]);
            int minute = int.Parse(parts[1]);

            return hour >= 0 && hour <= 23 &&
                   minute >= 0 && minute <= 59;
        }

    }
}



   