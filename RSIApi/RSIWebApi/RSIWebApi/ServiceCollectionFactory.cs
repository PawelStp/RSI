using Microsoft.Extensions.DependencyInjection;

namespace RSIWebApi
{
    public static class ServiceCollectionFactory
    {
        public static ServiceCollection GetServiceCollection()
        {
            var services = RSI.Core.ServiceCollectionFactory.GetServiceCollection();

            return services;
        }
    }
}
