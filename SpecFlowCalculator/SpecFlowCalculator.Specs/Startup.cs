using BoDi;
using Microsoft.Extensions.DependencyInjection;
using SolidToken.SpecFlow.DependencyInjection;
using SpecFlowCalculator.Specs.Drivers;
using SpecFlowCalculator.Specs.PageObjects;

namespace SpecFlowCalculator.Specs
{
    public class Startup
    {
        [ScenarioDependencies]
        public static IServiceCollection CreateService()
        {
            var services = new ServiceCollection();

            services.AddScoped<IBrowserDriver, BrowserDriver>();
            services.AddScoped<IObjectContainer, ObjectContainer>();
            services.AddScoped <ICalculatorPageObject, CalculatorPageObject>();
            services.AddScoped<IGuruPageObject, GuruPageObject>();
            services.AddScoped<IHomePageObject, HomePageObject>();

            return services;
        }
    }
}
