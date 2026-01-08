using BridgeLabzTraining.oops_csharp_practice.gcr_codebase.encapsulation_polymorphism_interface_abstractclass.library_management_system;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.encapsulation_polymorphism_interface_abstractclass.library_management_system
{
    // Book item
    internal class Book : LibraryItem, IReservable
    {
        public Book(int id, string title, string author)
            : base(id, title, author) { }

        // Books can be borrowed for 14 days
        public override int GetLoanDuration()
        {
            return 14;
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
