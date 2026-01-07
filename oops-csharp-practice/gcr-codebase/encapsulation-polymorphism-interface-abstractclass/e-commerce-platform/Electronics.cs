using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.encapsulation_polymorphism_interface_abstractclass.e_commerce_platform
{
    internal class Electronics : Product, ITaxable
    {
        //constructor
        public Electronics(int id, string name, double price)
            : base(id, name, price) { }

        //abstract method override
        public override double CalculateDiscount()
        {
            return GetPrice() * 0.10; // 10% discount
        }
        //interface method to calculatetax override
        public double CalculateTax()
        {
            return GetPrice() * 0.18; // 18% GST
        }
        //interface method to tax details override
        public string GetTaxDetails()
        {
            return "Electronics GST: 18%";
        }
    }
}
