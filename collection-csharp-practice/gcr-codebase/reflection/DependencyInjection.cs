using System;
using System.Reflection;


namespace Collections.collection_csharp_practice.gcr_codebase.reflection
{

    [AttributeUsage(AttributeTargets.Field)]
    public class InjectAttribute : Attribute
    {
    }
    public class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine("[LOG] " + message);
        }
    }
    public class EmailService
    {
        public void Send(string email)
        {
            Console.WriteLine("Sending email to " + email);
        }
    }

    public class UserService
    {
        [Inject]
        private Logger logger;

        [Inject]
        private EmailService emailService;

        public void RegisterUser(string email)
        {
            logger.Log("Registering user");
            emailService.Send(email);
        }
    }
    public static class DIContainer
    {
        public static T Resolve<T>() where T : new()
        {
            T instance = new T();
            Type type = typeof(T);

            // Scan all fields (including private ones)
            FieldInfo[] fields = type.GetFields(
                BindingFlags.Instance |
                BindingFlags.NonPublic |
                BindingFlags.Public);

            foreach (FieldInfo field in fields)
            {
                // Check for [Inject]
                if (field.GetCustomAttribute<InjectAttribute>() != null)
                {
                    // Create dependency instance
                    object dependency = Activator.CreateInstance(field.FieldType);

                    // Inject dependency
                    field.SetValue(instance, dependency);
                }
            }

            return instance;
        }
    }
    class Program
    {
        static void Main()
        {
            UserService service = DIContainer.Resolve<UserService>();
            service.RegisterUser("pradeep@example.com");
        }
    }
}
