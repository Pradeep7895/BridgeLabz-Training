using System;
using System.Reflection;

//Retrieve Attributes at Runtime

namespace Collections.collection_csharp_practice.gcr_codebase.reflection
{
    [AttributeUsage(AttributeTargets.Class)]
    public class AuthorAttribute : Attribute
    {
        public string Name { get; }

        public AuthorAttribute(string name)
        {
            Name = name;
        }
    }

    //apply attribute to a class
    [Author("Pradeep Chaudhary")]
    public class Book
    {
        public void Display()
        {
            Console.WriteLine("Book class");
        }
    }

    //using reflection retrieve attribute
    class Program
    {
        static void Main()
        {
            Type type = typeof(Book);

            AuthorAttribute attribute =
                type.GetCustomAttribute<AuthorAttribute>();

            if (attribute != null)
            {
                Console.WriteLine("Author Name: " + attribute.Name);
            }
        }
    }

}
