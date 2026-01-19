using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// (date - 13/01/26)

//3.Library Management System – Book Search and Checkout
//Scenario: You’re designing a system for a small library to manage books and track checkouts.
//Problem Requirements:
//● Store book details (title, author, status) in a Array.
//● Allow searching by partial title using String operations.
//● Store book data in an Array.
//● Use methods for searching, displaying, and updating book status (checked out or
//available).

namespace BridgeLabzTraining.review.library_management_system
{
    internal class Book 
    {
        //instance varibales
        private string Title;
        private string Author;
        private bool Available;

        //constructor
        public Book(string title, string author)
        {
            this.Title = title;
            this.Author = author;
            Available = true;
        }

        //public getter and setter methids
        public string GetTitle()
        {
            return Title;
        }
        public string GetAuthor()
        {
            return Author;
        }
        public bool GetIsAvailable()
        {
            return Available;
        }
        public void SetIsAvailable(bool available)
        {
            Available = available;
        }

        
    }
}
