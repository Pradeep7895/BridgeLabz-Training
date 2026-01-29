using System;
using System.IO;
using System.Collections.Generic;

namespace Collections.ioprogramming_csharp_practice.gcr_codebase.csv_data_handling
{
    internal class DetectDuplicates
    {
        static void Main(string[] args)
        {
            string filePath = "D:\\Collections\\Collections\\ioprogramming-csharp-practice\\gcr-codebase\\csv-data-handling\\Students.csv";
            HashSet<int> seenIds = new HashSet<int>();

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string? line;

                    // Skip header
                    reader.ReadLine();

                    Console.WriteLine("Duplicate Records:\n");

                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');

                        int id = int.Parse(data[0]);

                        // If ID already exists, it's a duplicate
                        if (!seenIds.Add(id))
                        {
                            Console.WriteLine(line);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

    }
}



    