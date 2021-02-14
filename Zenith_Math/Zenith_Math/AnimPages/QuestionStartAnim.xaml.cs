using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Zenith_Math
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class QuestionStartAnim : ContentPage
	{
		public QuestionStartAnim(string mode, string diff, int time)
		{
			InitializeComponent();
			StartAnim(mode, diff, time);
		}

		async void StartAnim(string mode, string diff, int time)
		{
			await countdownAnimLayout.FadeTo(1, 100);
			await Task.Delay(900);
			countdown.Opacity = 0;
			countdown.Text = "2";
			await countdown.FadeTo(1, 100);
			await Task.Delay(900);
			countdown.Opacity = 0;
			countdown.Text = "1";
			await countdown.FadeTo(1, 100);
			await Task.Delay(900);
			App.Current.MainPage = new QuestionPage(mode, diff, time);
		}
	}
}