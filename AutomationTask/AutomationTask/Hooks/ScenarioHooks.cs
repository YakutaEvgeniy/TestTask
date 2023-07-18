using AutomationTask.DriverInit;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

[assembly:Parallelizable(ParallelScope.Fixtures)]

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
