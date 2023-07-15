using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace AutomationTask.DriverInit
{
    public static class DriverOptions
    {
        public static ChromeOptions GetChromeOptions(string lang)
        {
            ChromeOptions chromeoption = new ChromeOptions();
            chromeoption.AddArguments($"--lang={lang}");
            return chromeoption;
        }

        public static FirefoxOptions GetFirefoxOptions(string lang)
        {
            FirefoxOptions profile = new FirefoxOptions();
            profile.SetPreference("intl.accept_languages", lang);
            return profile;
        }
    }
}
