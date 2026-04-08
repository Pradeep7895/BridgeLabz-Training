using System;
// using AddressBookSystem.ValidationAttribute;

namespace AddressBookSystem
{
    internal class Contact
    {
        private Guid ContactId = Guid.NewGuid();

        [Validation(@"^[A-Za-z]{2,}$", "Invalid First Name")]
        public string FirstName { get; set; }

        [Validation(@"^[A-Za-z]{2,}$", "Invalid Last Name")]
        public string LastName { get; set; }

        [Validation(@"^.{3,}$", "Invalid Address")]
        public string Address { get; set; }

        [Validation(@"^[A-Za-z]{2,}$", "Invalid City")]
        public string City { get; set; }

        [Validation(@"^[A-Za-z]{2,}$", "Invalid State")]
        public string State { get; set; }

        [Validation(@"^[0-9]{5,6}$", "Invalid Zip Code")]
        public string Zip { get; set; }

        [Validation(@"^[0-9]{10}$", "Invalid Phone Number")]
        public string PhoneNumber { get; set; }

        [Validation(@"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$", "Invalid Email")]
        public string Email { get; set; }


        public Contact() { } 

        public Contact(string firstName, string lastName, string address,
                        string city, string state, string zip,
                        string phoneNumber, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            City = city;
            State = state;
            Zip = zip;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public override string ToString()
        {
            return $"\nFirst Name: {FirstName} | Last Name: {LastName} | Address: {Address} | City: {City} | State: {State} | Zip: {Zip} | Phone: {PhoneNumber} | Email: {Email}";
        }
    }
}