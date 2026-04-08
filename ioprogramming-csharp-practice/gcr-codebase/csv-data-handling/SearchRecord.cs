using System;
using System.IO;

namespace Collections.ioprogramming_csharp_practice.gcr_codebase.csv_data_handling
{
    internal class SearchRecord
    {
        static void Main()
        {
            string filepath = "D:\\Collections\\Collections\\ioprogramming-csharp-practice\\gcr-codebase\\csv-data-handling\\Employee.csv";

            Console.Write("Enter Employee Name: ");
            string searchName = Console.ReadLine();

            bool found = false;

            try
            {
                using (StreamReader reader = new StreamReader(filepath))
                {
                    string? line;

                    reader.ReadLine();

                    while((line = reader.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');

                        string name = data[1];

                        if(name.Equals(searchName, StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine("\nEmployee Found.");
                            Console.WriteLine("Name : " + name);
                            Console.WriteLine("Department : " + data[2]);
                            Console.WriteLine("Salary : " + data[3]);
                            found = true;
                            break;
                        }
                    }
                }
                if (!found)
                {
                    Console.WriteLine("Employee Not found.");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
