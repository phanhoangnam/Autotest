using FluentAssertions;
using SpecFlow.Test.PageObjects;
using System;
using System.Diagnostics;
using System.Threading;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using SpecFlow.Test.Drivers;

namespace SpecFlowCalculator.Specs.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        private readonly IBrowserDriver _browserDriver;
        //Page Object 
        private readonly IGuruPageObject _guruPageObject;
        private readonly IHomePageObject _homePageObject;

        public CalculatorStepDefinitions(IBrowserDriver browserDriver, IGuruPageObject guruPageObject, IHomePageObject homePageObject)
        {
            _browserDriver = browserDriver;
            _guruPageObject = guruPageObject;
            _homePageObject = homePageObject;
        }


        [Given(@"I enter username (.*)")]
        public void GivenIEnterUsername(string username)
        {
            _guruPageObject.EnterUsername(username);
            Console.WriteLine($"User name is: {username}");
            //Thread.Sleep(10000);
        }

        [Given(@"I enter password (.*)")]
        public void GivenIEnterPassword(string password)
        {
            _guruPageObject.EnterPassword(password);
            Console.WriteLine($"Password is: {password}");
            //Thread.Sleep(10000);

        }

        [When(@"I click login button")]
        public void WhenIClickLoginButton()
        {
            //Thread.Sleep(10000);
            _guruPageObject.ClickLogin();
            Console.WriteLine($"Click login button");
            //Thread.Sleep(10000);
        }

        [Then(@"I see error message (.*)")]
        public void ThenISeeErrorMessage(string error)
        {
            _guruPageObject.GetErrorMessage().Should().Be(error);
            Console.WriteLine($"Error is: {error}");
        }




        [Given(@"I enter valid username")]
        public void GivenIEnterValidUsername()
        {
            _guruPageObject.EnterUsername("mngr392292");
        }

        [Given(@"I enter valid password")]
        public void GivenIEnterValidPassword()
        {
            _guruPageObject.EnterPassword("EhytahU");
        }

        [Then(@"I see home page")]
        public void ThenISeeHomePage()
        {
            _homePageObject.GetWelcome().Should().Be("Welcome To Manager's Page of Guru99 Bank");
        }

        [Then(@"The result should ""(.*)""")]
        public void ThenTheResultShould(string result)
        {
            Console.WriteLine($"{nameof(ThenTheResultShould)} : {result}");
        }

    }
}
