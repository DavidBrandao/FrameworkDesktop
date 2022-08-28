using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;

namespace ProjetoFrameworkDesktop.Helpers
{
    public class Session
    {
        private const string WinAppDriverUrl = "http://127.0.0.1:4723";
        private const string AlarmsClocksAppID = "Microsoft.WindowsAlarms_8wekyb3d8bbwe!App";

        WindowsDriver<WindowsElement> session;

        public WindowsDriver<WindowsElement> OpenTestApp()
        {
            AppiumOptions capabilities = new AppiumOptions();
            capabilities.AddAdditionalCapability("app", AlarmsClocksAppID);
            session = new WindowsDriver<WindowsElement>(new Uri(WinAppDriverUrl), capabilities);
            session.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            Assert.IsNotNull(session);
            return session;
        }

        public void CloseApp(WindowsDriver<WindowsElement> session)
        {
            session.Quit();
        }
    }
}
