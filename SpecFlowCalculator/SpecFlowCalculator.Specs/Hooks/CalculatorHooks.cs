using SpecFlowCalculator.Specs.Drivers;
using SpecFlowCalculator.Specs.PageObjects;
using TechTalk.SpecFlow;

namespace SpecFlowCalculator.Specs.Hooks
{
    [Binding]
    public class CalculatorHooks
    {
        ///<summary>
        ///  Reset the calculator before each scenario tagged with "mytag"
        /// </summary>

        //[BeforeScenario]
        //public static void BeforeScenario(BrowserDriver browserDriver)
        //{
        //    //var calculatorPageObject = new CalculatorPageObject(browserDriver.Current);
        //    //calculatorPageObject.EnsureCalculatorIsOpenAndReset();

        //    var guruPageObject = new GuruPageObject(browserDriver.Current);
        //    guruPageObject.EnsureGuruIsOpenAndReset();
        //}

        [BeforeScenario]
        public static void BeforeScenario(IBrowserDriver browserDriver)
        {
            var calculatorPageObject = new CalculatorPageObject(browserDriver);
            calculatorPageObject.EnsureCalculatorIsOpenAndReset();

            //var guruPageObject = new GuruPageObject(browserDriver);
            //guruPageObject.EnsureGuruIsOpenAndReset();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
        }
    }
}
