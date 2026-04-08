using BridgeLabzTraining.dsa_csharp_practice.scenario_based.custom_furniture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.custom_furniture
{
    internal class Furniture
    {
        // Display result for Scenario A
        public static void ShowA(int revenue)
        {
            Console.WriteLine("Best Cut for 12 ft rod");
            Console.WriteLine("Maximum Revenue: " + revenue);
        }

        // Display result for Scenario B
        public static void ShowB(Result result)
        {
            Console.WriteLine("\nFixed Waste Allowed");
            Console.WriteLine("Revenue: " + result.GetRevenue());
            Console.WriteLine("Waste  : " + result.GetWaste() + " ft");
        }

        // Display result for Scenario C
        public static void ShowC(Result result)
        {
            Console.WriteLine("\nMax Revenue with Minimum Waste");
            Console.WriteLine("Revenue: " + result.GetRevenue());
            Console.WriteLine("Waste  : " + result.GetWaste() + " ft");
        }

    }
}

   