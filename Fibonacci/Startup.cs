using Microsoft.Extensions.DependencyInjection;
using Services;
using System;

namespace Fibonacci
{
    public class Startup
    {
        public static IServiceProvider ConfigureServices()
        {
            var provider = new ServiceCollection()
                .AddScoped<IServiceRepository, ServiceRepository>()
                .BuildServiceProvider();

            return provider;
        }
    }
}
