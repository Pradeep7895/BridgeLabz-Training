using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.StreamBuzz
{
    internal interface IEngagement
    {
        void RegisterCreator(CreatorStats record);
        Dictionary<string, int> GetTopPostCounts(List<CreatorStats> records, double likeThreshold);
        double CalculateAverageLikes();
    }
}