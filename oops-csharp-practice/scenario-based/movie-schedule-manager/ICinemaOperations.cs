using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.movie_schedule_manager
{
    // Defines what operations cinema system supports
    internal interface ICinemaOperations
    {
        void AddMovie(string title, string time);
        void SearchMovie(string keyword);
        void DisplayAllMovies();
        void GenerateReport();
    }
}



