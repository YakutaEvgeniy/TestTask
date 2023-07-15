using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace AutomationTask.DriverInit
{
    public static class DriverFactory
    {
        private static IWebDriver Driver { get; set; }

        public static IWebDriver InitBrowser(string browserName, string lang)
        {
            switch (browserName.ToLower())
            {
                case "firefox":
                    Driver = new FirefoxDriver(DriverOptions.GetFirefoxOptions(lang));
                    return Driver;
                    break;
                case "chrome":
                    Driver = new ChromeDriver(DriverOptions.GetChromeOptions(lang));
                    return Driver;
                    break;
                default:
                    Driver = new ChromeDriver(DriverOptions.GetChromeOptions(lang));
                    return Driver;
                    break;
            }
        }
    }
}
