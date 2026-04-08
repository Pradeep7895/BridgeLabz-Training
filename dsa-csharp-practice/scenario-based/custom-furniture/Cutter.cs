using BridgeLabzTraining.dsa_csharp_practice.scenario_based.custom_furniture;
using System;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.custom_furniture
{
    // Handles cutting logic
    internal class Cutter
    {
        // Reference to price chart
        private PriceChart priceChart;

        // Constructor
        public Cutter(PriceChart list)
        {
            priceChart = list;
        }

        //Find best revenue without waste limit
        public int GetBestRevenue(int rodLength)
        {
            // dp[i] stores best revenue for length i
            int[] dp = new int[rodLength + 1];

            for (int len = 1; len <= rodLength; len++)
            {
                // no cut
                int best = priceChart.GetPrice(len);

                // Try all possible cuts
                for (int cut = 1; cut < len; cut++)
                {
                    int money = priceChart.GetPrice(cut) + dp[len - cut];

                    if (money > best)
                        best = money;
                }

                // Store best revenue for this length
                dp[len] = best;
            }

            // Return best revenue for full rod
            return dp[rodLength];
        }

        //Best revenue with waste limit
        public Result GetBestWithWaste(int rodLength, int allowedWaste)
        {
            // Create result object
            Result bestResult = new Result();
            bestResult.SetRevenue(0);
            bestResult.SetWaste(rodLength);

            // Try rod usage within allowed waste
            for (int usedLength = rodLength; usedLength >= rodLength - allowedWaste; usedLength--)
            {
                int revenue = GetBestRevenue(usedLength);
                int waste = rodLength - usedLength;

                // Update result if better revenue or less waste
                if (revenue > bestResult.GetRevenue() ||
                   (revenue == bestResult.GetRevenue() && waste < bestResult.GetWaste()))
                {
                    bestResult.SetRevenue(revenue);
                    bestResult.SetWaste(waste);
                }
            }

            return bestResult;
        }
    }
}
