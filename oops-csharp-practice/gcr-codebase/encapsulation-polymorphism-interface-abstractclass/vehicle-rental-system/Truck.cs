using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.encapsulation_polymorphism_interface_abstractclass.vehicle_rental_system
{
    internal class Truck : Vehicle, IInsurable
    {
        public Truck(string number, double rate, string policyNumber)
       : base(number, "Truck", rate, policyNumber) { }

        // Calculates rental cost including 
        public override double CalculateRentalCost(int days)
        {
            return (GetRentalRate() * days) + 1000;
        }

        // Calculates insurance cost for truck
        public double CalculateInsurance(int days)
        {
            return days * 400;
        }

        public string GetInsuranceDetails()
        {
            return "Truck Insurance: ₹400 per day";
        }
    }
}
