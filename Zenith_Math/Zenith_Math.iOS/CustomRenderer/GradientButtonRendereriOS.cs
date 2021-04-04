using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using Zenith_Math.CustomElements;
using Zenith_Math.iOS.CustomRenderer;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(GradientButton), typeof(GradientButtonRendereriOS))]
namespace Zenith_Math.iOS.CustomRenderer
{
	public class GradientButtonRendereriOS : ButtonRenderer
	{
		public override void Draw(CGRect rect)
		{
			base.Draw(rect);

			if(Element != null)
			{
				if(Element is GradientButton)
				{
					var gradientLayer = new CAGradientLayer();
					var button = Element as GradientButton;
					gradientLayer.Frame = rect;
					gradientLayer.Colors = new CGColor[]
					{
						button.StartColor.ToCGColor(),
						button.EndColor.ToCGColor()
					};

					if (button.GradientOrientation == GradientButton.GradientOrientationStates.Vertical)
					{
						gradientLayer.StartPoint = new CGPoint(0.0, 0.5);
						gradientLayer.EndPoint = new CGPoint(1.0, 0.5);
					}
					else if (button.GradientOrientation == GradientButton.GradientOrientationStates.Horizontal)
					{
						gradientLayer.StartPoint = new CGPoint(0.0, 0.5);
						gradientLayer.EndPoint = new CGPoint(1.0, 0.5);
						//gradientLayer.StartPoint = new CGPoint(0.5, 0.0);
						//gradientLayer.EndPoint = new CGPoint(0.5, 1.0);
					}

					gradientLayer.CornerRadius = button.CornerRadius * 5;

					NativeView.Layer.InsertSublayer(gradientLayer, 0);
				}
			}
		}
	}
}