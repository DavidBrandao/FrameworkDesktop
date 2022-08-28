using OpenQA.Selenium.Appium.Windows;
using TechTalk.SpecFlow;

namespace ProjetoFrameworkDesktop.Helpers
{
    [Binding]
    public class Hooks : Session
    {
        public WindowsDriver<WindowsElement> alarmsClocksSession;

        [BeforeScenario]
        public void BeforeScenario()
        {
            alarmsClocksSession = OpenTestApp();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            CloseApp(alarmsClocksSession);
        }
    }
}
