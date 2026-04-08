using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.atm_dispenser
{
    internal class ATM
    {
        public void DispenseAmount(int amount, int[] notes)
        {
            Console.WriteLine("\nRequested Amount: " + amount);

            // Loop through each note (from biggest to smallest)
            for (int i = 0; i < notes.Length; i++)
            {
                int noteValue = notes[i];

                // Check if note can be used
                if (amount >= noteValue)
                {
                    // number of notes
                    int count = amount / noteValue;

                    // remaining amount
                    amount = amount % noteValue;      

                    Console.WriteLine(noteValue + " x " + count);
                }
            }

            // If some amount is still left, exact change is not possible
            if (amount != 0)
            {
                Console.WriteLine("Exact change not possible.");
            }
            else
            {
                Console.WriteLine("Amount dispensed successfully.");
            }
        }


    }
}

    