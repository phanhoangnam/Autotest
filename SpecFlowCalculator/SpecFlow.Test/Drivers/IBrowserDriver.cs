using OpenQA.Selenium;

namespace SpecFlow.Test.Drivers
{
    public interface IBrowserDriver
    {
        IWebDriver Current { get; }

        void Dispose();
    }
}