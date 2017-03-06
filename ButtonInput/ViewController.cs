using System;
using Foundation;
using UIKit;

namespace ButtonInput
{
    public partial class ViewController : UIViewController
    {
		[Outlet]
		UIButton ButtonTap { get; set; }

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            // Create and hook a handler to our button's TouchUpInside event through its outlet
            //this.buttonTap.TouchUpInside += delegate (object sender, EventArgs e)
            //{
            //    this.labelStatus.Text = "Button tapped";
            //};
			ButtonTap.TouchUpInside += delegate (object sender, EventArgs e)
			{
			    this.labelStatus.Text = "Button tapped";
			};
		}

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}