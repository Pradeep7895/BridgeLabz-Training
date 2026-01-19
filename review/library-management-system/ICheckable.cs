using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.review.library_management_system
{
    internal interface ICheckable
    {
        void DisplayBooks();
        void SearchByTitle(string keyword);
        void CheckoutBook(string title);

    }
}

