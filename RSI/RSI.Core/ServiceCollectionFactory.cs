using Microsoft.Extensions.DependencyInjection;
using RSI.Core.Interfaces;
using RSI.Core.Services;

namespace RSI.Core
{
    public static class ServiceCollectionFactory
    {
        public static ServiceCollection GetServiceCollection()
        {
            var services = new ServiceCollection();

            services.AddSingleton<IEventService, EventService>();
            services.AddSingleton<IUserService, UserService>();

            return services;
        }
    }
}
