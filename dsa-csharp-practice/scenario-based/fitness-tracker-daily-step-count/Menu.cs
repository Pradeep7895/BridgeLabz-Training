using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.fitness_tracker_daily_step_count
{
    internal class Menu
    {
        private ITracker Utility;
        
        public void Start()
        {
            Utility = new FitnessTrackerUtility(20);

            int choice;
            do
            {
                Console.WriteLine("Fitness Tracker LeaderBoard: ");
                Console.WriteLine("1. Add User");
                Console.WriteLine("2. Update steps");
                Console.WriteLine("3. Display Leader Board");
                Console.WriteLine("0. Exit");
                Console.Write("Enter Choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Utility.AddUser();
                        break;
                    case 2:
                        Utility.UpdateDailySteps();
                        break;
                    case 3:
                        Utility.DisplayLeaderboard();
                        break;
                    case 0:
                        Console.WriteLine("Exit...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            } while (choice != 0);
        }
    }
}
