using System;
using System.Reflection;


namespace Collections.collection_csharp_practice.gcr_codebase.reflection
{
    internal class Student
    {
        private string name;

        public Student(string name)
        {
            this.name = name;
        }

        public void Show()
        {
            Console.WriteLine("Student Name: " + name);
        }
    }

    class Program
    {
        static void Main()
        {
            Type type = typeof(Student);

            ConstructorInfo ctor = type.GetConstructor(new Type[] { typeof(string) });

            Student student = (Student)ctor.Invoke(
                new object[] { "Pradeep" });

            student.Show();
        }
    }
}
