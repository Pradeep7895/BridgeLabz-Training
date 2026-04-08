using BridgeLabzTraining.oops_csharp_practice.scenario_based.movie_schedule_manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.movie_schedule_manager
{
    internal class Menu
    {
        private ICinemaOperations cinema;
        private CinemaUtility Utility;

        public Menu()
        {
            CinemaStore store = new CinemaStore();
            cinema = new Cinema(store);
            Utility = new CinemaUtility(cinema);
        }

        public void Start()
        {
            while (true)
            {
                Console.WriteLine("\n CinemaTime Menu : ");
                Console.WriteLine("1. Add Movie");
                Console.WriteLine("2. Search Movie");
                Console.WriteLine("3. Display All Movies");
                Console.WriteLine("4. Generate Report");
                Console.WriteLine("0. Exit");
                Console.Write("Choice: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                    continue;

                switch (choice)
                {
                    case 1:
                        Utility.AddMovieMenu();
                        break;

                    case 2:
                        Utility.SearchMovieMenu();
                        break;

                    case 3:
                        cinema.DisplayAllMovies();
                        break;

                    case 4:
                        cinema.GenerateReport();
                        break;

                    case 0:
                        Console.WriteLine("Exiting CinemaTime...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}

    

