using System;
using System.Reflection;

namespace Collections.collection_csharp_practice.gcr_codebase.reflection
{
    public interface IGreeting
    {
        void SayHello();
        void SayGoodbye();
    }

    public class Greeting : IGreeting
    {
        public void SayHello()
        {
            Console.WriteLine("Hello, World!");
        }

        public void SayGoodbye()
        {
            Console.WriteLine("Goodbye!");
        }
    }

    //c reate logging proxy
    public class LoggingProxy : DispatchProxy
    {
        private object _target;

        // Factory method to create proxy instance
        public static T Create<T>(T target)
        {
            object proxy = Create<T, LoggingProxy>();
            ((LoggingProxy)proxy)._target = target;
            return (T)proxy;
        }

        // Intercepts method calls
        protected override object Invoke(MethodInfo targetMethod, object[] args)
        {
            Console.WriteLine($"[LOG] Calling method: {targetMethod.Name}");

            // Invoke original method
            object result = targetMethod.Invoke(_target, args);

            return result;
        }
    }
    class Program
    {
        static void Main()
        {
            IGreeting greeting = new Greeting();

            // Wrap real object with logging proxy
            IGreeting proxyGreeting =
                LoggingProxy.Create<IGreeting>(greeting);

            proxyGreeting.SayHello();
            proxyGreeting.SayGoodbye();
        }
    }
}
