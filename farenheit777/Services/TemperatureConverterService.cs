namespace farenheit777.Services
{
    public class TemperatureConverterService : ITemperatureConverterService
    {
        public double ConvertCelsiusToFahrenheit(double celsius)
        {
            double fahrenheit = celsius * 9 / 5 + 32;
            return fahrenheit;
        }
    }
}
