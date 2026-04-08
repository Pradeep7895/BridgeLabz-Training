using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.streams
{
    internal class StudentDataStream
    {
        static void Main()
        {
            string basePath = @"D:\Collections\Collections\collection-csharp-practice\gcr-codebase\streams\";
            string fileName = basePath + "student.dat";

            try
            {
                // Writing primitive data 
                using (FileStream fsWrite = new FileStream(fileName, FileMode.Create, FileAccess.Write))
                using (BinaryWriter writer = new BinaryWriter(fsWrite))
                {
                    writer.Write(101);                 // Roll Number
                    writer.Write("Pradeep");           // Name
                    writer.Write(8.75);                // GPA
                }

                Console.WriteLine("Student data written successfully.\n");

                // Reading primitive data 
                using (FileStream fsRead = new FileStream(fileName, FileMode.Open, FileAccess.Read))
                using (BinaryReader reader = new BinaryReader(fsRead))
                {
                    int rollNo = reader.ReadInt32();
                    string name = reader.ReadString();
                    double gpa = reader.ReadDouble();

                    Console.WriteLine("Retrieved Student Data:");
                    Console.WriteLine("Roll Number : " + rollNo);
                    Console.WriteLine("Name        : " + name);
                    Console.WriteLine("GPA         : " + gpa);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("I/O Error occurred:");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected Error:");
                Console.WriteLine(ex.Message);
            }
        }

    }
}

  