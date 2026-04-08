using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.encapsulation_polymorphism_interface_abstractclass.e_commerce_platform
{
    internal class Groceries : Product
    {
        //constructor
        public Groceries(int id, string name, double price)
        : base(id, name, price) { }

        //abstract method override
        public override double CalculateDiscount()
        {
            return GetPrice() * 0.05; // 5% discount
        }
    }
}
