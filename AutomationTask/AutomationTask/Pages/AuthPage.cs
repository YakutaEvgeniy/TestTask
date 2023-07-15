using AutomationTask.DriverInit;
using AutomationTask.Utils;
using OpenQA.Selenium;

namespace AutomationTask.Pages
{
    public static class AuthPage
    {
        private static string titleXpath = "*//div[@class='column router-portal']//div[@class='header']/h2[@class='title']";

        private static IWebElement TitleElement => Drivers.getDriver().FindElement(By.XPath(titleXpath));

        public static bool CheckWelcomeMessageTextIsRight()
        {
            return TitleElement.Text.Equals(DateTimeUtils.GetMessageByTime());
        }
    }
}
