using OpenQA.Selenium;
using SpecFlowCalculator.Specs.Drivers;

namespace SpecFlowCalculator.Specs.PageObjects
{
    public interface IHomePageObject
    {
        string GetWelcome();
    }

    public class HomePageObject : IHomePageObject
    {
        private readonly IWebDriver _webDriver;
        private readonly IBrowserDriver _browserDriver;

        public HomePageObject(IBrowserDriver browserDriver)
        {
            //_webDriver = webDriver;
            _browserDriver = browserDriver;
        }
        //IWebElement WelcomeElement => _webDriver.FindElement(By.TagName("marquee"));
        IWebElement WelcomeElement => _browserDriver.Current.FindElement(By.TagName("marquee"));

        public string GetWelcome()
        {
            return WelcomeElement.Text;
        }
    }
}
