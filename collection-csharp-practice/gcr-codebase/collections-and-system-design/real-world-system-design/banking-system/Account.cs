using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.collections_and_system_design.real_world_system_design.banking_system
{
    internal class Account
    {
        public int AccountNumber { get; set; }
        public double Balance { get; set; }

        public Account(int accNo, double balance)
        {
            AccountNumber = accNo;
            Balance = balance;
        }
    }
}
