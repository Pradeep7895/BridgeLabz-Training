using BridgeLabzTraining.oops_csharp_practice.scenario_based.metal_factory_rod_cutting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.metal_factory_rod_cutting
{
    internal class Program
    {
        static void Main()
        {
            // Create and fill price chart
            PriceChart chart = new PriceChart();
            chart.AddPrice(1, 1);
            chart.AddPrice(2, 6);
            chart.AddPrice(3, 8);
            chart.AddPrice(4, 9);
            chart.AddPrice(5, 12);
            chart.AddPrice(6, 16);
            chart.AddPrice(7, 17);
            chart.AddPrice(8, 20);

            // Create rod cutter
            Cutter cutter = new Cutter(chart);
            int rodLength = 8;

            // Scenario A
            int bestRevenue = cutter.MaximumRevenue(rodLength);
            Revenue.ShowA(bestRevenue);

            // Scenario B (update price)
            chart.AddPrice(3, 10);
            int updatedRevenue = cutter.MaximumRevenue(rodLength);
            Revenue.ShowB(updatedRevenue);

            // Scenario C
            int nonOptimized = cutter.NonOptiRevenue(rodLength);
            Revenue.ShowC(updatedRevenue, nonOptimized);
        }

    }
}

