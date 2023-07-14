using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace AutomationTask.Steps
{
    [Binding]
    public class CheckGreetingsSteps
    {
        [Given(@"Go To AuthPage")]
        public void GivenGoToAuthPage()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.selenium.dev/selenium/web/web-form.html");
        }
    }
}
