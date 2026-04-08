using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_inheritance.hierarchial_inheritance
{
    internal class BankAccount
    {
        public int AccountNumber;
        public double Balance;
    }
    // Savings Account
    class SavingsAccount : BankAccount
    {
        public double InterestRate;

        public void DisplayAccountType()
        {
            Console.WriteLine("Savings Account");
        }
    }
    // Checking Account
    class CheckingAccount : BankAccount
    {
        public double WithdrawalLimit;

        public void DisplayAccountType()
        {
            Console.WriteLine("Checking Account");
        }
    }
    // Fixed Deposit Account
    class FixedDepositAccount : BankAccount
    {
        public int Tenure;

        public void DisplayAccountType()
        {
            Console.WriteLine("Fixed Deposit Account");
        }
    }
    class Program
    {
        static void Main()
        {
            SavingsAccount sa = new SavingsAccount();
            sa.DisplayAccountType();

            CheckingAccount ca = new CheckingAccount();
            ca.DisplayAccountType();

            FixedDepositAccount fd = new FixedDepositAccount();
            fd.DisplayAccountType();
        }
    }
}
