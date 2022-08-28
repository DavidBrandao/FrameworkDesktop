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
        [Given(@"Alarms&Clocks app is opened")]
        public void GivenAlarmsClocksAppIsOpened()
        {
            // Verificar se a aplicação se encontra aberta
            alarmsClocksSession.FindElementByAccessibilityId("MenuItemsScrollViewer");
        }

        [When(@"the user adds a new alarm")]
        public void WhenTheUserAddsANewAlarm()
        {
            // Abrir página do alarme
            alarmsClocksSession.FindElementByAccessibilityId("AlarmButton").Click();

            // Clicar no botão adicionar alarme
            alarmsClocksSession.FindElementByAccessibilityId("AddAlarmButton").Click();

            // Clicar no botão salvar
            alarmsClocksSession.FindElementByAccessibilityId("PrimaryButton").Click();
        }

        [Then(@"the new alarm should be displayed at alarms page")]
        public void ThenTheNewAlarmShouldBeDisplayedAtAlarmsPage()
        {
            // VErificar se um alarme é retornado na lista de items
            Assert.IsTrue(alarmsClocksSession.FindElementsByAccessibilityId("AlarmViewGrid").Count > 0);
        }
    }
}
