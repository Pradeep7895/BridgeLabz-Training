using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_constructors.access_modifiers.bank_account_management
{
    internal class SavingsAccount : BankAccount
    {
        private double interestRate;

        // Constructor
        public SavingsAccount(string accountNumber, string accountHolder, double balance, double interestRate)
            : base(accountNumber, accountHolder, balance)
        {
            this.interestRate = interestRate;
        }

        // Method access to public and protected
        public void DisplayDetails()
        {
            // public
            Console.WriteLine("Account Number : " + accountNumber);
            // protected
            Console.WriteLine("Account Holder : " + accountHolder);
            // private via public method
            Console.WriteLine("Balance  : " + GetBalance());    
            Console.WriteLine("Interest Rate  : " + interestRate + "%");
        }
    }
}
