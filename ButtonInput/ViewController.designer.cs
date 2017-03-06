// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace ButtonInput
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		UIKit.UILabel labelStatus { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (labelStatus != null) {
				labelStatus.Dispose ();
				labelStatus = null;
			}
		}
	}
}
