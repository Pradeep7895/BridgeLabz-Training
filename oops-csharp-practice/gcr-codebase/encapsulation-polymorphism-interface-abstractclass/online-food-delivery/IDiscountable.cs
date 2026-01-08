using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.encapsulation_polymorphism_interface_abstractclass.online_food_delivery
{
    internal interface IDiscountable
    {
        double ApplyDiscount();
        string GetDiscountDetails();
    }
}
