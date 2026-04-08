using BridgeLabzTraining.oops_csharp_practice.scenario_based.bank_management_system;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.bank_management_system
{
    internal class User
    {
        // User Details
        public string userName;
        public string address;
        public long accountNumber;
        public long mobileNumber;
        // PIN and Balance are private
        private int pin;
        private double balance;

        public void CreateUser()
        {
            // Input user details
            Console.Write("Enter User Name: ");
            userName = Console.ReadLine();

            Console.Write("Enter Address: ");
            address = Console.ReadLine();

            Console.Write("Enter Account Number: ");
            accountNumber = long.Parse(Console.ReadLine());

            Console.Write("Set PIN: ");
            pin = int.Parse(Console.ReadLine());

            Console.Write("Enter Mobile Number: ");
            mobileNumber = long.Parse(Console.ReadLine());

            Console.Write("Enter Opening Balance: ");
            balance = double.Parse(Console.ReadLine());
        }
        // Validate PIN
        public bool ValidateUserPin()
        {
            Console.Write("Enter User PIN: ");
            return int.Parse(Console.ReadLine()) == pin;
        }

        // Check if withdrawal is possible
        public bool CanWithdraw(double amount, Bank bank)
        {
            return amount >= bank.minTransaction &&
                   amount <= bank.maxTransaction &&
                   amount <= balance;
        }

        // User Operations
        // Deposit Amount
        public void DepositAmount(double amount, Bank bank)
        {
            // Check bank transaction limits
            if (amount < bank.minTransaction || amount > bank.maxTransaction)
            {
                Console.WriteLine("Amount beyond bank limits");
                return;
            }
            // Deposit amount
            balance += amount;
            Console.WriteLine("Amount Deposited Successfully");
        }

        // Withdraw Amount
        public void WithdrawAmount(double amount, Bank bank)
        {
            // Check if withdrawal is possible
            if (!CanWithdraw(amount, bank))
            {
                Console.WriteLine("Withdrawal not possible");
                return;
            }
            // Withdraw amount
            balance -= amount;
            Console.WriteLine("Amount Withdrawn Successfully");
        }
        // Receive Transfer
        public void ReceiveTransfer(double amount)
        {
            balance += amount;
        }
        // Check Balance
        public void CheckBalance()
        {
            Console.WriteLine("Current Balance: " + balance);
        }

        // Manager-only
        public void AdjustBalance(double amount)
        {
            balance = amount;
            Console.WriteLine("Balance adjusted by Manager");
        }
    }
}
