using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.fitness_tracker
{
    internal class UserProfile
    {
        //private instance member
        private int UserId;
        private string UserName;
        private int Age;
        private double Weight;
        //goals--> cardio,strength,mixed
        private string FitnessGoal;

        public UserProfile(int userId, string userName, int age, double weight, string fitnessGoal)
        {
            UserId = userId;
            UserName = userName;
            Age = age;
            Weight = weight;
            FitnessGoal = fitnessGoal;
        }

        //public getter methods
        public int GetUserId() { return UserId; }
        public string GetUserName() { return UserName; }
        public int GetAge() { return Age; }
        public double GetWeight() { return Weight; }
        public string GetFitnessGoal() { return FitnessGoal; }

    }

}
