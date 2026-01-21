using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.CustomerQueueMenagement
{
    internal class Customer
    {
        public int customerId;
        public Queue<Items> cart = new Queue<Items>();

        public Customer(int id)
        {
            customerId = id;
        }

        public void AddItemToCart(Items item)
        {
            cart.Enqueue(item);
        }
    }
}
