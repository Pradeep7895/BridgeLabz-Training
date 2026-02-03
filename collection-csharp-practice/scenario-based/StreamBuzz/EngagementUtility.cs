using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.StreamBuzz
{
    internal class EngagementUtility:IEngagement
    {
        public void RegisterCreator(CreatorStats record)
        {
            if (record != null)
            {
                CreatorStats.EngagementBoard.Add(record);
            }
        }

        public Dictionary<string, int> GetTopPostCounts(List<CreatorStats> records, double likeThreshold)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();

            if (records == null || records.Count == 0)
                return result;

            foreach (CreatorStats creator in records)
            {
                if (creator == null || creator.WeeklyLikes == null || creator.CreatorName == null)
                    continue;

                int count = 0;
                for (int i = 0; i < creator.WeeklyLikes.Length; i++)
                {
                    if (creator.WeeklyLikes[i] >= likeThreshold)
                        count++;
                }

                if (count > 0)
                {
                    result[creator.CreatorName] = count;
                }
            }

            return result;
        }

        public double CalculateAverageLikes()
        {
            double total = 0;
            int likeCount = 0;

            foreach (CreatorStats creator in CreatorStats.EngagementBoard)
            {
                if (creator == null || creator.WeeklyLikes == null)
                    continue;

                for (int i = 0; i < creator.WeeklyLikes.Length; i++)
                {
                    total += creator.WeeklyLikes[i];
                    likeCount++;
                }
            }

            return (likeCount == 0) ? 0 : total / likeCount;
        }
    }
}