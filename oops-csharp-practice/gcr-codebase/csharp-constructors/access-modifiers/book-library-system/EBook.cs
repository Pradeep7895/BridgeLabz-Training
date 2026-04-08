using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_constructors.access_modifiers.book_library_system
{
    //Derived class
    internal class EBook : Book
    {
        private double size;

        //constructor
        public EBook(string ISBN, string title, string author, double size) 
            : base(ISBN, title, author)
        {
            this.size = size;
        }
        //method display access modifiers
        public void DisplayDetails()
        {
            Console.WriteLine("ISBN : " + ISBN);   
            Console.WriteLine("Title  : " + title);
            Console.WriteLine("Author: " + GetAuthor());
            Console.WriteLine("File Size : " + size + " MB");
        }
    }
}
