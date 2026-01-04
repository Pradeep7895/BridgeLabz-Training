using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_constructors.access_modifiers.bank_account_management
{
    internal class BankAccount
    {
        // Public member
        public string accountNumber;

        // Protected member
        protected string accountHolder;

        // Private member
        private double balance;

        // Constructor
        public BankAccount(string accountNumber, string accountHolder, double balance)
        {
            this.accountNumber = accountNumber;
            this.accountHolder = accountHolder;
            this.balance = balance;
        }

        // Public method to update balance
        public void SetBalance(double balance)
        {
            if(balance >=0)
                this.balance = balance;
        }
        // Public method to get balance
        public double GetBalance()
        {
            return balance;
        }

    }
}
