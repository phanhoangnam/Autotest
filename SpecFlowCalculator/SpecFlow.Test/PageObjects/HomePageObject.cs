using OpenQA.Selenium;
using SpecFlow.Test.Drivers;

namespace SpecFlow.Test.PageObjects
{
    public interface IHomePageObject
    {
        string GetWelcome();
    }

    public class HomePageObject : IHomePageObject
    {
        private readonly IBrowserDriver _browserDriver;

        public HomePageObject(IBrowserDriver browserDriver)
        {
            _browserDriver = browserDriver;
        }
        
        IWebElement WelcomeElement => _browserDriver.Current.FindElement(By.TagName("marquee"));

        public string GetWelcome()
        {
            return WelcomeElement.Text;
        }
    }
}
