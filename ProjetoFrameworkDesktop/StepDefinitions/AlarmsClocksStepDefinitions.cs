using NUnit.Framework;
using ProjetoFrameworkDesktop.Page_Objects;
using TechTalk.SpecFlow;

namespace FrameworkDesktop
{
    [Binding]
    public class AlarmsClocksStepDefinitions : AlarmsClocksPage
    {
        [Given(@"Alarms&Clocks app is opened")]
        public void GivenAlarmsClocksAppIsOpened()
        {
            // Verificar se a aplicação se encontra aberta
            VerifyAppIsOpened();
        }

        [When(@"the user adds a new alarm")]
        public void WhenTheUserAddsANewAlarm()
        {
            // Criar um novo alarme
            AddNewAlarm();
        }

        [Then(@"the new alarm should be displayed at alarms page")]
        public void ThenTheNewAlarmShouldBeDisplayedAtAlarmsPage()
        {
            // VErificar se um alarme é retornado na lista de items
            Assert.IsTrue(VerifyAlarmWasCreated());
        }
    }
}
