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
using Zenith_Math.Droid.CustomRenderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Zenith_Math.CustomElements;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRendererAndroid))]
namespace Zenith_Math.Droid.CustomRenderer
{
	public class CustomEntryRendererAndroid : EntryRenderer
	{
		public CustomEntryRendererAndroid(Context context): base(context) { }
		protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged(e);

			if(e.OldElement == null)
			{
				var gradientDrawable = new GradientDrawable();
				gradientDrawable.SetCornerRadius(60f);
				gradientDrawable.SetStroke(5, Color.FromHex("#002a6c").ToAndroid());
				gradientDrawable.SetColor(Android.Graphics.Color.White);
				IntPtr IntPtrtextViewClass = JNIEnv.FindClass(typeof(TextView));
				IntPtr mCursorDrawableResProperty = JNIEnv.GetFieldID(IntPtrtextViewClass, "mCursorDrawableRes", "I");
				JNIEnv.SetField(Control.Handle, mCursorDrawableResProperty, Resource.Drawable.my_cursor);
				Control.SetBackground(gradientDrawable);

				Control.SetPadding(50, Control.PaddingTop, Control.PaddingRight, Control.PaddingBottom);
			}
		}
	}
}