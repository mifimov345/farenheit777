using System.ServiceModel;

namespace farenheit777.Services
{
    [ServiceContract]
    public interface ITemperatureConverterService
    {
        [OperationContract]
        double ConvertCelsiusToFahrenheit(double celsius);
    }
}
