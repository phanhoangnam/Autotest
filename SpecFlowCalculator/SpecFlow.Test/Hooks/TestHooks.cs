using BoDi;
using SpecFlow.Test.Drivers;
using SpecFlow.Test.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlow.Test.Hooks
{
    [Binding]
    public class TestHooks
    {
        ///<summary>
        ///  Reset the calculator before each scenario tagged with "mytag"
        /// </summary>

        [BeforeScenario]
        public static void BeforeScenario(IBrowserDriver browserDriver)
        {
            var guruPageObject = new GuruPageObject(browserDriver);
            guruPageObject.EnsureGuruIsOpenAndReset();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
        }
    }
}
