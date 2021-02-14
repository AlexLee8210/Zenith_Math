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
				if (records.Count > 0)
				{
					foreach (RecordData record in records)
					{
						Label modeLabel = new Label
						{
							Text = record.Mode.Substring(0, 1).ToUpper() + record.Mode.Substring(1),
							Style = (Style)Application.Current.Resources["RecordStyle"],
							FontSize = 24,
							FontFamily = "{ StaticResource LatoFont }"
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
						RecordLayout.Children.Add(modeLabel);
						RecordLayout.Children.Add(ansLabel);
						RecordLayout.Children.Add(corrLabel);
						RecordLayout.Children.Add(timeLabel);
					}
				}
				else
				{
					Label l = new Label
					{
						Text = "None",
						Style = (Style)Application.Current.Resources["RecordStyle"]
					};
					RecordLayout.Children.Add(l);
				}
			}
		}
	}
}