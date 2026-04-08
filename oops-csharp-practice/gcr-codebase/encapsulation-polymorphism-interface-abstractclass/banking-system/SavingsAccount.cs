using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.encapsulation_polymorphism_interface_abstractclass.banking_system
{
    //derived class
    internal class SavingsAccount : BankAccount, ILoanable
    {
        //constructor
        public SavingsAccount(string accNo, string name, double balance)
            : base(accNo, name, balance) { }

        // Interest calculation for savings account
        public override void CalculateInterest()
        {
            AddInterest(GetBalance() * 0.04);
        }

        public void ApplyForLoan(double amount)
        {
            Console.WriteLine($"Loan applied for amount: {amount}");
        }

        public double CalculateLoanEligibility()
        {
            return GetBalance() * 5;
        }
    }
}
