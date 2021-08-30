using Foundation;
using System;
using UIKit;

namespace XNDI.iOS
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            alertButton.TouchUpInside += AlertButton_TouchUpInside;
            // Perform any additional setup after loading the view, typically from a nib.
        }

        private void AlertButton_TouchUpInside(object sender, EventArgs e)
        {
            Platform.CallAlertManagerShowMethod();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
