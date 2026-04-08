using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.encapsulation_polymorphism_interface_abstractclass.vehicle_rental_system
{
    internal class Bike : Vehicle, IInsurable
    {
        public Bike(string number, double rate, string policyNumber)
       : base(number, "Bike", rate, policyNumber) { }

        // Calculates rental cost for bike
        public override double CalculateRentalCost(int days)
        {
            return GetRentalRate() * days;
        }

        // Calculates insurance cost for bike
        public double CalculateInsurance(int days)
        {
            return days * 100; 
        }

        public string GetInsuranceDetails()
        {
            return "Bike Insurance: ₹100 per day";
        }
    }
}
