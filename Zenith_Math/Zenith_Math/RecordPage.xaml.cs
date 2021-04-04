using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zenith_Math.UserData;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Zenith_Math
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RecordPage : ContentPage
	{
		public RecordPage()
		{
			InitializeComponent();

			using (SQLiteConnection conn = new SQLiteConnection(App.FilePath))
			{
				conn.CreateTable<RecordData>();
				var records = conn.Table<RecordData>().ToList();
				records.Sort();

				int i = 0;
				while(records.Count - 1 >= i && records[i].Difficulty.Equals("beginner"))
				{
					AddRecord(records[i], BeginnerLayout);
					i++;
				}
				while (records.Count - 1 >= i && records[i].Difficulty.Equals("novice"))
				{
					AddRecord(records[i], NoviceLayout);
					i++;
				}
				while (records.Count - 1 >= i && records[i].Difficulty.Equals("intermediate"))
				{
					AddRecord(records[i], IntermediateLayout);
					i++;
				}
				while (records.Count - 1 >= i && records[i].Difficulty.Equals("advanced"))
				{
					AddRecord(records[i], AdvancedLayout);
					i++;
				}
			}
		}

		private void AddRecord(RecordData record, StackLayout diffLayout)
		{
			Label modeLabel = new Label
			{
				Text = record.Mode.Substring(0, 1).ToUpper() + record.Mode.Substring(1),
				Style = (Style)Application.Current.Resources["RecordStyle"],
				FontSize = 24
			};
			Label ansLabel = new Label
			{
				Text = $"   Questions Answered: {record.Answered}",
				Style = (Style)Application.Current.Resources["RecordStyle"]
			};
			Label corrLabel = new Label
			{
				Text = $"   Questions Answered Correctly: {record.Correct}",
				Style = (Style)Application.Current.Resources["RecordStyle"]
			};
			Label timeLabel = new Label
			{
				Text = $"   Time: {record.Time}",
				Style = (Style)Application.Current.Resources["RecordStyle"]
			};
			diffLayout.Children.Add(modeLabel);
			diffLayout.Children.Add(ansLabel);
			diffLayout.Children.Add(corrLabel);
			diffLayout.Children.Add(timeLabel);
		}

		public void BackButtonClicked(System.Object sender, System.EventArgs e)
		{
			Application.Current.MainPage.Navigation.PopAsync();
		}
	}
}