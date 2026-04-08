using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_constructors.access_modifiers.bank_account_management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount save = new SavingsAccount("SBI001", "Pradeep", 25000, 4.5);

            save.DisplayDetails();

            Console.WriteLine("\nUpdating Balance...");
            save.SetBalance(30000);

            Console.WriteLine("Updated Balance: " + save.GetBalance());
        }
    }
}
