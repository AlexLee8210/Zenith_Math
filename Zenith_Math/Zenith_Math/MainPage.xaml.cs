using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Zenith_Math.Toolbar;

namespace Zenith_Math
{
	// Learn more about making custom code visible in the Xamarin.Forms previewer
	// by visiting https://aka.ms/xamarinforms-previewer
	[DesignTimeVisible(false)]
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
			//pg = new ProblemGenerator("beginner");
		}

		async void WIPMessage()
		{
			await DisplayAlert("Coming Soon!", "This feature is not available yet, but it will be soon!", "OK");
		}

		public void ButtonClicked(System.Object sender, System.EventArgs e)
		{
			string mode = (((Button)sender).Text).ToLower();
			if (mode.Equals("timed"))
				TimedButtonsGrid.IsVisible = !TimedButtonsGrid.IsVisible;
			else if (mode.Equals("practice") || mode.Equals("multiplayer"))
			{
				WIPMessage();
			}
			else
			{
				Application.Current.MainPage.Navigation.PushAsync(new DifficultyPage(mode));
			}
		}

		public void TimedButtonClicked(System.Object sender, System.EventArgs e)
		{
			string time = (((Button)sender).Text);
			time = time.Substring(0, time.IndexOf(':'));
			Application.Current.MainPage.Navigation.PushAsync(new DifficultyPage("timed", int.Parse(time)));
			TimedButtonsGrid.IsVisible = false;
		}

		public void TipsBtnClicked(System.Object sender, System.EventArgs e)
		{
			WIPMessage();
		}
		public void SettingsBtnClicked(System.Object sender, System.EventArgs e)
		{
			App.Current.MainPage.Navigation.PushAsync(App.Settings);
		}
		public void InfoBtnClicked(System.Object sender, System.EventArgs e)
		{
			WIPMessage();
		}

		public void RecordBtnClicked(object sender, System.EventArgs e)
		{
			Application.Current.MainPage.Navigation.PushAsync(new NavigationPage(new RecordPage()));
		}

	}
}