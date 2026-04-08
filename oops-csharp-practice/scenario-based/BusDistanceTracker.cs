using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based
{
    internal class BusDistanceTracker
    {
        static void Main()
        {
            // Variables to track distance
            int totalDistance = 0;

            // Distance between stops
            int stopDistance = 5; 
            string choice;

            Console.WriteLine("Bus Route Distance Tracker Started");

            while (true)
            {
                // Calculate distance to next stop
                totalDistance += stopDistance;
                Console.WriteLine($"Bus reached next stop. Total distance traveled: {totalDistance} km");

                // Ask passenger if they want to get off
                Console.Write("Do you want to get off at this stop? (yes/no): ");
                choice = Console.ReadLine().ToLower();

                // Check passenger choice
                if (choice == "yes")
                {
                    // Passenger gets off the bus
                    Console.WriteLine("Passenger got off the bus.");
                    break; 
                }
                // Passenger stays on the bus
                else if (choice != "no")
                {
                    Console.WriteLine("Invalid input. Please type yes or no.");
                }
            }

            Console.WriteLine($"Final distance traveled: {totalDistance} km");
        }

    }
}

   