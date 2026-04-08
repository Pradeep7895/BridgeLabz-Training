using System;
using System.Text.RegularExpressions;

namespace CoreApp
{
    public class UserRegistration
    {
        public bool RegisterUser(string username, string email, string password)
        {
            // Username validation
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("Username is invalid");

            // Email validation (basic)
            if (string.IsNullOrWhiteSpace(email) ||
                !Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                throw new ArgumentException("Email is invalid");

            // Password validation
            if (string.IsNullOrWhiteSpace(password) || password.Length < 6)
                throw new ArgumentException("Password is invalid");

            // If all validations pass
            return true;
        }
    }

}



