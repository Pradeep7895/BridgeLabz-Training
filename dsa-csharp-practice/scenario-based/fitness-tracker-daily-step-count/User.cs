using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.fitness_tracker_daily_step_count
{
    internal class User
    {
        //instance variables
        private int UserId;
        private string UserName;
        private int Age;
        private int DailySteps;

        //constructor
        public User(int userId, string  userName, int age)
        {
            UserId=userId;
            UserName=userName;
            Age = age;
            DailySteps = 0;
        }

        //public methods to get and set attributes
        public int GetUserId() {  return UserId; }
        public void SetUserId(int userId) { UserId=userId; }

        public string GetUserName() { return UserName; }
        public void SetUserName(string userName) { UserName=userName; }

        public int GetAge() { return Age; }
        public void SetAge(int age) { Age=age; }

        public int GetDailySteps() { return DailySteps; }
        public void SetDailySteps(int steps) { DailySteps=steps; }

    }
}
