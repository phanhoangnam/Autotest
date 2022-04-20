using OpenQA.Selenium;
using SpecFlowCalculator.Specs.Drivers;
using System;

namespace SpecFlowCalculator.Specs.PageObjects
{
    public interface IGuruPageObject
    {
        void ClickLogin();
        void EnsureGuruIsOpenAndReset();
        void EnterPassword(string password);
        void EnterUsername(string username);
        string GetAlert();
        string GetErrorMessage();
        string GetPasswordNotification();
    }

    public class GuruPageObject : IGuruPageObject
    {
        //The URL of the calculator to be opened in the browser
        private const string GuruUrl = "https://demo.guru99.com/V4/index.php";

        private bool IsEmptyPassword = false;

        //The Selenium web driver to automate the browser
        private readonly IWebDriver _webDriver;
        private readonly IBrowserDriver _browserDriver;

        public GuruPageObject(IBrowserDriver browserDriver)
        {
            //_webDriver = webDriver;
            _browserDriver = browserDriver;
        }

        // Finding elements by Id
        //private IWebElement UserIDElement => _webDriver.FindElement(By.Name("uid"));
        //private IWebElement PasswordElement => _webDriver.FindElement(By.Name("password"));
        //private IWebElement LoginButtonElement => _webDriver.FindElement(By.Name("btnLogin"));
        //private IWebElement PasswordNotificationElement => _webDriver.FindElement(By.Id("message18"));
        //private IAlert AlertElement => _webDriver.SwitchTo().Alert();

        private IWebElement UserIDElement => _browserDriver.Current.FindElement(By.Name("uid"));
        private IWebElement PasswordElement => _browserDriver.Current.FindElement(By.Name("password"));
        private IWebElement LoginButtonElement => _browserDriver.Current.FindElement(By.Name("btnLogin"));
        private IWebElement PasswordNotificationElement => _browserDriver.Current.FindElement(By.Id("message18"));
        private IAlert AlertElement => _browserDriver.Current.SwitchTo().Alert();

        public void EnterUsername(string username)
        {
            UserIDElement.Clear();
            UserIDElement.SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            PasswordElement.Clear();
            PasswordElement.SendKeys(password);
            if (String.IsNullOrEmpty(password))
            {
                IsEmptyPassword = true;
            }
        }

        public void ClickLogin()
        {
            LoginButtonElement.Click();
        }

        public void EnsureGuruIsOpenAndReset()
        {
            //if (_webDriver.Url != GuruUrl)
            if (_browserDriver.Current.Url != GuruUrl)
            {
                //_webDriver.Url = GuruUrl;
                _browserDriver.Current.Url = GuruUrl;
            }
            //Otherwise reset the calculator by clicking the reset button
            //else
            //{
            //    //Click the rest button
            //    ResetButtonElement.Click();

            //    //Wait until the result is empty again
            //    WaitForEmptyResult();
            //}
        }

        public string GetPasswordNotification()
        {
            return PasswordNotificationElement.Text;
        }

        public string GetAlert()
        {
            return AlertElement.Text;
        }

        public string GetErrorMessage()
        {
            if (IsEmptyPassword)
            {
                return GetPasswordNotification();
            }
            else
            {
                string message = GetAlert();
                AlertElement.Accept();
                return message;
            }
        }
    }
}
