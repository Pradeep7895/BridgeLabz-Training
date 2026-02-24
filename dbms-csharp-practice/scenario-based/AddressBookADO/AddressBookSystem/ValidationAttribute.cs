using System;
using System.Text.RegularExpressions;

namespace AddressBookSystem
{
    [AttributeUsage(AttributeTargets.Property)]
    internal class ValidationAttribute : Attribute
    {
        public string Pattern { get; }
        public string ErrorMessage { get; }

        public ValidationAttribute(string pattern, string errorMessage)
        {
            Pattern = pattern;
            ErrorMessage = errorMessage;
        }

        public bool IsValid(string value)
        {
            return Regex.IsMatch(value ?? "", Pattern);
        }
    }
}