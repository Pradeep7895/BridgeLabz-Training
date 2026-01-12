
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.metal_factory_rod_cutting
{
    internal class Cutter
    {
        private PriceChart chart;

        // Constructor
        public Cutter(PriceChart chart)
        {
            this.chart = chart;
        }

        // Calculate maximum revenue
        public int MaximumRevenue(int rodLength)
        {
            // dp[i] stores best revenue for rod length i
            int[] dp = new int[rodLength + 1];

            for (int i = 1; i <= rodLength; i++)
            {
                // Case: no cut
                int max = chart.GetPrice(i);

                // Try all possible cuts
                for (int cut = 1; cut < i; cut++)
                {
                    int revenue = chart.GetPrice(cut) + dp[i - cut];

                    if (revenue > max)
                        max = revenue;
                }

                // Store best revenue
                dp[i] = max;
            }

            return dp[rodLength];
        }

        // Revenue without cutting
        public int NonOptiRevenue(int rodLength)
        {
            return chart.GetPrice(rodLength);
        }
    }
}

   
