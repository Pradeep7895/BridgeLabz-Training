using System;
using System.Text.RegularExpressions;

namespace Collections.collection_csharp_practice.senario_based
{
    public class FlipKeyLogical
    {
        static void Main()
        {
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine()!;

            FlipKeyLogical obj = new FlipKeyLogical();
            string result = obj.CleanseAndInvert(input);

            if(string.IsNullOrEmpty(result))
                Console.WriteLine("Invalid Input");
            else
                Console.WriteLine("The generated key is - " + result);    


        }

        public string CleanseAndInvert(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return "";
            }
            string pattern = @"^[A-Za-z]{6,}$";
            if (!Regex.IsMatch(input, pattern))
            {
                return " ";
            }
            input = input.ToLower();

            string temp = "";
            foreach (char ch in input)
            {
                if ((int)ch % 2 != 0)
                {
                    temp += ch;
                }
            }

            char[] arr = temp.ToCharArray();
            Array.Reverse(arr);

            for(int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    arr[i] = char.ToUpper(arr[i]);
                }
            }
            return new string(arr);
        }
    }

}