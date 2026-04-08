using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class AddressBookUtility : IAddressBook
    {
        private AddressBook systemBook;
        private AddressBook currentBook;
        private readonly IDataSource dataSource;

        private Dictionary<string, List<Contact>> cityDictionary = new();
        private Dictionary<string, List<Contact>> stateDictionary = new();

        public AddressBookUtility(AddressBook systemBook, IDataSource dataSource)
        {
            this.systemBook = systemBook;
            this.dataSource = dataSource;
        }

        //VALIDATION USING REFLECTION

        private void ValidateContact(Contact contact)
        {
            var properties = typeof(Contact).GetProperties(
                BindingFlags.NonPublic | BindingFlags.Instance);

            foreach (var property in properties)
            {
                var attribute = property.GetCustomAttribute<ValidationAttribute>();
                if (attribute != null)
                {
                    var value = property.GetValue(contact)?.ToString();
                    if (!attribute.IsValid(value))
                        throw new InvalidContactException(attribute.ErrorMessage);
                }
            }
        }


        public void AddContact()
        {
            try
            {
                if (currentBook == null)
                {
                    Console.WriteLine("Please open an Address Book first.");
                    return;
                }

                if (currentBook.GetContacts().Count >= currentBook.GetMaxSize())
                {
                    Console.WriteLine("Address book is full");
                    return;
                }

                Console.Write("Enter First name: ");
                string firstName = Console.ReadLine();

                Console.Write("Enter Last name: ");
                string lastName = Console.ReadLine();

                if (IsDuplicateContact(firstName, lastName))
                {
                    Console.WriteLine("Duplicate contact found.");
                    return;
                }

                Console.Write("Enter Address: ");
                string address = Console.ReadLine();

                Console.Write("Enter City: ");
                string city = Console.ReadLine();

                Console.Write("Enter State: ");
                string state = Console.ReadLine();

                Console.Write("Enter Zip: ");
                string zip = Console.ReadLine();

                Console.Write("Enter Phone Number: ");
                string phoneNumber = Console.ReadLine();

                Console.Write("Enter Email: ");
                string email = Console.ReadLine();

                Contact newContact = new Contact(firstName, lastName, address,
                                                city, state, zip,
                                                phoneNumber, email);

                ValidateContact(newContact);

                currentBook.GetContacts().Add(newContact);

                // Add to dictionary
                if (!cityDictionary.ContainsKey(city))
                    cityDictionary[city] = new List<Contact>();
                cityDictionary[city].Add(newContact);

                if (!stateDictionary.ContainsKey(state))
                    stateDictionary[state] = new List<Contact>();
                stateDictionary[state].Add(newContact);

                Console.WriteLine("Contact added successfully");
            }
            catch (InvalidContactException ex)
            {
                Console.WriteLine("Validation Error: " + ex.Message);
            }
        }

        private bool IsDuplicateContact(string firstName, string lastName)
        {
            return currentBook.GetContacts()
                .Any(c => c.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase)
                        && c.LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase));
        }


        public void DisplayAllContacts()
        {
            if (currentBook == null || currentBook.GetContacts().Count == 0)
            {
                Console.WriteLine("No contacts Available");
                return;
            }

            currentBook.GetContacts()
                .ForEach(contact => Console.WriteLine(contact));
        }


        public void EditContactByName()
        {
            Console.Write("Enter first name of contact to edit: ");
            string name = Console.ReadLine();

            var contact = currentBook.GetContacts()
                .FirstOrDefault(c => c.FirstName
                .Equals(name, StringComparison.OrdinalIgnoreCase));

            if (contact == null)
            {
                Console.WriteLine("Contact not found.");
                return;
            }

            Console.Write("Enter Last name: ");
            contact.LastName = Console.ReadLine();

            Console.Write("New Address: ");
            contact.Address = Console.ReadLine();

            Console.Write("New City: ");
            contact.City = Console.ReadLine();

            Console.Write("New State: ");
            contact.State = Console.ReadLine();

            Console.Write("Enter Zip: ");
            string zip = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            string phoneNumber = Console.ReadLine();

            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            Console.WriteLine("Contact updated successfully.");
        }


        public void DeleteContactByName()
        {
            Console.Write("Enter first name to delete: ");
            string name = Console.ReadLine();

            var contact = currentBook.GetContacts()
                .FirstOrDefault(c => c.FirstName
                .Equals(name, StringComparison.OrdinalIgnoreCase));

            if (contact == null)
            {
                Console.WriteLine("Contact not found.");
                return;
            }

            currentBook.GetContacts().Remove(contact);
            Console.WriteLine("Contact deleted successfully.");
        }


        public void AddMultipleContacts()
        {
            Console.Write("How many contacts you want to add: ");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
                AddContact();
        }


        public void CreateAddressBook()
        {
            Console.Write("Enter Address Book name: ");
            string name = Console.ReadLine();

            systemBook.GetAddressBookNames().Add(name);
            systemBook.GetAddressBooks().Add(new AddressBook(0, 10));

            Console.WriteLine("Address Book Created successfully.");
        }

        public void SelectAddressBook()
        {
            Console.Write("Enter Address Book Name: ");
            string name = Console.ReadLine();

            int index = systemBook.GetAddressBookNames()
                .FindIndex(n => n.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (index == -1)
            {
                Console.WriteLine("Address Book not found.");
                return;
            }

            currentBook = systemBook.GetAddressBooks()[index];
            Console.WriteLine("Address Book opened successfully.");
        }

        public void DisplayAddressBooks()
        {
            systemBook.GetAddressBookNames()
                .ForEach(name => Console.WriteLine($"- {name}"));
        }

        public bool IsAddressBookSelected() => currentBook != null;

        // SEARCH USING LINQ 

        public void SearchPersonByCity()
        {
            Console.Write("Enter City: ");
            string city = Console.ReadLine();

            var persons = systemBook.GetAddressBooks()
                .SelectMany(book => book.GetContacts())
                .Where(c => c.City
                .Equals(city, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (!persons.Any())
                Console.WriteLine("No persons found.");
            else
                persons.ForEach(p => Console.WriteLine(p));
        }

        public void SearchPersonByState()
        {
            Console.Write("Enter State: ");
            string state = Console.ReadLine();

            var persons = systemBook.GetAddressBooks()
                .SelectMany(book => book.GetContacts())
                .Where(c => c.State
                .Equals(state, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (!persons.Any())
                Console.WriteLine("No persons found.");
            else
                persons.ForEach(p => Console.WriteLine(p));
        }

        public void SearchContactInCityOrState()
        {
            Console.Write("Enter City or State: ");
            string input = Console.ReadLine();

            var persons = systemBook.GetAddressBooks()
                .SelectMany(book => book.GetContacts())
                .Where(c => c.City.Equals(input, StringComparison.OrdinalIgnoreCase)
                        || c.State.Equals(input, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (!persons.Any())
                Console.WriteLine("No persons found.");
            else
                persons.ForEach(p => Console.WriteLine(p));
        }

        public void CountContactsByCityOrState()
        {
            Console.Write("Enter City or State: ");
            string input = Console.ReadLine();

            int count = systemBook.GetAddressBooks()
                .SelectMany(book => book.GetContacts())
                .Count(c => c.City.Equals(input, StringComparison.OrdinalIgnoreCase)
                        || c.State.Equals(input, StringComparison.OrdinalIgnoreCase));

            Console.WriteLine($"Total contacts in '{input}': {count}");
        }

        //SORT USING LINQ 

        public void SortContactsByFirstName()
        {
            foreach (var book in systemBook.GetAddressBooks())
            {
                var sorted = book.GetContacts()
                    .OrderBy(c => c.FirstName)
                    .ToList();

                book.GetContacts().Clear();
                book.GetContacts().AddRange(sorted);
            }

            Console.WriteLine("Contacts sorted successfully.");
        }

        // UC 12 for sorting 

        public void SortContactsByCity()
        {
            if (currentBook == null)
            {
                Console.WriteLine("Open an Address Book first.");
                return;
            }

            var sorted = currentBook.GetContacts()
                .OrderBy(c => c.City)
                .ToList();

            currentBook.GetContacts().Clear();
            currentBook.GetContacts().AddRange(sorted);

            Console.WriteLine("Contacts sorted by City successfully.");
        }

        public void SortContactsByState()
        {
            if (currentBook == null)
            {
                Console.WriteLine("Open an Address Book first.");
                return;
            }

            var sorted = currentBook.GetContacts()
                .OrderBy(c => c.State)
                .ToList();

            currentBook.GetContacts().Clear();
            currentBook.GetContacts().AddRange(sorted);

            Console.WriteLine("Contacts sorted by State successfully.");
        }

        public void SortContactsByZip()
        {
            if (currentBook == null)
            {
                Console.WriteLine("Open an Address Book first.");
                return;
            }

            var sorted = currentBook.GetContacts()
                .OrderBy(c => c.Zip)
                .ToList();

            currentBook.GetContacts().Clear();
            currentBook.GetContacts().AddRange(sorted);

            Console.WriteLine("Contacts sorted by Zip successfully.");
        }

        // UC - 13
        private readonly string filePath = "AddressBookData.txt";

        //method to write data in file
        public void WriteContactsToFile()
        {
            if (currentBook == null)
            {
                Console.WriteLine("Open an Address Book first.");
                return;
            }

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (var contact in currentBook.GetContacts())
                    {
                        writer.WriteLine($"{contact.FirstName},{contact.LastName},{contact.Address},{contact.City},{contact.State},{contact.Zip},{contact.PhoneNumber},{contact.Email}");
                    }
                }

                Console.WriteLine("Contacts written to file successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error writing to file: " + ex.Message);
            }
        }

        //method to read data from the file
        public void ReadContactsFromFile()
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found.");
                return;
            }

            try
            {
                currentBook.GetContacts().Clear();

                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');

                        if (data.Length == 8)
                        {
                            Contact contact = new Contact(
                                data[0], data[1], data[2], data[3],
                                data[4], data[5], data[6], data[7]);

                            currentBook.GetContacts().Add(contact);
                        }
                    }
                }

                Console.WriteLine("Contacts loaded from file successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading file: " + ex.Message);
            }
        }

        // UC - 14 
        private readonly string csvFilePath = "AddressBookData.csv";

        public async Task WriteContactsToCSVAsync()
        {
            if (currentBook == null)
            {
                Console.WriteLine("Open an Address Book first.");
                return;
            }

            try
            {
                using (StreamWriter writer = new StreamWriter(csvFilePath))
                {
                    await writer.WriteLineAsync("FirstName,LastName,Address,City,State,Zip,PhoneNumber,Email");

                    foreach (var contact in currentBook.GetContacts())
                    {
                        string line =
                            $"{contact.FirstName}," +
                            $"{contact.LastName}," +
                            $"{contact.Address}," +
                            $"{contact.City}," +
                            $"{contact.State}," +
                            $"{contact.Zip}," +
                            $"{contact.PhoneNumber}," +
                            $"{contact.Email}";

                        await writer.WriteLineAsync(line);
                    }
                }

                Console.WriteLine("CSV written asynchronously.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public async Task ReadContactsFromCSVAsync()
        {
            if (!File.Exists(csvFilePath))
            {
                Console.WriteLine("CSV file not found.");
                return;
            }

            if (currentBook == null)
            {
                Console.WriteLine("Open an Address Book first.");
                return;
            }

            try
            {
                currentBook.GetContacts().Clear();

                using (StreamReader reader = new StreamReader(csvFilePath))
                {
                    string? line;
                    bool header = true;

                    while ((line = await reader.ReadLineAsync()) != null)
                    {
                        if (header)
                        {
                            header = false;
                            continue;
                        }

                        string[] data = line.Split(',');

                        if (data.Length == 8)
                        {
                            currentBook.GetContacts().Add(
                                new Contact(data[0], data[1], data[2],
                                            data[3], data[4], data[5],
                                            data[6], data[7]));
                        }
                    }
                }

                Console.WriteLine("CSV loaded asynchronously.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        // UC - 15 
        private readonly string jsonFilePath = "AddressBookData.json";

        public async Task WriteContactsToJSONAsync()
        {
            if (currentBook == null)
            {
                Console.WriteLine("Open an Address Book first.");
                return;
            }

            try
            {
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true
                };

                string json = JsonSerializer.Serialize(currentBook.GetContacts(), options);

                await File.WriteAllTextAsync(jsonFilePath, json);

                Console.WriteLine("JSON written asynchronously.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public async Task ReadContactsFromJSONAsync()
        {
            if (!File.Exists(jsonFilePath))
            {
                Console.WriteLine("JSON file not found.");
                return;
            }

            if (currentBook == null)
            {
                Console.WriteLine("Open an Address Book first.");
                return;
            }

            try
            {
                string json = await File.ReadAllTextAsync(jsonFilePath);

                var contacts = JsonSerializer.Deserialize<List<Contact>>(json);

                currentBook.GetContacts().Clear();

                if (contacts != null)
                    currentBook.GetContacts().AddRange(contacts);

                Console.WriteLine("JSON loaded asynchronously.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        // UC - 18  - To save and load the data from the database 
        public async Task SaveToDatabaseAsync()
        {
            if (currentBook == null)
            {
                Console.WriteLine("Open an Address Book first.");
                return;
            }

            await dataSource.SaveAsync(currentBook.GetContacts());
            Console.WriteLine("Saved to Database successfully.");
        }

        public async Task LoadFromDatabaseAsync()
        {
            if (currentBook == null)
            {
                Console.WriteLine("Open an Address Book first.");
                return;
            }

            var contacts = await dataSource.LoadAsync();

            currentBook.GetContacts().Clear();
            currentBook.GetContacts().AddRange(contacts);

            Console.WriteLine("Loaded from Database successfully.");
        }

        //methos to delete data from table from database
        public async Task DeleteContactFromDatabaseAsync()
        {
            Console.Write("Enter First Name: ");
            string first = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            string last = Console.ReadLine();

            await dataSource.DeleteAsync(first, last);
            Console.WriteLine("Contact deleted from database successfully.");
        }
    }
}