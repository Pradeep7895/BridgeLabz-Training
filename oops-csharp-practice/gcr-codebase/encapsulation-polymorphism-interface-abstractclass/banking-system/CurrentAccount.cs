using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.encapsulation_polymorphism_interface_abstractclass.banking_system
{
    //derived class
    internal class CurrentAccount : BankAccount
    {
        //constructor
        public CurrentAccount(string accNo, string name, double balance)
            : base(accNo, name, balance) { }

        // No interest for current account
        public override void CalculateInterest()
        {
           
        }
    }
}
