using System;

//namespace 1: Access Library
namespace AccessLibrary
{
    public class BaseClass
    {
        public int publicVar = 10;
        private int privateVar = 20;
        protected int protectedVar = 30;
        internal int internalVar = 40;
        protected internal int protectedInternalVar = 50;
        private protected int privateProtectedVar = 60;

        // Method to demonstrate access within the same class
        public void ShowInsideBase()
        {
            Console.WriteLine("Inside BaseClass (Same Assembly):");
            Console.WriteLine (publicVar);
            Console.WriteLine(privateVar);
            Console.WriteLine(protectedVar);
            Console.WriteLine(internalVar);
            Console.WriteLine(protectedInternalVar);
            Console.WriteLine(privateProtectedVar);
        }

    }

    // Derived class in the same assembly

    class DerivedSameAssembly : BaseClass
    {
        public void ShowDerivedSameAssembly()
        {
            Console.WriteLine(" Derived class (Same Assembly):");
            Console.WriteLine(publicVar);

            // Console.WriteLine("Private Variable : " + privateVar);       // Not Accessible

            Console.WriteLine(protectedVar);
            Console.WriteLine(internalVar);
            Console.WriteLine(protectedInternalVar);
            Console.WriteLine(privateProtectedVar);
        }
    }

    //Non-derived class in the same assembly
    class NonDerivedSameAssembly
    {
        public void ShowNonDerivedSameAssembly()
        {
            BaseClass baseObj = new BaseClass();

            Console.WriteLine(" Non-Derived class (Same Assembly):");
            Console.WriteLine(baseObj.publicVar);

            // Console.WriteLine("Private Variable : " + baseObj.privateVar);       // Not Accessible

            // Console.WriteLine("Protected Variable : " + baseObj.protectedVar);   // Not Accessible

            Console.WriteLine(baseObj.internalVar);
            Console.WriteLine(baseObj.protectedInternalVar);

            // Console.WriteLine("Private Protected Variable : " + baseObj.privateProtectedVar); // Not Accessible
        }
    }
}

//namespace 2: Outside Assembly

namespace AccessOutside
{
    using AccessLibrary;

    // Derived class in a outside assembly
    class DerivedOutsideAssembly : BaseClass
    {
        public void ShowDerivedOutsideAssembly()
        {
            Console.WriteLine(" Derived class (Outside Assembly):");
            Console.WriteLine(publicVar);

            // Console.WriteLine("Private Variable : " + privateVar);       // Not Accessible

            Console.WriteLine(protectedVar);
            // Console.WriteLine("Internal Variable : " + internalVar);     // Not Accessible

            Console.WriteLine(protectedInternalVar);

            // Console.WriteLine("Private Protected Variable : " + privateProtectedVar);      // Not Accessible
        }
    }

    // Non-derived class in outside assembly
    class NonDerivedOutsideAssembly
    {
        public void ShowNonDerivedOutsideAssembly()
        {
            BaseClass baseObj = new BaseClass();

            Console.WriteLine("Non-Derived class (Outside Assembly):");
            Console.WriteLine(baseObj.publicVar);

            // Console.WriteLine("Private Variable : " + baseObj.privateVar);       // Not Accessible

            // Console.WriteLine("Protected Variable : " + baseObj.protectedVar);   // Not Accessible

            // Console.WriteLine("Internal Variable : " + baseObj.internalVar);     // Not Accessible

            // Console.WriteLine("Protected Internal Variable : " + baseObj.protectedInternalVar); // Not Accessible

            // Console.WriteLine("Private Protected Variable : " + baseObj.privateProtectedVar); // Not Accessible
        }
    }
}

//Program Entry Point

namespace AccessModifiersDemo
{
    using AccessLibrary;
    using AccessOutside;

    class Program
    {
        static void Main()
        {
            // Access within the same assembly
            BaseClass baseObj = new BaseClass();
            baseObj.ShowInsideBase();

            DerivedSameAssembly d1 = new DerivedSameAssembly();
            d1.ShowDerivedSameAssembly();

            NonDerivedSameAssembly n1 = new NonDerivedSameAssembly();
            n1.ShowNonDerivedSameAssembly();

            // Access from outside assembly
            DerivedOutsideAssembly d2 = new DerivedOutsideAssembly();
            d2.ShowDerivedOutsideAssembly();

            NonDerivedOutsideAssembly t2 = new NonDerivedOutsideAssembly();
            t2.ShowNonDerivedOutsideAssembly();
        }
    }
}