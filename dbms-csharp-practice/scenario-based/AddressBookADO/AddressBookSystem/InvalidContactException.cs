using System;

namespace AddressBookSystem
{
    internal class InvalidContactException : Exception
    {
        public InvalidContactException(string message) : base(message)
        {
        }
    }
}