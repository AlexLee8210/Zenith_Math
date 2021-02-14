using Zenith_Math.UserData;
using SQLite;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Zenith_Math
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ResultsPage : ContentPage
	{
		public ResultsPage(string mode, int numAnswered, int numCorrect, string time = "0:00.00")
		{
			InitializeComponent();
			numAnsweredLabel.Text += numAnswered;
			correctLabel.Text += numCorrect;
			timeLabel.Text += time;
			RecordData record = new RecordData()
			{
				Mode = mode,
				Answered = numAnswered,
				Correct = numCorrect,
				Time = time
			};
			using (SQLiteConnection conn = new SQLiteConnection(App.FilePath))
			{
				conn.CreateTable<RecordData>();
				int num = conn.Insert(record);
			}
		}
		public void HomeButtonClick(System.Object sender, System.EventArgs e)
		{
			App.Current.MainPage = new NavigationPage(new MainPage());
		}
	}
}