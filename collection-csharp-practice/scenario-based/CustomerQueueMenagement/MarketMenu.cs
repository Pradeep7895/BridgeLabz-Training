using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.CustomerQueueMenagement
{
    internal class MarketMenu
    {
        public void Start()
        {
            Stock stock = new Stock();
            MarketUtility utility = new MarketUtility(stock);

            Dictionary<int, Customer> customers = new Dictionary<int, Customer>();
            Queue<int> billingQueue = new Queue<int>();

            // preload stock
            stock.AddItem(new Items("Apple", 10, 10));
            stock.AddItem(new Items("Banana", 5, 20));
            stock.AddItem(new Items("Milk", 30, 5));

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Market Menu");
                Console.WriteLine("1. Add Customer");
                Console.WriteLine("2. Add Item to Customer Cart");
                Console.WriteLine("3. Process Next Customer");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Customer ID: ");
                        int id = Convert.ToInt32(Console.ReadLine());

                        if (customers.ContainsKey(id))
                        {
                            Console.WriteLine("Customer already exists.");
                            break;
                        }
                        Customer customer = new Customer(id);
                        customers[id] = customer;
                        billingQueue.Enqueue(id);
                        utility.AddCustomer(customer);

                        Console.WriteLine("Customer added to queue.");
                        break;

                    case 2:
                        Console.Write("Enter Customer ID: ");
                        int custId = Convert.ToInt32(Console.ReadLine());

                        if (!customers.ContainsKey(custId))
                        {
                            Console.WriteLine("Customer not found.");
                            break;
                        }

                        Console.Write("Enter Item Name: ");
                        string itemName = Console.ReadLine();

                        Items item = stock.GetItem(itemName);
                        if (item == null)
                        {
                            Console.WriteLine("Item not available in stock.");
                            break;
                        }

                        customers[custId].AddItemToCart(item);
                        Console.WriteLine("Item added to cart.");
                        break;

                    case 3:
                        if (billingQueue.Count == 0)
                        {
                            Console.WriteLine("No customers in billing queue.");
                            break;
                        }

                        utility.ProcessNextCustomer();
                        billingQueue.Dequeue();
                        break;

                    case 4:
                        exit = true;
                        Console.WriteLine("System exited.");
                        break;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }
    }
}

