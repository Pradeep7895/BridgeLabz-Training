using Collections.ioprogramming_csharp_practice.gcr_codebase.csv_data_handling;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Collections.ioprogramming_csharp_practice.gcr_codebase.csv_data_handling
{
    static class CryptoHelper
    {
        // 16-byte key (128-bit) – for demo purposes
        private static readonly string Key = "1234567890123456";
        private static readonly string IV = "6543210987654321";

        public static string Encrypt(string plainText)
        {
            using Aes aes = Aes.Create();
            aes.Key = Encoding.UTF8.GetBytes(Key);
            aes.IV = Encoding.UTF8.GetBytes(IV);

            using var encryptor = aes.CreateEncryptor();
            byte[] inputBytes = Encoding.UTF8.GetBytes(plainText);
            byte[] encryptedBytes = encryptor.TransformFinalBlock(inputBytes, 0, inputBytes.Length);

            return Convert.ToBase64String(encryptedBytes);
        }

        public static string Decrypt(string cipherText)
        {
            using Aes aes = Aes.Create();
            aes.Key = Encoding.UTF8.GetBytes(Key);
            aes.IV = Encoding.UTF8.GetBytes(IV);

            using var decryptor = aes.CreateDecryptor();
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            byte[] decryptedBytes = decryptor.TransformFinalBlock(cipherBytes, 0, cipherBytes.Length);

            return Encoding.UTF8.GetString(decryptedBytes);
        }
    }


    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Salary { get; set; }
    }


    internal class EncrypyDecrypt
    {
        static void Main()
        {
            string filePath = "D:\\Collections\\Collections\\ioprogramming-csharp-practice\\gcr-codebase\\csv-data-handling\\employees_encrypted.csv";

            List<Employee> employees = new List<Employee>
        {
            new Employee { ID = 1, Name = "Rahul", Email = "rahul@gmail.com", Salary = "60000" },
            new Employee { ID = 2, Name = "Anita", Email = "anita@yahoo.com", Salary = "55000" }
        };

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("ID,Name,Email,Salary");

                foreach (var e in employees)
                {
                    string encryptedEmail = CryptoHelper.Encrypt(e.Email);
                    string encryptedSalary = CryptoHelper.Encrypt(e.Salary);

                    writer.WriteLine($"{e.ID},{e.Name},{encryptedEmail},{encryptedSalary}");
                }
            }

            Console.WriteLine("CSV written with encrypted data.");

            ReadAndDecryptCSV(filePath);
        }
        static void ReadAndDecryptCSV(string filePath)
        {
            Console.WriteLine("\nDecrypted CSV Data:\n");

            using (StreamReader reader = new StreamReader(filePath))
            {
                reader.ReadLine(); // skip header
                string? line;

                while ((line = reader.ReadLine()) != null)
                {
                    string[] data = line.Split(',');

                    string email = CryptoHelper.Decrypt(data[2]);
                    string salary = CryptoHelper.Decrypt(data[3]);

                    Console.WriteLine($"ID     : {data[0]}");
                    Console.WriteLine($"Name   : {data[1]}");
                    Console.WriteLine($"Email  : {email}");
                    Console.WriteLine($"Salary : {salary}");
                    Console.WriteLine("---------------------");
                }
            }
        }
    }
}




  
