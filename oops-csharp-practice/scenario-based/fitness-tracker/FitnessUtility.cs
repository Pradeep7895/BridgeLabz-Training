using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.fitness_tracker
{
    internal class FitnessUtility
    {
        //store user profile
        private UserProfile User;
        //store all workouts
        private List<Workout> Workouts = new();
        
        //method to create user
        public void Createuser()
        {
            Console.Write("User ID: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Invalid ID");
                return;
            }

            Console.Write("Name : ");
            String name = Console.ReadLine();

            Console.Write("Age: ");
            if(!int.TryParse(Console.ReadLine(),out int age))
            {
                Console.WriteLine("Invalid Age");
                return;
            }
            Console.Write("Weight: ");
            if (!double.TryParse(Console.ReadLine(), out double weight))
            {
                Console.WriteLine("Invalid Weight");
                return;
            }

            Console.Write("Fitness Goal (Cardio / Strength ): ");
            string goal = Console.ReadLine();

            User = new UserProfile(id, name, age, weight, goal);
            Console.WriteLine("User profile created successfully");
        }

        //method to add workout 
        public void AddWorkout()
        {
            //check for if user is null or not
            if(User == null)
            {
                Console.WriteLine("Create user first");
                return;
            }
            //get goal from user
            string goal = User.GetFitnessGoal().ToLower();

            //if goal is given by user
            if(goal == "cardio")
            {
                CardioWorkoutAdd();
            }
            else if(goal == "strength")
            {
                StrengthWorkoutAdd();
            }
            //if user did not give goal
            else
            {
                Console.WriteLine("1. Cardio ");
                Console.WriteLine("2. Strength");
                Console.WriteLine("Choose type: ");
                int.TryParse(Console.ReadLine(), out int choice);

                if(choice == 1)
                {
                    CardioWorkoutAdd();
                }
                else
                {
                    StrengthWorkoutAdd();
                }
            }
        }

        //method to add cardio workout to list
        private void CardioWorkoutAdd()
        {
            Console.Write("Workout Name: ");
            string name = Console.ReadLine();

            Console.Write("Duration (minutes): ");
            if (!int.TryParse(Console.ReadLine(), out int duration))
                return;

            Console.Write("Speed (km/h): ");
            if (!double.TryParse(Console.ReadLine(), out double speed))
                return;

            // add cardio workout to list
            Workouts.Add(new CardioWorkout(name, duration, speed, DateTime.Now));
            Console.WriteLine("Cardio Workout added successfully.");
        }

        //method to add strength workout to list
        private void StrengthWorkoutAdd()
        {
            Console.Write("Workout Name: ");
            string name = Console.ReadLine();

            Console.Write("Duration (minutes): ");
            if (!int.TryParse(Console.ReadLine(), out int duration))
                return;

            Console.Write("Sets: ");
            if (!int.TryParse(Console.ReadLine(), out int sets))
                return;

            Console.Write("Reps: ");
            if (!int.TryParse(Console.ReadLine(), out int reps))
                return;

            // add strength workout to list
            Workouts.Add(new StrengthWorkout(name, duration, sets, reps, DateTime.Now));
            Console.WriteLine("Strength Workout added successfully ");

        }
        //method to show all workout historyy
        public void ViewWorkoutHistory()
        {
            Console.WriteLine("Workout History : ");
            foreach(Workout w in Workouts)
            {
                Console.WriteLine(w.WorkoutSummary());
            }
        }
        //method to show weekly report
        public void WeeklyReport()
        {
            //to take date for last one week
            DateTime lastWeek = DateTime.Now.AddDays(-7);
            double calories = 0;
            int minutes = 0;

            foreach (Workout w in Workouts)
            {
                if(w.GetWorkoutDate() >= lastWeek)
                {
                    calories += w.CalculateCaloriesBurned();
                    minutes += w.GetDuration();
                }
            }
            Console.WriteLine("Total minutes: " + minutes);
            Console.WriteLine("Total Calories Burned: " + calories);
        }
    }
}
