using Microsoft.Extensions.DependencyInjection;
using SolidToken.SpecFlow.DependencyInjection;
using SpecFlow.Test.Drivers;
using SpecFlow.Test.PageObjects;
using System;

namespace SpecFlow.Test
{
    public class Startup
    {
        [ScenarioDependencies]
        public static IServiceCollection CreateService()
        {
            var services = new ServiceCollection();

            
            services.AddScoped<IBrowserDriver, BrowserDriver>();
            services.AddScoped<IGuruPageObject, GuruPageObject>();
            services.AddScoped<IHomePageObject, HomePageObject>();

            return services;
        }
    }
}
