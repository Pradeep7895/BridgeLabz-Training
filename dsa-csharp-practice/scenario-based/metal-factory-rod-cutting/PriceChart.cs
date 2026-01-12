using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.metal_factory_rod_cutting
{
    // Stores prices of different rod lengths
    internal class PriceChart
    {
        private Dictionary<int, int> prices = new Dictionary<int, int>();

        // Add or update price
        public void AddPrice(int length, int price)
        {
            prices[length] = price;
        }

        // Get price for a rod length
        public int GetPrice(int length)
        {
            return prices.ContainsKey(length) ? prices[length] : 0;
        }

    }
}



   
