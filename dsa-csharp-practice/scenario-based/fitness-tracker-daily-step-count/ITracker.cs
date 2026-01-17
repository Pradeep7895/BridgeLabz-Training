using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.fitness_tracker_daily_step_count
{
    internal interface ITracker
    {
        void AddUser();
        void UpdateDailySteps();
        void SortUsers();
        void DisplayLeaderboard();

    }
}
