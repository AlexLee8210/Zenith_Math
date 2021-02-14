using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoreGraphics;
using Foundation;
using Zenith_Math.iOS.CustomRenderer;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using Zenith_Math.CustomElements;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRendereriOS))]
namespace Zenith_Math.iOS.CustomRenderer
{
	public class CustomEntryRendereriOS : EntryRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged(e);

			if(e.OldElement == null)
			{
				Control.Layer.CornerRadius = 16;
				Control.Layer.BorderWidth = 3f;
				Control.Layer.BorderColor = Color.FromHex("#002a6c").ToCGColor();
				Control.Layer.BackgroundColor = Color.White.ToCGColor();

				Control.LeftView = new UIKit.UIView(new CGRect(0, 0, 10, 0));
				Control.LeftViewMode = UIKit.UITextFieldViewMode.Always;
			}
		}
	}
}