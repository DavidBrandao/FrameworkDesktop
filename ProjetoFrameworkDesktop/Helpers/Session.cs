using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFrameworkDesktop.Helpers
{
    public class Session
    {
        WindowsDriver<WindowsElement> Driver;

        public WindowsDriver<WindowsElement> OpenTestApp()
        {
            AppiumOptions capabilities = new AppiumOptions();
            capabilities.AddAdditionalCapability("app", "Microsoft.WindowsAlarms_8wekyb3d8bbwe!App");
            Driver = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), capabilities);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            return Driver;
        }

        public void CloseApp(WindowsDriver<WindowsElement> driver)
        {
            driver.Quit();
        }
    }
}
