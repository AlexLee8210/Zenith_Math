using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Zenith_Math
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartAnimPage : ContentPage
    {
        public StartAnimPage()
        {
            InitializeComponent();
            //Toolbar.SettingsPage temp = new Toolbar.SettingsPage();
            StartUp();
        }
        async void StartUp()
        {
            await Zenith_MathTitle.FadeTo(1.0, 1500);
            await Task.Delay(1750);
            await Zenith_MathTitle.FadeTo(0, 1000);

            MainStackLayout.Children.Remove(Zenith_MathTitle);
            await Task.Delay(100);
            MainPage mp = new MainPage();
            Application.Current.MainPage = new NavigationPage(mp);

        }
    }
}