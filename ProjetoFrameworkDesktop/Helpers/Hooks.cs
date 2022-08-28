using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
