using System;
using System.IO;
using System.Collections.Generic;

namespace Collections.ioprogramming_csharp_practice.gcr_codebase.csv_data_handling
{
    internal class ReadLargeCSV
    {
        static void Main(string[] args)
        {
            string filePath = "D:\\Collections\\Collections\\ioprogramming-csharp-practice\\gcr-codebase\\csv-data-handling\\largefile.csv";
            int batchSize = 100;
            int totalRecords = 0;

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string? line;
                    List<string> buffer = new List<string>(batchSize);

                    // Skip header row
                    reader.ReadLine();

                    while ((line = reader.ReadLine()) != null)
                    {
                        buffer.Add(line);

                        // When batch is full
                        if (buffer.Count == batchSize)
                        {
                            ProcessBatch(buffer);
                            totalRecords += buffer.Count;
                            buffer.Clear();

                            Console.WriteLine($"Processed records so far: {totalRecords}");
                        }
                    }

                    // Process remaining lines
                    if (buffer.Count > 0)
                    {
                        ProcessBatch(buffer);
                        totalRecords += buffer.Count;
                        Console.WriteLine($"Processed records so far: {totalRecords}");
                    }
                }

                Console.WriteLine($"\nTotal records processed: {totalRecords}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        static void ProcessBatch(List<string> records)
        {
            // Simulate processing 
            foreach (string record in records)
            {
                //just parse or validate here
                // string[] columns = record.Split(',');
            }
        }

    }
}



    