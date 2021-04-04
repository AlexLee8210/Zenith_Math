using Zenith_Math.UserData;
using SQLite;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using System;

namespace Zenith_Math
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ResultsPage : ContentPage
	{
		public ResultsPage(string mode, int numAnswered, int numCorrect, string difficulty, string time = "0:00.00")
		{
			InitializeComponent();
			difficultyLabel.TextColor = Color.White;
			numAnsweredLabel.TextColor = Color.White;
			correctLabel.TextColor = Color.White;
			timeLabel.TextColor = Color.White;

			difficultyLabel.Text += difficulty.Substring(0, 1).ToUpper() + difficulty.Substring(1);
			numAnsweredLabel.Text += numAnswered;
			correctLabel.Text += numCorrect;
			if (time == null)
				time = "0:00";
			timeLabel.Text += time;

			string id = "";

			switch (mode)
			{
				case "timed":
					id = "1";
					switch (time)
					{
						case "1":
							id += "1";
							break;
						case "2":
							id += "2";
							break;
						case "5":
							id += "3";
							break;
						case "10":
							id += "4";
							break;
					}
					break;
				case "streak":
					id = "2";
					break;
				case "practice":
					id = "3";
					break;
			}
			switch (difficulty)
			{
				case "beginner":
					id += "1";
					break;
				case "novice":
					id += "2";
					break;
				case "intermediate":
					id += "3";
					break;
				case "advanced":
					id += "4";
					break;
			}
			RecordData record = new RecordData()
			{
				Id = id,
				Difficulty = difficulty,
				Mode = mode,
				Answered = numAnswered,
				Correct = numCorrect,
				Time = time
			};
			using (SQLiteConnection conn = new SQLiteConnection(App.FilePath))
			{
				conn.CreateTable<RecordData>();
				var records = conn.Table<RecordData>().ToList();

				bool recordExists = false;
				for (int i = records.Count-1; i >= 0 ; i--)
				{
					RecordData r = records[i];
					if (record.Id == r.Id) { 
						recordExists = true;
						if(record.Compare(r) > 0)
							conn.InsertOrReplace(record);
					}
				}
				if (!recordExists)
				{
					conn.InsertOrReplace(record);
				}
			}
		}
		public void HomeButtonClick(System.Object sender, System.EventArgs e)
		{
			Application.Current.MainPage = new NavigationPage(new MainPage());
		}
	}
}