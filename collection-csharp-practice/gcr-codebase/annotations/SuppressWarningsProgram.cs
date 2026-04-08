using System;
using System.Collections;

namespace Collections.collection_csharp_practice.gcr_codebase.annotations
{
    internal class SuppressWarningsProgram
    {
        static void Main()
        {
#pragma warning disable CS0618
            ArrayList list = new ArrayList();
            list.Add(10);
            list.Add("Hello");
#pragma warning restore CS0618

            Console.WriteLine("Warnings suppressed");
        }
    }
}
