using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_inheritance.hybrid_inheritance
{
    // Interface
    interface Worker
    {
        void PerformDuties();
    }
    //superclass
    internal class Person
    {
        public string Name;
        public int Id;
    }
    // Chef
    class Chef : Person, Worker
    {
        public void PerformDuties()
        {
            Console.WriteLine("Chef prepares food");
        }
    }

    // Waiter
    class Waiter : Person, Worker
    {
        public void PerformDuties()
        {
            Console.WriteLine("Waiter serves food");
        }
    }
    class Program
    {
        static void Main()
        {
            Worker chef = new Chef();
            chef.PerformDuties();

            Worker waiter = new Waiter();
            waiter.PerformDuties();
        }
    }
}
