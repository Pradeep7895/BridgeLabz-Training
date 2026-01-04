using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_constructors.access_modifiers.book_library_system
{
    //Base class
    internal class Book
    {
        //Members
        public string ISBN;
        protected string title;
        private string author;

        //constructor
        public Book(string ISBN, string title, string author)
        {
            this.ISBN = ISBN;
            this.title = title;
            this.author = author;

        }

        //methgod to set author
        public void SetAuthor(string author)
        {
            this.author = author;
        }
        //method to get author
        public string GetAuthor()
        {
            return author;
        }
    }
}
