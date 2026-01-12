using BridgeLabzTraining.dsa_csharp_practice.scenario_based.custom_furniture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.custom_furniture
{
    internal class Program
    {
        static void Main()
        {
            // Step 1: Create price chart
            PriceChart priceChart = new PriceChart();
            priceChart.AddPrice(2, 5);
            priceChart.AddPrice(3, 8);
            priceChart.AddPrice(4, 9);
            priceChart.AddPrice(6, 14);

            // Step 2: Create cutter and pass price chart
            Cutter cutter = new Cutter(priceChart);
            int rodLength = 12;

            // Scenario A: Best revenue without waste limit
            int bestRevenue = cutter.GetBestRevenue(rodLength);
            Furniture.ShowA(bestRevenue);

            // Scenario B: Maximum 2 ft waste allowed
            Result wasteLimited = cutter.GetBestWithWaste(rodLength, 2);
            Furniture.ShowB(wasteLimited);

            // Scenario C: Prefer minimum waste
            Result minimalWaste = cutter.GetBestWithWaste(rodLength, 1);
            Furniture.ShowC(minimalWaste);
        }

    }
}

   