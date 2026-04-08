using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.parcel_tracker
{
    internal class Order
    {
        private int OrderId;
        private string CustomerName;
        private string Address;
        private string PhoneNumber;

        //constructor
        public Order(int orderId, string customerName, string address, string phoneNumber)
        {
            OrderId = orderId;
            CustomerName = customerName;
            Address = address;
            PhoneNumber = phoneNumber;
        }

        //public methods to get fields
        public int GetOrderId() {  return OrderId; }
        public string GetCustomerName() { return CustomerName; }
        public string GetAddress() { return Address; }
        public string GetPhoneNumber() { return PhoneNumber; }

        public void DisplayDetails()
        {
            Console.WriteLine("Order Id : " + OrderId);
            Console.WriteLine("Customer Name : " + CustomerName);
            Console.WriteLine("Address : " + Address);
            Console.WriteLine("Phone number : " + PhoneNumber);
        }
    }
}
