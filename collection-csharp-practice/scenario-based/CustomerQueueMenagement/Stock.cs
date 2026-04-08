using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.CustomerQueueMenagement
{
    internal class Stock
    {
        private Dictionary<string, Items> stockStorage = new Dictionary<string, Items>();

        public void AddItem(Items item)
        {
            stockStorage[item.GetName()] = item;
        }

        public Items GetItem(string name)
        {
            return stockStorage.ContainsKey(name) ? stockStorage[name] : null;
        }

    }
}
