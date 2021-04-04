using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace Zenith_Math.Toolbar
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SettingsPage : ContentPage
	{
		

		public SettingsPage()
		{
			InitializeComponent();

		}

		public void BackBtnClicked(object sender, EventArgs e)
		{
			Application.Current.MainPage.Navigation.PopAsync();
		}
	}
}