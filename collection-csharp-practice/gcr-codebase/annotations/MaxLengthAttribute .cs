using System;
using System.Reflection;


namespace Collections.collection_csharp_practice.gcr_codebase.annotations
{
    [AttributeUsage(AttributeTargets.Field)]
    public class MaxLengthAttribute : Attribute
    {
        public int Length { get; }

        public MaxLengthAttribute(int length)
        {
            Length = length;
        }
    }

    public class User
    {
        [MaxLength(10)]
        public string Username;

        public User(string username)
        {
            // Get field info using reflection
            FieldInfo field = typeof(User).GetField("Username");
            MaxLengthAttribute attribute =
                field.GetCustomAttribute<MaxLengthAttribute>();

            // Validate length
            if (attribute != null && username.Length > attribute.Length)
            {
                throw new ArgumentException(
                    $"Username cannot exceed {attribute.Length} characters");
            }

            Username = username;
        }
    }

    class Program
    {
        static void Main()
        {
            try
            {
                User user1 = new User("Pradeep");
                Console.WriteLine("User created: " + user1.Username);

                User user2 = new User("VeryLongUsername"); //exceeds limit
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
