using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.CustomerQueueMenagement
{
    internal class Items
    {
        protected string name;
        protected double price;
        protected int stack;

        public Items(string name, double price, int stack)
        {
            this.name = name;
            this.price = price;
            this.stack = stack; 
        }

        public string GetName() { return name; }
        public double GetPrice() { return price; }
        public int GetStock() { return stack; }

        public void ReduceStock(int qty)
        {
            stack -= qty;
        }
        public override string ToString()
        {
            return "Name: " + name+"\nPrice per piece: "+price;
        }
    }
}
