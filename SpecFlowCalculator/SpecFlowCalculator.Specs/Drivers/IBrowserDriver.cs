using OpenQA.Selenium;

namespace SpecFlowCalculator.Specs.Drivers
{
    public interface IBrowserDriver
    {
        IWebDriver Current { get; }

        void Dispose();
    }
}