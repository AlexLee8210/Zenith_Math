using Xamarin.Forms;

namespace Zenith_Math.CustomElements
{
	public class GradientButton : Button
	{
		public enum GradientOrientationStates
		{
			Vertical,
			Horizontal
		}

		#region bindable
		public static readonly BindableProperty StartColorProperty =
			BindableProperty.Create(
				nameof(StartColor),
				typeof(Color),
				typeof(GradientButton),
				default(Color));
		public static readonly BindableProperty EndColorProperty =
			BindableProperty.Create(
				nameof(EndColor),
				typeof(Color),
				typeof(GradientButton),
				default(Color));
		public static readonly BindableProperty GradientOrientationProperty =
			BindableProperty.Create(
				nameof(GradientOrientation),
				typeof(GradientOrientationStates),
				typeof(GradientButton),
				default(GradientOrientationStates));
		#endregion

		public Color StartColor
		{
			get => (Color)GetValue(StartColorProperty);
			set => SetValue(StartColorProperty, value);
		}
		public Color EndColor
		{
			get => (Color)GetValue(EndColorProperty);
			set => SetValue(EndColorProperty, value);
		}
		public GradientOrientationStates GradientOrientation
		{
			get => (GradientOrientationStates)GetValue(GradientOrientationProperty);
			set => SetValue(GradientOrientationProperty, value);
		}
	}
}