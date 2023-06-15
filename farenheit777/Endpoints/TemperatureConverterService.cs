using Microsoft.AspNetCore.Builder;
using SoapCore;
using farenheit777.Services;
using System.ServiceModel;

namespace farenheit777.Endpoints
{
    public static class TemperatureConverterService
    {
        public static void ConfigureEndpoint(IApplicationBuilder app)
        {
            app.UseRouting();

        }
    }
}
