using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.address_book_system
{
    //UC-1
    internal class Contact
    {
        //instance variables
        private string FirstName;
        private string LastName;
        private string Address;
        private string City;
        private string State;
        private string Zip;
        private string PhoneNumber;
        private string Email;

        //constructor
        public Contact(string firstName, string lastName, string address, string city, string state, string zip, string phoneNumber, string email)
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

        //public getter and setter
        public string GetFirstName() { return FirstName; }
        public void SetFirstName(string firstName) { FirstName = firstName; }

        public string GetLastName() { return LastName; }
        public void SetLastName(string lastName) { LastName = lastName; }

        public string GetAddress() { return Address; }
        public void SetAddress(string address) { Address = address; }

        public string GetCity() { return City; }
        public void SetCity(string city) { City = city; }

        public string GetState() { return State; }
        public void SetState(string state) { State = state; }

        public string GetZip() { return Zip; }
        public void SetZip(string zip) { Zip = zip; }

        public string GetPhoneNumber() { return PhoneNumber; }
        public void SetPhoneNumber(string phoneNumber) {  PhoneNumber = phoneNumber; }

        public string GetEmail() { return Email; }
        public void SetEmail(string email) { Email = email; }
    }
}
