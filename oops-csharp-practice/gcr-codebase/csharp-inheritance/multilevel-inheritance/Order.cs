using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_inheritance.multilevel_inheritance
{
    //superclass
    internal class Order
    {
        public int OrderId;
        public string OrderDate;

        public virtual string GetOrderStatus()
        {
            return "Order Placed";
        }
    }
    // Intermediate subclass
    class ShippedOrder : Order
    {
        public string TrackingNumber;

        public override string GetOrderStatus()
        {
            return "Order Shipped";
        }
    }
    // Final subclass
    class DeliveredOrder : ShippedOrder
    {
        public string DeliveryDate;

        public override string GetOrderStatus()
        {
            return "Order Delivered";
        }
    }
    class Program
    {
        static void Main()
        {
            DeliveredOrder order = new DeliveredOrder();
            order.OrderId = 101;
            order.OrderDate = "01-01-2026";
            order.TrackingNumber = "TOK123";
            order.DeliveryDate = "03-01-2026";

            Console.WriteLine(order.GetOrderStatus());
        }
    }
}
