using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.encapsulation_polymorphism_interface_abstractclass.banking_system
{
    internal abstract class BankAccount
    {
        //Private instance variables 
        private string AccountNumber;
        private string HolderName;
        private double Balance;

        // Constructor
        protected BankAccount(string accNo, string name, double balance)
        {
            SetAccountNumber(accNo);
            SetHolderName(name);
            Balance = balance;
        }
        // Getter & Setter methods
        public string GetAccountNumber()
        {
            return AccountNumber;
        }

        private void SetAccountNumber(string accNo)
        {
            AccountNumber = accNo;
        }

        public string GetHolderName()
        {
            return HolderName;
        }

        private void SetHolderName(string name)
        {
            HolderName = name;
        }
        public double GetBalance()
        {
            return Balance;
        }

        // Deposit money
        public void Deposit(double amount)
        {
            if (amount > 0)
                Balance += amount;
        }
        // Withdraw money
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
                Balance -= amount;
        }

        //method to add interest from abstract method 
        //protected so we can use it in derived classes
        protected void AddInterest(double interest)
        {
            Balance += interest;
        }
        // Abstract method to calculate interest
        public abstract void CalculateInterest();

        // Display account details
        public void DisplayAccountDetails()
        {
            Console.WriteLine($"Account: {AccountNumber}, Holder: {HolderName}, Balance: {Balance}");
        }
    }
}
