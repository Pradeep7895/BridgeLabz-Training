using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.encapsulation_polymorphism_interface_abstractclass.banking_system
{
    internal class Menu
    {
        // list of accounts
        private List<BankAccount> Accounts = new List<BankAccount>();

        public void Start()
        {
            while (true)
            {
                Console.WriteLine("\nBanking System Menu : ");
                Console.WriteLine("1. Create Savings Account");
                Console.WriteLine("2. Create Current Account");
                Console.WriteLine("3. Deposit");
                Console.WriteLine("4. Withdraw");
                Console.WriteLine("5. Calculate Interest");
                Console.WriteLine("6. Display All Accounts");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CreateSavingsAccount();
                        break;
                    case 2:
                        CreateCurrentAccount();
                        break;
                    case 3:
                        DepositAmount();
                        break;
                    case 4:
                        WithdrawAmount();
                        break;
                    case 5:
                        CalculateInterestForAll();
                        break;
                    case 6:
                        DisplayAccounts();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }
        private void CreateSavingsAccount()
        {
            Console.Write("Account Number: ");
            string accNo = Console.ReadLine();

            Console.Write("Holder Name: ");
            string name = Console.ReadLine();

            Console.Write("Initial Balance: ");
            double balance = double.Parse(Console.ReadLine());

            BankAccount account = new SavingsAccount(accNo, name, balance);
            Accounts.Add(account);

            Console.WriteLine("Savings Account created successfully.");


        }
        private void CreateCurrentAccount()
        {
            Console.Write("Account Number: ");
            string accNo = Console.ReadLine();

            Console.Write("Holder Name: ");
            string name = Console.ReadLine();

            Console.Write("Initial Balance: ");
            double balance = double.Parse(Console.ReadLine());

            BankAccount account = new CurrentAccount(accNo, name, balance);
            Accounts.Add(account);

            Console.WriteLine("Current Account created successfully.");
        }
        private BankAccount FindAccount(string accNo)
        {
            foreach (BankAccount acc in Accounts)
            {
                if (acc.GetAccountNumber() == accNo)
                    return acc;
            }
            return null;
        }
        private void DepositAmount()
        {
            Console.Write("Enter Account Number: ");
            string accNo = Console.ReadLine();

            BankAccount account = FindAccount(accNo);

            if (account == null)
            {
                Console.WriteLine("Account not found.");
                return;
            }

            Console.Write("Enter amount to deposit: ");
            double amount = double.Parse(Console.ReadLine());

            account.Deposit(amount);
            Console.WriteLine("Amount deposited successfully.");
        }
        private void WithdrawAmount()
        {
            Console.Write("Enter Account Number: ");
            string accNo = Console.ReadLine();

            BankAccount account = FindAccount(accNo);

            if (account == null)
            {
                Console.WriteLine("Account not found.");
                return;
            }

            Console.Write("Enter amount to withdraw: ");
            double amount = double.Parse(Console.ReadLine());

            account.Withdraw(amount);
            Console.WriteLine("Withdrawal completed.");
        }
        private void CalculateInterestForAll()
        {
            foreach (BankAccount acc in Accounts)
            {
                acc.CalculateInterest(); // polymorphic call
            }
            Console.WriteLine("Interest calculated for all accounts.");
        }

        private void DisplayAccounts()
        {
            foreach (BankAccount acc in Accounts)
            {
                acc.DisplayAccountDetails();
            }
        }
    }
}
