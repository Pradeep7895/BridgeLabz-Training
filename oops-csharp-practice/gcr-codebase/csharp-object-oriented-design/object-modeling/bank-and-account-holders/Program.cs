using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_object_oriented_design.object_modeling.bank_and_account_holders
{
    internal class Program
    {
        static void Main()
        {
            // Creating bank
            Bank bank = new Bank("State Bank");

            // Creating customers
            Customer customer1 = new Customer("Rahul");
            Customer customer2 = new Customer("Anita");

            // Opening accounts
            Account acc1 = bank.OpenAccount(customer1, 5000);
            Account acc2 = bank.OpenAccount(customer2, 8000);

            // Customers viewing balance
            customer1.ViewBalance(acc1);
            customer2.ViewBalance(acc2);
        }
    }
}
