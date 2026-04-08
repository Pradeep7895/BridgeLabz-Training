using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.custom_furniture
{
    // Stores result details

    internal class Result
    {
        // Private fields
        private int revenue;
        private int waste;

        // Public getter and setter for Revenue
        public int GetRevenue()
        {
            return revenue;
        }

        public void SetRevenue(int revenue)
        {
            this.revenue = revenue;
        }

        // Public getter and setter for Waste
        public int GetWaste()
        {
            return waste;
        }

        public void SetWaste(int waste)
        {
            this.waste = waste;
        }

    }
}

   
