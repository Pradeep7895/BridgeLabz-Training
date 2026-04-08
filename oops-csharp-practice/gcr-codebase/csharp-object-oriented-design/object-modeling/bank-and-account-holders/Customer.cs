using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_object_oriented_design.object_modeling.bank_and_account_holders
{
    internal class Customer
    {
        public string Name { get; private set; }

        public Customer(string name)
        {
            Name = name;
        }

        // Customer checks balance of an account
        public void ViewBalance(Account account)
        {
            Console.WriteLine($"{Name}'s Balance: {account.GetBalance()}");
        }
    }
}
