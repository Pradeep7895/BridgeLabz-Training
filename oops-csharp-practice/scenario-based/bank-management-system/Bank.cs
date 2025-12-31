using BridgeLabzTraining.oops_csharp_practice.scenario_based.bank_management_system;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.bank_management_system
{
    internal class Bank
    {
        // Bank Details
        public string bankName;
        public string ifscCode;
        public string[] branches;
        public double minTransaction;
        public double maxTransaction;

        public Bank()
        {
            // Initialize bank details
            bankName = "SBI";
            ifscCode = "IFSC00001";
            branches = new string[] { "Delhi", "Mumbai" };
            minTransaction = 100;
            maxTransaction = 100000;
        }
        //method to display details of bank
        public void DisplayBankDetails()
        {
            //display bank details
            Console.WriteLine("        BANK DETAILS             ");
            Console.WriteLine("Bank Name       : " + bankName);
            Console.WriteLine("IFSC Code       : " + ifscCode);
            Console.WriteLine("Branches        : ");

            for (int i = 0; i < branches.Length; i++)
            {
                Console.WriteLine("  - " + branches[i]);
            }

            Console.WriteLine("Min Transaction : " + minTransaction);
            Console.WriteLine("Max Transaction : " + maxTransaction);
            Console.WriteLine("================================\n");
        }

    }
}
