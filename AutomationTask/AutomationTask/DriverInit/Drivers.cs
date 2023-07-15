using AutomationTask.Constatns;
using AutomationTask.ObjectsForJson;
using AutomationTask.Utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationTask.DriverInit
{
    public static class Drivers
    {
        private static IWebDriver Driver;
        private static BrowserOptions Options = FileReader.JsonReader<BrowserOptions>(FilePaths.PATH_TO_BROWSER_CONFIG_DATA);

        public static void Navigation(string URL)
        {
            Driver.Navigate().GoToUrl(URL);
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(1000);
        }

        public static IWebDriver getDriver()
        {
            if (Driver == null)
            {
                return Driver = DriverFactory.InitBrowser(Options.BrowserName, Options.Language);
            }
            return Driver;
        }

        public static void SetDriverNull()
        {
            Driver = null;
        }

        public static void CloseBrowser()
        {
            Driver.Quit();
        }
    }
}
