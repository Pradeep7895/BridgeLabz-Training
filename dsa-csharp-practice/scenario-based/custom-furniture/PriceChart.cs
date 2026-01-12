using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.custom_furniture
{
    internal class PriceChart
    {
        private Dictionary<int, int> prices = new Dictionary<int, int>();

        public void AddPrice(int length, int price)
        {
            prices[length] = price;
        }

        public int GetPrice(int length)
        {
            return prices.ContainsKey(length) ? prices[length] : 0;
        }

    }
}

    
