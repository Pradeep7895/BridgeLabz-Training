using BridgeLabzTraining.oops_csharp_practice.scenario_based.movie_schedule_manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.movie_schedule_manager
{
    // Handles console interaction logic
    internal class CinemaUtility
    {
   
        private ICinemaOperations cinema;

        public CinemaUtility(ICinemaOperations cinema)
        {
            this.cinema = cinema;
        }

        // Console logic for adding movie
        // Menu logic only
        public void AddMovieMenu()
        {
            try
            {
                Console.Write("Enter movie title: ");
                string title = Console.ReadLine();

                Console.Write("Enter show time (HH:MM): ");
                string time = Console.ReadLine();

                cinema.AddMovie(title, time); 
            }
            catch (InvalidTimeFormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        // Console logic for searching movie
        public void SearchMovieMenu()
        {
            Console.Write("Enter keyword to search: ");
            string keyword = Console.ReadLine();

            cinema.SearchMovie(keyword);
        }

    }
}


