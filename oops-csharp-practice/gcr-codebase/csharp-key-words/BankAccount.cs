using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_key_words
{
    internal class BankAccount
    {
        //static variable name
        private static string bankName = "SBI Bank";

        //readonly variable
        public readonly int AccountNumber;

        //instance variable
        private string AccountHolderName;

        //static variable
        private static int totalAccounts = 0;

        //constructor using this keyword
        public BankAccount(int AccountNumber, string AccountHolderName)
        {
            this.AccountNumber = AccountNumber;
            this.AccountHolderName= AccountHolderName;
            
            totalAccounts++;
        }
        //static method to get total count 
        public static void GetTotalAccounts()
        {
            Console.WriteLine("Total Accounts: " + totalAccounts);
        }
        //method to display account details using is opeartor
        public void DisplayDetails(object obj)
        {
            if (obj is BankAccount)
            {
                BankAccount acc = (BankAccount)obj;
                Console.WriteLine("\nBank Name: " + bankName);
                Console.WriteLine("Account Number: " + acc.AccountNumber);
                Console.WriteLine("Account Holder: " + acc.AccountHolderName);
            }
            else
            {
                Console.WriteLine("Object is not a BankAccount");
            }
        }
    }

    class Program
    {
        public static void Main()
        {
            BankAccount acc1 = new BankAccount(1, "Pradeep");
            BankAccount acc2 = new BankAccount(2, "Rahul");

            acc1.DisplayDetails(acc1);
            acc2.DisplayDetails(acc2);

            BankAccount.GetTotalAccounts();

            Console.WriteLine();
        }
    }
}
