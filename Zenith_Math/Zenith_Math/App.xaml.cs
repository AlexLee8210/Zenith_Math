using Zenith_Math.Toolbar;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Zenith_Math
{
	public partial class App : Application
	{
		public static String FilePath;
		public static SettingsPage Settings;

		//public App()
		//{
		//	InitializeComponent();

		//	MainPage = new StartAnimPage();
		//}

		public App(string filePath)
		{
			InitializeComponent();

			MainPage = new StartAnimPage();
			FilePath = filePath;
			Settings = new SettingsPage();
		}

		protected override void OnStart()
		{

		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}