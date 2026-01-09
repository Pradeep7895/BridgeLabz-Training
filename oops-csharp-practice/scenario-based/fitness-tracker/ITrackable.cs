using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.fitness_tracker
{
    internal interface ITrackable
    {
        //calculate calories burned
        double CalculateCaloriesBurned();
        //return workout details
        string WorkoutSummary();

    }
}
