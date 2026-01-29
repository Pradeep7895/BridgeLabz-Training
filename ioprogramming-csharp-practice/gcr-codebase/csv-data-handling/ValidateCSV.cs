using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Collections.ioprogramming_csharp_practice.gcr_codebase.csv_data_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "D:\\Collections\\Collections\\ioprogramming-csharp-practice\\gcr-codebase\\csv-data-handling\\Users.csv";

            // Regex patterns
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            string phonePattern = @"^\d{10}$";

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string? line;

                    // Skip header
                    reader.ReadLine();

                    Console.WriteLine("Invalid Records:\n");

                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');

                        string email = data[2];
                        string phone = data[3];

                        bool emailValid = Regex.IsMatch(email, emailPattern);
                        bool phoneValid = Regex.IsMatch(phone, phonePattern);

                        if (!emailValid || !phoneValid)
                        {
                            Console.WriteLine($"Row Data : {line}");

                            if (!emailValid)
                                Console.WriteLine("Invalid Email Format");

                            if (!phoneValid)
                                Console.WriteLine("Invalid Phone Number (must be 10 digits)");

                            Console.WriteLine("-----------------------------");
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


