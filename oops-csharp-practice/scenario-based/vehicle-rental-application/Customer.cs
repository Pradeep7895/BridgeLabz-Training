using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.vehicle_rental_application
{
    internal class Customer
    {
        protected int customerId;
        protected string name;

        //constructor
        public Customer(int customerId, string name)
        {
            this.customerId = customerId;
            this.name = name;
        }

        //public method to get and set 
        //for customerId
        public int GetCustomerId()
        {
            return customerId;
        }
        public void SetCustomerId(int customerId)
        {
            this.customerId = customerId;
        }
        //for name
        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }

        //To string method to display details
        public override string ToString()
        {
            return $"Customer ID: {customerId}\n" +
                $"Customer Name: {name}\n";
        }
    }
}
