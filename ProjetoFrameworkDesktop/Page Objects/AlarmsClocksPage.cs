using ProjetoFrameworkDesktop.Helpers;

namespace ProjetoFrameworkDesktop.Page_Objects
{
    public class AlarmsClocksPage : Hooks
    {
        string appMenuID = "MenuItemsScrollViewer";
        string alarmPageMenuButtonID = "AlarmButton";
        string addAlarmButtonID = "AddAlarmButton";
        string saveAlarmButtonID = "PrimaryButton";
        string alarmListItemID = "AlarmViewGrid";

        public void VerifyAppIsOpened()
        {
            alarmsClocksSession.FindElementByAccessibilityId(appMenuID);
        }

        public void AddNewAlarm()
        {
            // Abrir página do alarme
            alarmsClocksSession.FindElementByAccessibilityId(alarmPageMenuButtonID).Click();

            // Clicar no botão adicionar alarme
            alarmsClocksSession.FindElementByAccessibilityId(addAlarmButtonID).Click();

            // Clicar no botão salvar
            alarmsClocksSession.FindElementByAccessibilityId(saveAlarmButtonID).Click();
        }

        public bool VerifyAlarmWasCreated()
        {
            return (alarmsClocksSession.FindElementsByAccessibilityId(alarmListItemID).Count > 0);
        }
    }
}
