
namespace CoreApp
{
    public class StringUtilityMethods
    {
        // Reverse the given string
        public string Reverse(string str)
        {
            if (str == null)
                return null;

            char[] chars = str.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        // Check if string is palindrome
        public bool IsPalindrome(string str)
        {
            if (str == null)
                return false;

            string reversed = Reverse(str);
            return str.Equals(reversed, StringComparison.OrdinalIgnoreCase);
        }

        // Convert string to uppercase
        public string ToUpperCase(string str)
        {
            if (str == null)
                return null;

            return str.ToUpper();
        }
    }

}

