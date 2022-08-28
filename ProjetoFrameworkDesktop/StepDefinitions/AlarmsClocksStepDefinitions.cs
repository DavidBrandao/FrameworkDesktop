using System;
using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Service;
using OpenQA.Selenium.Appium.Windows;
using TechTalk.SpecFlow;

namespace FrameworkDesktop
{
    [Binding]
    public class AlarmsClocksStepDefinitions
    {

        WindowsDriver<WindowsElement> Driver;

        [Given(@"Alarms&Clocks app is opened")]
        public void GivenAlarmsClocksAppIsOpened()
        {
            AppiumOptions capabilities = new AppiumOptions();
            capabilities.AddAdditionalCapability("app", "Microsoft.WindowsAlarms_8wekyb3d8bbwe!App");
            Driver = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), capabilities);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [When(@"the user adds a new alarm")]
        public void WhenTheUserAddsANewAlarm()
        {
            // Abrir página do alarme
            Driver.FindElementByAccessibilityId("AlarmButton").Click();

            //Clicar no botão adicionar alarme
            Driver.FindElementByAccessibilityId("AddAlarmButton").Click();

            //Clicar no botão salvar
            Driver.FindElementByAccessibilityId("PrimaryButton").Click();
        }

        [Then(@"the new alarm should be displayed at alarms page")]
        public void ThenTheNewAlarmShouldBeDisplayedAtAlarmsPage()
        {
            // VErificar se um alarme é retornado na lista de items
            Assert.IsTrue(Driver.FindElementsByAccessibilityId("AlarmViewGrid").Count > 0);

            //Fechar a sessão da aplicação
            Driver.Quit();
        }
    }
}
