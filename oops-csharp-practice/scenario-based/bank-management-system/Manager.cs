using BridgeLabzTraining.oops_csharp_practice.scenario_based.bank_management_system;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.bank_management_system
{
    internal class Manager
    {
        // ---------- MANAGER OPERATIONS ----------
        private User[] users = new User[20];
        private int count = 0;

        // Manager PIN
        private int managerPin = 9999;

        // Validate Manager PIN
        public bool ValidateManager()
        {
            Console.Write("Enter Manager PIN: ");
            return int.Parse(Console.ReadLine()) == managerPin;
        }
        // Create New User Account
        public void CreateAccount()
        {
            // Check account limit
            if (count >= users.Length)
            {
                Console.WriteLine("Account limit reached");
                return;
            }
            // Create and store new user
            User user = new User();
            user.CreateUser();
            users[count++] = user;

            Console.WriteLine("Account created successfully");
        }
        // Find User by Account Number
        public User FindUser(long accNo)
        {
            // Linear search for user
            for (int i = 0; i < count; i++)
                if (users[i].accountNumber == accNo)
                    return users[i];
            return null;
        }
        // View All User Accounts
        public void ViewAccounts()
        {
            Console.WriteLine("\n--- All Accounts ---");
            for (int i = 0; i < count; i++)
                Console.WriteLine(users[i].userName + " | " + users[i].accountNumber);
        }

        // ---------- USER OPERATIONS ----------
        // Authenticate User
        private User AuthenticateUser()
        {
            Console.Write("Enter Account Number: ");
            long acc = long.Parse(Console.ReadLine());

            // Find user and validate PIN
            User user = FindUser(acc);
            if (user == null || !user.ValidateUserPin())
            {
                Console.WriteLine("Invalid account or PIN");
                return null;
            }
            return user;
        }

        // User Deposit
        public void UserDeposit(Bank bank)
        {
            // Authenticate User
            User user = AuthenticateUser();
            if (user == null) return;

            Console.Write("Enter Amount: ");
            user.DepositAmount(double.Parse(Console.ReadLine()), bank);
        }
        // User Withdraw
        public void UserWithdraw(Bank bank)
        {
            // Authenticate User
            User user = AuthenticateUser();
            if (user == null) return;

            Console.Write("Enter Amount: ");
            user.WithdrawAmount(double.Parse(Console.ReadLine()), bank);
        }
        // User Check Balance
        public void UserCheckBalance()
        {
            // Authenticate User
            User user = AuthenticateUser();
            if (user != null) user.CheckBalance();
        }
        // Transfer Between Users
        public void TransferBetweenUsers(Bank bank)
        {
            Console.Write("Enter Sender Account No: ");
            // Find sender and validate PIN
            long fromAcc = long.Parse(Console.ReadLine());
            // Find sender and validate PIN
            User sender = FindUser(fromAcc);
            // Validate sender PIN
            if (sender == null || !sender.ValidateUserPin())
            {
                Console.WriteLine("Invalid sender");
                return;
            }
            // Find receiver
            Console.Write("Enter Receiver Account No: ");
            long toAcc = long.Parse(Console.ReadLine());
            User receiver = FindUser(toAcc);

            // Validate receiver
            if (receiver == null)
            {
                Console.WriteLine("Receiver not found");
                return;
            }
            // Enter transfer amount
            Console.Write("Enter Amount: ");
            double amount = double.Parse(Console.ReadLine());

            // Check if sender can withdraw
            if (!sender.CanWithdraw(amount, bank))
            {
                Console.WriteLine("Transfer failed");
                return;
            }
            // Perform transfer
            sender.WithdrawAmount(amount, bank);
            // Receive transfer
            receiver.ReceiveTransfer(amount);

            Console.WriteLine("Transfer Successful");
        }

        // ---------- MANAGER ONLY ----------
        // Adjust User Balance
        public void AdjustUserBalance()
        {
            Console.Write("Enter Account Number: ");
            // Find user
            User user = FindUser(long.Parse(Console.ReadLine()));
            if (user == null)
            {
                Console.WriteLine("Account not found");
                return;
            }

            // Adjust balance
            Console.Write("Enter New Balance: ");
            user.AdjustBalance(double.Parse(Console.ReadLine()));
        }
    }
}
