using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.StreamBuzz
{
    internal class CreatorStats
    {
        public string CreatorName { get; set; }
        public double[] WeeklyLikes { get; set; }

        public static List<CreatorStats> EngagementBoard = new List<CreatorStats>();
    }
}