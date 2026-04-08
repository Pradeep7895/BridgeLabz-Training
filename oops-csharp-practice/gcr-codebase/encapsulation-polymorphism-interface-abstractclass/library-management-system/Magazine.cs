using BridgeLabzTraining.oops_csharp_practice.gcr_codebase.encapsulation_polymorphism_interface_abstractclass.library_management_system;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.encapsulation_polymorphism_interface_abstractclass.library_management_system
{
    // Magazine item
    internal class Magazine : LibraryItem
    {
        public Magazine(int id, string title, string author)
            : base(id, title, author) { }

        // Magazines can be borrowed for 7 days
        public override int GetLoanDuration()
        {
            return 7;
        }
    }

}
