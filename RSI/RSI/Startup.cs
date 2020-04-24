using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RSI.Interfaces;
using SoapCore;
using System.Linq;
using System.ServiceModel;

namespace RSI
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
           ServiceCollectionFactory.GetServiceCollection().ToList().ForEach(x => services.Add(x));
            services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));
            services.AddSoapCore();
            services.AddSoapServiceOperationTuner(new SoapHandler());

            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSoapEndpoint<ISOAPService>("/Service.asmx", new BasicHttpBinding(), SoapSerializer.XmlSerializer);

        }
    }
}