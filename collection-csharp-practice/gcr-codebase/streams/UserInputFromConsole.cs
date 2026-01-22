using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.streams
{
    internal class UserInputFromConsole
    {
        static void Main()
        {
            string basePath = @"D:\Collections\Collections\collection-csharp-practice\gcr-codebase\streams\";
            
            string fileName = basePath + "UserDetails.txt";

            try
            {
                // Read input from console using StreamReader
                using (StreamReader reader = new StreamReader(Console.OpenStandardInput()))
                {
                    Console.Write("Enter your name: ");
                    string name = reader.ReadLine();

                    Console.Write("Enter your age: ");
                    string age = reader.ReadLine();

                    Console.Write("Enter your favorite programming language: ");
                    string language = reader.ReadLine();

                    // Write input to file using StreamWriter
                    using (StreamWriter writer = new StreamWriter(fileName))
                    {
                        writer.WriteLine("User Details");
                        writer.WriteLine("Name: " + name);
                        writer.WriteLine("Age: " + age);
                        writer.WriteLine("Favorite Language: " + language);
                    }
                }

                Console.WriteLine("\nData saved successfully to file.");
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

   