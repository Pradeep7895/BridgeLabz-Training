using System;
using System.Globalization;

namespace CoreApp
{
    public class DateFormatter
    {
        // Converts yyyy-MM-dd → dd-MM-yyyy
        public string FormatDate(string inputDate)
        {
            if (string.IsNullOrEmpty(inputDate))
                throw new FormatException("Invalid date format");

            DateTime date;

            bool isValid = DateTime.TryParseExact(
                inputDate,
                "yyyy-MM-dd",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out date
            );

            if (!isValid)
                throw new FormatException("Invalid date format");

            return date.ToString("dd-MM-yyyy");
        }
    }

}



