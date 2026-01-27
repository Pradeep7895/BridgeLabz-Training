
namespace CoreApp
{
    public class TemperatureConverter
    {
        // Celsius to Fahrenheit
        public double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        // Fahrenheit to Celsius
        public double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}

   
