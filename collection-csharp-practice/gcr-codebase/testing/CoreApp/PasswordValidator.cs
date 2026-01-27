using System.Linq;

namespace CoreApp
{
    public class PasswordValidator
    {
        public bool IsValid(string password)
        {
            if (string.IsNullOrEmpty(password))
                return false;

            // Rule 1: At least 8 characters
            if (password.Length < 8)
                return false;

            // Rule 2: At least one uppercase letter
            if (!password.Any(char.IsUpper))
                return false;

            // Rule 3: At least one digit
            if (!password.Any(char.IsDigit))
                return false;

            return true;
        }

    }
}



     