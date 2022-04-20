using FluentAssertions;
using SpecFlowCalculator.Specs.Drivers;
using SpecFlowCalculator.Specs.PageObjects;
using System.Threading;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Xunit.Abstractions;

namespace SpecFlowCalculator.Specs.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        private readonly ScenarioContext _outputHelper;
        private readonly IBrowserDriver _browserDriver;
        //Page Objects
        private readonly ICalculatorPageObject _calculatorPageObject;
        private readonly IGuruPageObject _guruPageObject;
        private readonly IHomePageObject _homePageObject;

        public CalculatorStepDefinitions(IBrowserDriver browserDriver, ScenarioContext outputHelper, IHomePageObject homePageObject, IGuruPageObject guruPageObject, ICalculatorPageObject calculatorPageObject)
        {
            _browserDriver = browserDriver;
            _outputHelper = outputHelper;
            _homePageObject = homePageObject;
            _guruPageObject = guruPageObject;
            _calculatorPageObject = calculatorPageObject;
        }

        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            //delegate to Page Object
            _calculatorPageObject.EnterFirstNumber(number.ToString());
            _outputHelper.ScenarioContainer.Resolve<ITestOutputHelper>().WriteLine($"The first number is: {number}");
            //Thread.Sleep(5000);
        }

        [Given(@"the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            //delegate to Page Object
            _calculatorPageObject.EnterSecondNumber(number.ToString());
            _outputHelper.ScenarioContainer.Resolve<ITestOutputHelper>().WriteLine($"The second number is: {number}");
            //Thread.Sleep(5000);
        }

        [When(@"the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            //delegate to Page Object
            _calculatorPageObject.ClickAdd();
            _outputHelper.ScenarioContainer.Resolve<ITestOutputHelper>().WriteLine($"Adding two numbers ...");
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int expectedResult)
        {
            //delegate to Page Object
            var actualResult = _calculatorPageObject.WaitForNonEmptyResult();
            _outputHelper.ScenarioContainer.Resolve<ITestOutputHelper>().WriteLine($"Actual result is: {actualResult}");
            _outputHelper.ScenarioContainer.Resolve<ITestOutputHelper>().WriteLine($"Expected result is: {expectedResult}");
            actualResult.Should().Be(expectedResult.ToString());
            //Thread.Sleep(5000);
        }

        [Given(@"I input fllowing numbers to the calculator")]
        public void GivenIInputFllowingNumbersToTheCalculator(Table table)
        {
            dynamic datas = table.CreateDynamicSet();
            foreach (var item in datas)
            {
                _outputHelper.ScenarioContainer.Resolve<ITestOutputHelper>().WriteLine($"The number 1 is {item.Number1}");
                _outputHelper.ScenarioContainer.Resolve<ITestOutputHelper>().WriteLine($"The number 2 is {item.Number2}");
                _outputHelper.ScenarioContainer.Resolve<ITestOutputHelper>().WriteLine($"The number 3 is {item.Number3}");
                _outputHelper.ScenarioContainer.Resolve<ITestOutputHelper>().WriteLine($"The number 4 is {item.Number4}");
            }
        }






        [Given(@"I enter valid username")]
        public void GivenIEnterValidUsername()
        {
            _guruPageObject.EnterUsername("mngr392292");
            //Thread.Sleep(10000);
        }


        [Given(@"I enter valid password")]
        public void GivenIEnterValidPassword()
        {
            _guruPageObject.EnterPassword("EhytahU");
            //Thread.Sleep(10000);
        }

        [When(@"I click login button")]
        public void WhenIClickLoginButton()
        {
            //Thread.Sleep(10000);
            _guruPageObject.ClickLogin();
            //Thread.Sleep(10000);
        }

        [Then(@"I see home page")]
        public void ThenISeeHomePage()
        {
            _homePageObject.GetWelcome().Should().Be("Welcome To Manager's Page of Guru99 Bank");
        }

        [Then(@"The result should ""(.*)""")]
        public void ThenTheResultShould(string result)
        {
            _outputHelper.ScenarioContainer.Resolve<ITestOutputHelper>().WriteLine($"{nameof(ThenTheResultShould)} : {result}");
        }






        [Given(@"I enter username (.*)")]
        public void GivenIEnterUsername(string username)
        {
            _guruPageObject.EnterUsername(username);
            //Thread.Sleep(10000);
        }

        [Given(@"I enter password (.*)")]
        public void GivenIEnterPassword(string password)
        {
            _guruPageObject.EnterPassword(password);
            //Thread.Sleep(10000);
            
        }

        [Then(@"I see error message (.*)")]
        public void ThenISeeErrorMessage(string error)
        {
            _guruPageObject.GetErrorMessage().Should().Be(error);
        }


    }
}
