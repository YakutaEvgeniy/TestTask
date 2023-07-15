using AutomationTask.DriverInit;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace AutomationTask.Hooks
{
    [Binding]
    public sealed class ScenarioHooks
    {
        private IWebDriver driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = Drivers.getDriver();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            if (Drivers.getDriver() != null)
            {
                Drivers.CloseBrowser();
                Drivers.SetDriverNull();
            }
        }
    }
}
