using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class DatabaseDataSource : IDataSource
    {
        private readonly string connectionString =
            "Server=localhost\\SQLEXPRESS;Database=AddressBookDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public async Task SaveAsync(List<Contact> contacts)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                foreach (var contact in contacts)
                {
                    using (SqlCommand command = new SqlCommand("SPInsert_Contact", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@FirstName", contact.FirstName);
                        command.Parameters.AddWithValue("@LastName", contact.LastName);
                        command.Parameters.AddWithValue("@Address", contact.Address);
                        command.Parameters.AddWithValue("@City", contact.City);
                        command.Parameters.AddWithValue("@State", contact.State);
                        command.Parameters.AddWithValue("@Zip", contact.Zip);
                        command.Parameters.AddWithValue("@PhoneNumber", contact.PhoneNumber);
                        command.Parameters.AddWithValue("@Email", contact.Email);

                        await command.ExecuteNonQueryAsync();
                    }
                }
            }
        }

        public async Task<List<Contact>> LoadAsync()
        {
            List<Contact> contacts = new List<Contact>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                using (SqlCommand command = new SqlCommand("SPGet_All_Contacts", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            contacts.Add(new Contact(
                                reader["FirstName"]?.ToString(),
                                reader["LastName"]?.ToString(),
                                reader["Address"]?.ToString(),
                                reader["City"]?.ToString(),
                                reader["State"]?.ToString(),
                                reader["Zip"]?.ToString(),
                                reader["PhoneNumber"]?.ToString(),
                                reader["Email"]?.ToString()
                            ));
                        }
                    }
                }
            }

            return contacts;
        }

        public async Task DeleteAsync(string firstName, string lastName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                using (SqlCommand command = new SqlCommand("SPDelete_Contact", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);

                    await command.ExecuteNonQueryAsync();
                }
            }
        }
    }
}