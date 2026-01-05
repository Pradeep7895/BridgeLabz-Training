using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.vehicle_rental_application
{
    internal class Truck : Vehicle , IRentable
    {
        //constructor for child class truck
        public Truck(int id, string brand, double rentPerDay)
           : base(id, brand, rentPerDay)
        {
        }
        //method to calculate rentt
        public double CalculateRent(int days)
        {
            return rentPerDay * days;
        }

        //ToString method to display details
        public override string ToString()
        {
            return base.ToString() + "\nVehicle Type: Truck";
        }
    }
}
