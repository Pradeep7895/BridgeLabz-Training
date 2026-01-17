using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.fitness_tracker_daily_step_count
{
    internal class FitnessTrackerUtility : ITracker
    {
        private User[] Users;
        private int MaxSize;
        private int CurrentIndex;

        //constructor
        public FitnessTrackerUtility(int maxSize)
        {

            Users = new User[maxSize];
            CurrentIndex = 0;
        }


        //method to add user
        public void AddUser()
        {
            if (CurrentIndex >= Users.Length )
            {
                Console.WriteLine("User limit exceed");
                return;
            }
            Console.WriteLine("Enter User Id: ");
            int userId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter User Name: ");
            string userName = Console.ReadLine();

            Console.WriteLine("Enter age : ");
            int age = int.Parse(Console.ReadLine());


            Users[CurrentIndex++] = new User(userId, userName, age);

            Console.WriteLine("User Added Successfully");
        }
        public void UpdateDailySteps()
        {
            Console.WriteLine("Enter id of the user: ");
            int id = int.Parse(Console.ReadLine());

            for (int i = 0; i < CurrentIndex; i++)
            {
                if (Users[i].GetUserId() == id)
                {
                    Console.WriteLine("Enter Updated New Steps: ");
                    int steps = int.Parse(Console.ReadLine());

                    //steps +=user.GetUser()

                    steps += Users[i].GetDailySteps();
                    Users[i].SetDailySteps(steps);

                    Console.WriteLine("Steps updated Successfully.");
                    return;
                }

            }
            Console.WriteLine("User not found");
        }
        //bubble sort code for sort the users on the basis of steps
        public void SortUsers()
        {
            for(int i = 0; i < CurrentIndex-1; i++)
            {
                for(int j=0;j<CurrentIndex - i - 1; j++)
                {
                    if (Users[j].GetDailySteps() < Users[j + 1].GetDailySteps())
                    {
                        User temp = Users[j];
                        Users[j] = Users[j + 1];
                        Users[j+1] = temp;
                    }
                }
            }
        }

        public void DisplayLeaderboard()
        {
            if(CurrentIndex == 0)
            {
                Console.WriteLine("No user available"); 
            }
            SortUsers();

            Console.WriteLine("Fitness Tracker LeaderBoard: ");
            for(int i=0;i<CurrentIndex;i++)
            {
                Console.WriteLine($"{i + 1}. {Users[i].GetUserName()} - {Users[i].GetDailySteps()} steps");
            }
        }

    }
}
