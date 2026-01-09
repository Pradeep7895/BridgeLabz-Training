using BridgeLabzTraining.oops_csharp_practice.scenario_based.fitness_tracker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.fitness_tracker
{
    //strength workouts like weight training
    internal class StrengthWorkout : Workout
    {
        private int Sets;
        private int Reps;

        // constructor
        public StrengthWorkout(string name, int duration, int sets, int reps, DateTime date)
            : base(name, duration, date)
        {
            Sets = sets;
            Reps = reps;
        }

        // calculate calories for strength workout
        public override double CalculateCaloriesBurned()
        {
            return Sets * Reps * 2.5;
        }

        // return summary of strength workout
        public override string WorkoutSummary()
        {
            return GetWorkoutDate().ToShortDateString() +
                   " | Strength | " + GetWorkoutName() +
                   " | Sets: " + Sets + " Reps: " + Reps;
        }

    }
}
    