using System;
using UIKit;

namespace XNDI.iOS
{
    public class AlertManager : IAlertManager
    {
        public void ShowAlert(string title, string text)
        {
            UIAlertController alertController = UIAlertController.Create(title, text, UIAlertControllerStyle.Alert);
            alertController.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));
            UIApplication.SharedApplication.KeyWindow.RootViewController.PresentViewController(alertController, true, null);
        }
    }
}
