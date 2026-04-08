using BridgeLabzTraining.oops_csharp_practice.scenario_based.vehicle_rental_application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_object_oriented_design.object_modeling.bank_and_account_holders
{
    internal class Bank
    {
        public string BankName { get; private set; }
        // Stores all accounts in the bank
        private List<Account> accounts;
        
        //constructor
        public Bank(string bankName)
        {
            BankName = bankName;
            accounts = new List<Account>();
        }

        // Bank opens an account for a customer
        public Account OpenAccount(Customer customer, double initialBalance)
        {
            Account account = new Account(this, customer, initialBalance);
            accounts.Add(account);
            return account;
        }
    }
}
