using BridgeLabzTraining.oops_csharp_practice.scenario_based.fitness_tracker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.fitness_tracker
{
    //cardio workouts like running and cycling
    internal class CardioWorkout : Workout
    {
        private double Speed;
        //constructor
        public CardioWorkout(string name, int duration, double speed, DateTime date)
            : base(name, duration, date)
        {
            Speed = speed;
        }

        // calculate calories for cardio workout
        public override double CalculateCaloriesBurned()
        {
            return GetDuration() * Speed * 5;
        }

        //method for summary of cardio workout
        public override string WorkoutSummary()
        {
            return GetWorkoutDate().ToShortDateString() +
                " | Cardio | " + GetWorkoutName() +
                " | " + GetDuration() + " min";
        }
    }
}
