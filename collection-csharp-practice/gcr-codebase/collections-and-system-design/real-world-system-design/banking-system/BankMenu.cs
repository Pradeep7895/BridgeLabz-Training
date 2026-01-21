using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.collections_and_system_design.real_world_system_design.banking_system
{
    internal class BankMenu
    {
        private BankUtility utility = new BankUtility();

        public void Start()
        {
            int choice;

            do
            {
                Console.WriteLine("\n==== Banking System Menu ====");
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Request Withdrawal");
                Console.WriteLine("4. Process Withdrawals");
                Console.WriteLine("5. Display Accounts Sorted by Balance");
                Console.WriteLine("6. Display All Accounts");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        utility.AddAccount();
                        break;

                    case 2:
                        utility.Deposit();
                        break;

                    case 3:
                        utility.RequestWithdrawal();
                        break;

                    case 4:
                        utility.ProcessWithdrawals();
                        break;

                    case 5:
                        utility.DisplaySortedByBalance();
                        break;

                    case 6:
                        utility.DisplayAllAccounts();
                        break;

                    case 0:
                        Console.WriteLine("Exiting Banking System...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

            } while (choice != 0);
        }

    }
}

   