using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.movie_schedule_manager
{
    internal class InvalidTimeFormatException : Exception
    {
        public InvalidTimeFormatException(string message) : base(message)
        {
        }
    }
}
