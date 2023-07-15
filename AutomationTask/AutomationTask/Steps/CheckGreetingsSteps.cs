using AutomationTask.DriverInit;
using AutomationTask.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace AutomationTask.Steps
{
    [Binding]
    public class CheckGreetingsSteps
    {
        [Given(@"Authorization login page has been opened")]
        public void NavigateToAuthPage()
        {
            Drivers.Navigation("https://my.life-pos.ru/auth/login");
        }

        [Then(@"The welcome inscription is written correctly depending on the current time")]
        public void CheckWelcomeInscription()
        {
            Assert.IsTrue(AuthPage.CheckInscriptionTextIsRight(), "Welcome message does not match the time");
        }
    }
}
