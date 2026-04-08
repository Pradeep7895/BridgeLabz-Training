using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.collections_and_system_design.real_world_system_design.banking_system
{
    internal class BankUtility
    {
        // Dictionary → AccountNumber → Balance
        private Dictionary<int, double> accounts = new Dictionary<int, double>();

        // Queue → Withdrawal requests
        private Queue<int> withdrawalQueue = new Queue<int>();

        // Add new account
        public void AddAccount()
        {
            Console.Write("Enter Account Number: ");
            int accNo = int.Parse(Console.ReadLine());

            Console.Write("Enter Initial Balance: ");
            double balance = double.Parse(Console.ReadLine());

            if (!accounts.ContainsKey(accNo))
            {
                accounts[accNo] = balance;
                Console.WriteLine("Account created successfully.");
            }
            else
            {
                Console.WriteLine("Account already exists.");
            }
        }

        // Deposit money
        public void Deposit()
        {
            Console.Write("Enter Account Number: ");
            int accNo = int.Parse(Console.ReadLine());

            Console.Write("Enter Deposit Amount: ");
            double amount = double.Parse(Console.ReadLine());

            if (accounts.ContainsKey(accNo))
            {
                accounts[accNo] += amount;
                Console.WriteLine("Deposit successful.");
            }
            else
            {
                Console.WriteLine("Account not found.");
            }
        }

        // Add withdrawal request
        public void RequestWithdrawal()
        {
            Console.Write("Enter Account Number: ");
            int accNo = int.Parse(Console.ReadLine());

            if (accounts.ContainsKey(accNo))
            {
                withdrawalQueue.Enqueue(accNo);
                Console.WriteLine("Withdrawal request added to queue.");
            }
            else
            {
                Console.WriteLine("Account not found.");
            }
        }

        // Process withdrawal queue
        public void ProcessWithdrawals()
        {
            Console.WriteLine("\nProcessing Withdrawals:");

            while (withdrawalQueue.Count > 0)
            {
                int accNo = withdrawalQueue.Dequeue();
                Console.Write("Enter withdrawal amount for Account " + accNo + ": ");
                double amount = double.Parse(Console.ReadLine());

                if (accounts[accNo] >= amount)
                {
                    accounts[accNo] -= amount;
                    Console.WriteLine("Withdrawal successful.");
                }
                else
                {
                    Console.WriteLine("Insufficient balance.");
                }
            }
        }

        // Display accounts sorted by balance
        public void DisplaySortedByBalance()
        {
            Console.WriteLine("\nAccounts Sorted by Balance:");

            SortedDictionary<double, List<int>> sorted = new SortedDictionary<double, List<int>>();

            foreach (var acc in accounts)
            {
                if (!sorted.ContainsKey(acc.Value))
                    sorted[acc.Value] = new List<int>();

                sorted[acc.Value].Add(acc.Key);
            }

            foreach (var entry in sorted)
            {
                foreach (int accNo in entry.Value)
                    Console.WriteLine($"Account {accNo} : {entry.Key}");
            }
        }

        // Display all accounts
        public void DisplayAllAccounts()
        {
            Console.WriteLine("\nAll Accounts:");
            foreach (var acc in accounts)
                Console.WriteLine($"Account {acc.Key} : {acc.Value}");
        }

    }
}

   