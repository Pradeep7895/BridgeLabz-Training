using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_object_oriented_design.object_modeling.bank_and_account_holders
{
    internal class Account
    {
        // Associated bank
        private Bank bank;
        // Associated customer
        private Customer customer; 
        private double balance;
        
        //constructor
        public Account(Bank bank, Customer customer, double balance)
        {
            this.bank = bank;
            this.customer = customer;
            this.balance = balance;
        }

        public double GetBalance()
        {
            return balance;
        }
    }
}
