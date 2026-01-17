using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.dynamic_book_shelf
{
    internal interface IBooks
    {
        void AddBook();
        void DeleteBook();
        void DisplayByGenre();
        void UpdateStatus();
    }
}
