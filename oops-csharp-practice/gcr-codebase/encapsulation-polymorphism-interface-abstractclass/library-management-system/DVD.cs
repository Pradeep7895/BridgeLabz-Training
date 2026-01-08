using BridgeLabzTraining.oops_csharp_practice.gcr_codebase.encapsulation_polymorphism_interface_abstractclass.library_management_system;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.encapsulation_polymorphism_interface_abstractclass.library_management_system
{
    // DVD item
    internal class DVD : LibraryItem, IReservable
    {
        public DVD(int id, string title, string author)
            : base(id, title, author) { }

        // DVDs can be borrowed for 3 days
        public override int GetLoanDuration()
        {
            return 2;
        }

        public void ReserveItem(string borrowerName)
        {
            if (!GetBorrowStatus())
                BorrowItem(borrowerName);
        }

        public bool CheckAvailability()
        {
            return !GetBorrowStatus();
        }
    }
}

