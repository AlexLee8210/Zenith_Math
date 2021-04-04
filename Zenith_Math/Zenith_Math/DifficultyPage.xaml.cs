using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Zenith_Math.CustomElements;

namespace Zenith_Math
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DifficultyPage : ContentPage
    {
        private string mode;
        private int time;

        public DifficultyPage(string mode, int time = 0)
        {
            InitializeComponent();
            
            this.mode = mode;
            this.time = time;
        }

        public void ButtonClicked(System.Object sender, System.EventArgs e)
        {
            Button b = (Button)sender;
            string type = b.Text.ToLower();

            if (type.Equals("back"))
            {
                Application.Current.MainPage.Navigation.PopAsync();
            }
            else
            {
                Application.Current.MainPage = new QuestionStartAnim(mode, type, time);
            }
        }

        public async void QuestionClicked(System.Object sender, System.EventArgs e)
        {
            await DisplayAlert("Difficulties:", "- Beginner: Elementary level Math\n" +
                                                "- Novice: Elementary Mental Math\n" +
                                                "- Intermediate: Junior High Mental Math\n" +
                                                "- Advanced: High School Mental Math", "Okay");
        }
    }
}