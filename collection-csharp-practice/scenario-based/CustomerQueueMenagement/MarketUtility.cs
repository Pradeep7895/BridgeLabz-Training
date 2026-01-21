using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.CustomerQueueMenagement
{
    internal class MarketUtility:IUtility
    {
        private Queue<Customer> customerQueue = new Queue<Customer>();
        private Stock stock;

        public MarketUtility(Stock stock)
        {
            this.stock = stock;
        }

        // Add customer to queue
        public void AddCustomer(Customer customer)
        {
            customerQueue.Enqueue(customer);
        }

        // Remove customer and process billing
        public void ProcessNextCustomer()
        {
            if (customerQueue.Count == 0)
            {
                Console.WriteLine("No customers in queue.");
                return;
            }
            Customer customer = customerQueue.Dequeue();
            double totalBill = 0;
            Console.WriteLine("Billing Customer ID: "+customer.customerId);
            while (customer.cart.Count > 0)
            {
                Items item = customer.cart.Dequeue();
                if (item.GetStock() > 0)
                {
                    item.ReduceStock(1);
                    totalBill += item.GetPrice();
                    Console.WriteLine("Purchased: "+item.GetName());
                }
                else
                {
                    Console.WriteLine(item.GetName()+" is out of stock");
                }
            }
            Console.WriteLine("Total Bill: "+totalBill);
        }
    }
}
