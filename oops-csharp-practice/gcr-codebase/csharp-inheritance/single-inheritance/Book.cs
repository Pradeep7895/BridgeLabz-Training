//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_inheritance.single_inheritance
//{
//    //superclass
//    internal class Book
//    {
//        public string Title;
//        public int PublicationYear;

//        public virtual void DisplayInfo()
//        {
//            Console.WriteLine("Book Title: " + Title);
//            Console.WriteLine("Publication Year: " + PublicationYear);
//        }
//    }
//    // Subclass
//    class Author : Book
//    {
//        public string Name;
//        public string Bio;

//        public override void DisplayInfo()
//        {
//            base.DisplayInfo();
//            Console.WriteLine("Author Name: " + Name);
//            Console.WriteLine("Author Bio: " + Bio);
//        }
//    }
//    class Program
//    {
//        static void Main()
//        {
//            Author author = new Author();
//            author.Title = "Theory of Evolution";
//            author.PublicationYear = 1998;
//            author.Name = "Charles Darwin";
//            author.Bio = "Genetics scientist ";

//            author.DisplayInfo();
//        }
//    }
//}
