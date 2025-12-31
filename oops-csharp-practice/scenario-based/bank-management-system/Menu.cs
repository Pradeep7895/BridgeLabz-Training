using BridgeLabzTraining.oops_csharp_practice.scenario_based.bank_management_system;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;


namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.bank_management_system
{
    internal class Menu
    {
        // Bank and Manager Instances
        private Bank bank = new Bank();
        private Manager manager = new Manager();

        // Start Menu
        public void Start()
        {
            //display bank details
            bank.DisplayBankDetails();
            
            Console.WriteLine("---- Welcome to " + bank.bankName + " ----");

            // Main Loop
            while (true)
            {
                Console.WriteLine("\n1. Manager");
                Console.WriteLine("2. User");
                Console.WriteLine("0. Exit");
                Console.Write("Choice: ");
                // Read role choice
                int role = int.Parse(Console.ReadLine());

                switch (role)
                {
                    case 1:
                        ManagerMenu();
                        break;

                    case 2:
                        UserMenu();
                        break;

                    case 0:
                        return;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }

        // ================= MANAGER MENU =================
        private void ManagerMenu()
        {
            // Validate Manager PIN
            if (!manager.ValidateManager())
            {
                Console.WriteLine("Invalid Manager PIN");
                return;
            }

            // Manager Operations Loop
            while (true)
            {
                Console.WriteLine("\n1. Create Account");
                Console.WriteLine("2. View Accounts");
                Console.WriteLine("3. Adjust Balance");
                Console.WriteLine("4. Logout");
                Console.Write("Choice: ");

                int ch = int.Parse(Console.ReadLine());

                // Handle manager choices
                switch (ch)
                {
                    case 1:
                        manager.CreateAccount();
                        break;

                    case 2:
                        manager.ViewAccounts();
                        break;

                    case 3:
                        manager.AdjustUserBalance();
                        break;

                    case 4:
                        return;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }

        // ================= USER MENU =================
        private void UserMenu()
        {
            while (true)
            {
                Console.WriteLine("\n1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Transfer");
                Console.WriteLine("5. Logout");
                Console.Write("Choice: ");

                int ch = int.Parse(Console.ReadLine());

                // Handle user choices
                switch (ch)
                {
                    case 1:
                        manager.UserDeposit(bank);
                        break;

                    case 2:
                        manager.UserWithdraw(bank);
                        break;

                    case 3:
                        manager.UserCheckBalance();
                        break;

                    case 4:
                        manager.TransferBetweenUsers(bank);
                        break;

                    case 5:
                        return;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}
