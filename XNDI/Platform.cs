using System;

namespace XNDI
{
    public class Platform
    {
        public static string PlatformName;
        public static IAlertManager AlertManager;

        public static void Init(
            string platform,
            IAlertManager alertManager
            )
        {
            PlatformName = platform;
            AlertManager = alertManager;
        }

        public static void CallAlertManagerShowMethod()
        {
            AlertManager.ShowAlert("Test", "This is an alert from the .NET standard library.");
        }
    }
}
