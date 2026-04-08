using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.stack_queues_hashmap_hashfunctions
{
    internal class CircularTour
    {
        public static int FindStartingPump(int[] petrol, int[] distance)
        {
            // Starting pump index
            int start = 0;
            // Current petrol surplus
            int surplus = 0;
            // Petrol shortage
            int deficit = 0;   

            for (int i = 0; i < petrol.Length; i++)
            {
                // Add petrol gained minus distance needed
                surplus += petrol[i] - distance[i];

                // If surplus becomes negative, cannot start from start
                if (surplus < 0)
                {
                    // Add this shortage to deficit
                    deficit += surplus;

                    // Try next pump as starting point
                    start = i + 1;

                    // Reset surplus
                    surplus = 0;
                }
            }

            // Check if total petrol is enough for the tour
            return (surplus + deficit >= 0) ? start : -1;
        }

        static void Main()
        {
            int[] petrol = { 4, 6, 7, 4 };
            int[] distance = { 6, 5, 3, 5 };

            int startIndex = FindStartingPump(petrol, distance);

            if (startIndex == -1)
                Console.WriteLine("No possible circular tour");
            else
                Console.WriteLine("Start at petrol pump index: " + startIndex);
        }

    }
}

   