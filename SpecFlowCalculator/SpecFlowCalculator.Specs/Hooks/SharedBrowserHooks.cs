using BoDi;
using SpecFlowCalculator.Specs.Drivers;
using TechTalk.SpecFlow;

namespace SpecFlowCalculator.Specs.Hooks
{
    [Binding]
    public class SharedBrowserHooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenario(IObjectContainer testThreadContainer)
        {
            //Initialize a shared BrowserDriver in the global container
            testThreadContainer.Resolve<BrowserDriver>();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
        }
    }
}
