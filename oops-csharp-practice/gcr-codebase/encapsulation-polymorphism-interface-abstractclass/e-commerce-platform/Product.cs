using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.encapsulation_polymorphism_interface_abstractclass.e_commerce_platform
{
    internal abstract class Product
    {
        //instance variables
        private int ProductId;
        private string Name;
        private double Price;

        protected Product(int id, string name, double price)
        {
            SetProductId(id);
            SetName(name);
            SetPrice(price);
        }

        // Getter & Setter methods
        public int GetProductId()
        {
            return ProductId;
        }

        private void SetProductId(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Product ID must be positive.");
            ProductId = id;
        }

        public string GetName()
        {
            return Name;
        }
        private void SetName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be empty.");
            Name = name;
        }

        public double GetPrice()
        {
            return Price;
        }

        protected void SetPrice(double price)
        {
            if (price <= 0)
                throw new ArgumentException("Price must be greater than zero.");
            Price = price;
        }

        // Abstract method
        public abstract double CalculateDiscount();
    }
}
