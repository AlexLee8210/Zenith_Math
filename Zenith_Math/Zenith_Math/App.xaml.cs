using Zenith_Math.Toolbar;
using Xamarin.Forms;
using SQLite;
using Zenith_Math.UserData;

namespace Zenith_Math
{
	public partial class App : Application
	{
		public static string FilePath;
		public static SettingsPage Settings;

		//public App()
		//{
		//	InitializeComponent();

		//	MainPage = new StartAnimPage();
		//}

		public App(string filePath)
		{
			InitializeComponent();


			MainPage = new NavigationPage(new StartAnimPage())
			{
				BarBackgroundColor = Color.FromHex("#171717"),
				BarTextColor = Color.White
			};
			
			FilePath = filePath;
			Settings = new SettingsPage();
		}
		
		protected override void OnStart()
		{
			using (SQLiteConnection conn = new SQLiteConnection(App.FilePath))
			{
				conn.DropTable<RecordData>();
			}
		}
		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}