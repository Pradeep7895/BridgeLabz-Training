using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.encapsulation_polymorphism_interface_abstractclass.library_management_system
{
    internal abstract class LibraryItem
    {
        //instance variables
        private int ItemId;
        private string Title;
        private string Author;

        private string BorrowerName;
        private bool IsBorrowed;

        protected LibraryItem(int id, string title, string author)
        {
            SetItemId(id);
            SetTitle(title);
            SetAuthor(author);
            IsBorrowed = false;
        }

        // Getter & Setter methods
        //for item id
        public int GetItemId()
        {
            return ItemId;
        }

        private void SetItemId(int id)
        {
            ItemId = id;
        }
        //for item title
        public string GetTitle()
        {
            return Title;
        }

        private void SetTitle(string title)
        {
            Title = title;
        }
        //for item author
        public string GetAuthor()
        {
            return Author;
        }

        private void SetAuthor(string author)
        {
            Author = author;
        }

        //methods to manage borrower details 
        protected void BorrowItem(string borrower)
        {
            BorrowerName = borrower;
            IsBorrowed = true;
        }

        protected void ReturnItem()
        {
            BorrowerName = null;
            IsBorrowed = false;
        }

        protected bool GetBorrowStatus()
        {
            return IsBorrowed;
        }

        // Concrete method
        public void GetItemDetails()
        {
            Console.WriteLine(
                $"ID: {ItemId}, Title: {Title}, Author: {Author}, Borrowed: {IsBorrowed}"
            );
        }

        // Abstract method
        public abstract int GetLoanDuration();

    }
}

   