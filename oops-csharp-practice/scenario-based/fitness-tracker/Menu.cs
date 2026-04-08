using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.fitness_tracker
{
    internal class Menu
    {
        private FitnessUtility Utility = new FitnessUtility();
        public void Start()
        {
            while(true)
            {
                Console.WriteLine("Fitness Track : ");
                Console.WriteLine("1. Create User");
                Console.WriteLine("2. Add Workout");
                Console.WriteLine("3. View Workout History");
                Console.WriteLine("4. Weekly Report");
                Console.WriteLine("0. Exit");
                Console.Write("Enter Choice: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                    continue;

                switch (choice)
                {
                    case 1:
                        Utility.Createuser();
                        break;
                    case 2:
                        Utility.AddWorkout();
                        break;
                    case 3:
                        Utility.ViewWorkoutHistory();
                        break;
                    case 4:
                        Utility.WeeklyReport();
                        break;
                    case 0:
                        return;
                }
            }
        }
    }
}
