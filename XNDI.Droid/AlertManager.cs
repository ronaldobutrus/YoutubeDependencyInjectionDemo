using System;
using Android.Content;
using Android.Widget;

namespace XNDI.Droid
{
    public class AlertManager : IAlertManager
    {
        private readonly Context Context;

        public AlertManager(Context context)
        {
            Context = context;
        }

        public void ShowAlert(string title, string text)
        {
            Toast.MakeText(Context, $"{title}: {text}", ToastLength.Short).Show();
        }
    }
}
