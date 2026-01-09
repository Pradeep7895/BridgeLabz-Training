using BridgeLabzTraining.dsa_csharp_practice.scenario_based.atm_dispenser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.atm_dispenser
{
    internal class Program
    {
        static void Main()
        {
            ATM atm = new ATM();

            //All notes available
            int[] notesA = { 500, 200, 100, 50, 20, 10, 5, 2, 1 };
            Console.WriteLine("Scenario A: All notes available");
            atm.DispenseAmount(880, notesA);

            //500 removed
            int[] notesB = { 200, 100, 50, 20, 10, 5, 2, 1 };
            Console.WriteLine("\nScenario B: 500 removed");
            atm.DispenseAmount(880, notesB);

            //Exact change not possible
            int[] notesC = { 50, 20 };
            Console.WriteLine("\nScenario C: Exact change not possible");
            atm.DispenseAmount(30, notesC);
        }

    }
}

    