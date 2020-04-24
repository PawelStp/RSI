using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using RSI.Interfaces;
using RSI.Services;

namespace RSI
{
    public static class ServiceCollectionFactory
    {
        public static ServiceCollection GetServiceCollection()
        {
            var services = Core.ServiceCollectionFactory.GetServiceCollection();

            ConfigureServices(services);

            return services;
        }

        public static void ConfigureServices(ServiceCollection services)
        {
            services.AddSingleton<ISOAPService, SOAPService>();
        }
    }
}
