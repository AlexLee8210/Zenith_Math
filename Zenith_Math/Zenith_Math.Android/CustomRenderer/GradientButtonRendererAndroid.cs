using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Zenith_Math.CustomElements;
using Zenith_Math.Droid.CustomRenderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(GradientButton), typeof(GradientButtonRendererAndroid))]
namespace Zenith_Math.Droid.CustomRenderer
{
	public class GradientButtonRendererAndroid : ButtonRenderer
	{
		private GradientDrawable _gradient;

		public GradientButtonRendererAndroid(Context context) : base(context) { }

		protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
		{
			base.OnElementChanged(e);
			#region FadeAnim
			//if (e.OldElement != null || Element == null)
			//{
			//	Control.Touch -= ButtonTouched;
			//}
			
			if (Control != null)
			{
				try
				{
				//	Control.Touch += ButtonTouched;
				//	Control.StateListAnimator = new Android.Animation.StateListAnimator();
					Control.SetBackground(DrawGradient(e));
				} catch (Exception ex) { }

			}
			#endregion
		}
		private void ButtonTouched(object Sender, TouchEventArgs e)
		{
			e.Handled = false;
			if(e.Event.Action == MotionEventActions.Down)
			{
				_gradient.Alpha = 200;
				Control.SetBackground(_gradient);
			}
			else if(e.Event.Action == MotionEventActions.Up/* || e.Event.Action == MotionEventActions.ButtonRelease*/)
			{
				_gradient.Alpha = 255;
				Control.SetBackground(_gradient);
			}
		}
		private GradientDrawable DrawGradient(ElementChangedEventArgs<Xamarin.Forms.Button> e)
		{
			var button = e.NewElement as GradientButton;
			var orientation = button.GradientOrientation == GradientButton.GradientOrientationStates.Horizontal ?
				GradientDrawable.Orientation.LeftRight : GradientDrawable.Orientation.TopBottom;

			_gradient = new GradientDrawable(orientation, new[]
			{
				button.StartColor.ToAndroid().ToArgb(),
				button.EndColor.ToAndroid().ToArgb()
			});

			//_gradient.SetCornerRadius(button.CornerRadius * 10);
			_gradient.SetCornerRadius(120);
			_gradient.SetStroke(0, button.StartColor.ToAndroid());

			return _gradient;
		}
	}
}