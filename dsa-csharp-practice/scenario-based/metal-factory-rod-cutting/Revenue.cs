using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.metal_factory_rod_cutting
{
    // Handles all printing and user interaction
    internal class Revenue
    {
        public static void ShowA(int revenue)
        {
            Console.WriteLine("Best Cut Strategy");
            Console.WriteLine("Maximum Revenue: " + revenue);
        }

        public static void ShowB(int revenue)
        {
            Console.WriteLine("\nCustom Length Price Added");
            Console.WriteLine("Updated Revenue: " + revenue);
        }

        public static void ShowC(int opti, int nonOpti)
        {
            Console.WriteLine("\nRevenue Comparison");
            Console.WriteLine("Optimized Revenue     : " + opti);
            Console.WriteLine("Non-Optimized Revenue : " + nonOpti);
            Console.WriteLine("Extra Profit          : " + (opti - nonOpti));
        }

    }
}


   