using BridgeLabzTraining.oops_csharp_practice.scenario_based.fitness_tracker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.fitness_tracker
{
    // CardioWorkout and StrengthWorkout will inherit from here
    internal abstract class Workout : ITrackable
    {
        // private variables for workout data
        private string WorkoutName;
        private int Duration;          
        private DateTime WorkoutDate;

        // constructor to initialize workout details
        protected Workout(string name, int duration, DateTime date)
        {
            WorkoutName = name;
            Duration = duration;
            WorkoutDate = date;
        }

        // getter methods
        public string GetWorkoutName() { return WorkoutName; }
        public int GetDuration() { return Duration; }
        public DateTime GetWorkoutDate() { return WorkoutDate; }


        //methods to be implemented by derived classes
        public abstract double CalculateCaloriesBurned();
        public abstract string WorkoutSummary();
    }

}
