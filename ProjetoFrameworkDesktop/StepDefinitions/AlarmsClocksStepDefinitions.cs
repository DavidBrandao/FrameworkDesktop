using System;
using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Service;
using OpenQA.Selenium.Appium.Windows;
using ProjetoFrameworkDesktop.Helpers;
using TechTalk.SpecFlow;

namespace FrameworkDesktop
{
    [Binding]
    public class AlarmsClocksStepDefinitions : Hooks
    {

        WindowsDriver<WindowsElement> Driver;

        [Given(@"Alarms&Clocks app is opened")]
        public void GivenAlarmsClocksAppIsOpened()
        {
            /*AppiumOptions capabilities = new AppiumOptions();
            capabilities.AddAdditionalCapability("app", "Microsoft.WindowsAlarms_8wekyb3d8bbwe!App");
            Driver = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), capabilities);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);*/
            alarmsClocksSession.FindElementByAccessibilityId("MenuItemsScrollViewer");
        }

        [When(@"the user adds a new alarm")]
        public void WhenTheUserAddsANewAlarm()
        {
            // Abrir página do alarme
            alarmsClocksSession.FindElementByAccessibilityId("AlarmButton").Click();


            //Clicar no botão adicionar alarme
            alarmsClocksSession.FindElementByAccessibilityId("AddAlarmButton").Click();

            //Clicar no botão salvar
            alarmsClocksSession.FindElementByAccessibilityId("PrimaryButton").Click();
        }

        [Then(@"the new alarm should be displayed at alarms page")]
        public void ThenTheNewAlarmShouldBeDisplayedAtAlarmsPage()
        {
            // VErificar se um alarme é retornado na lista de items
            Assert.IsTrue(alarmsClocksSession.FindElementsByAccessibilityId("AlarmViewGrid").Count > 0);

            //Fechar a sessão da aplicação
            //Driver.Quit();
        }
    }
}
