using farenheit777.Pages;
using farenheit777.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using SoapCore;
using System.ServiceModel;

namespace farenheit777
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();

            // Add SOAP service
            services.AddSingleton<ITemperatureConverterService, TemperatureConverterService>();
        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });

            // Enable SOAP endpoint
            app.UseSoapEndpoint<ITemperatureConverterService>("/TemperatureConverterService", new SoapEncoderOptions(), SoapSerializer.DataContractSerializer);
        }

    }
}
