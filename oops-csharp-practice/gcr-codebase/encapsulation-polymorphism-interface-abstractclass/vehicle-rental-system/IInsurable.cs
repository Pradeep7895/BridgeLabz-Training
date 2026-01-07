using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.encapsulation_polymorphism_interface_abstractclass.vehicle_rental_system
{
    internal interface IInsurable
    {
        // Calculates insurance cost 
        double CalculateInsurance(int days);

        // Returns insurance details
        string GetInsuranceDetails();
    }
}
