using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.encapsulation_polymorphism_interface_abstractclass.e_commerce_platform
{
    internal class Clothing : Product, ITaxable
    {
        //constructor
        public Clothing(int id, string name, double price)
        : base(id, name, price) { }

        //abstract method override
        public override double CalculateDiscount()
        {
            return GetPrice() * 0.20; // 20% discount
        }
        //interface method to calculatetax override
        public double CalculateTax()
        {
            return GetPrice() * 0.05; // 5% tax
        }

        //interface method to tax details override
        public string GetTaxDetails()
        {
            return "Clothing Tax: 5%";
        }
    }
}
