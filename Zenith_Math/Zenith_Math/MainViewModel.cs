using System.ComponentModel;
using Xamarin.Essentials;

namespace Zenith_Math
{
	public class MainViewModel : INotifyPropertyChanged
	{
		public bool IsDark
		{
			get => Preferences.Get(nameof(IsDark), false);
			set
			{
				Preferences.Set(nameof(IsDark), value);
				OnPropertyChanged(nameof(IsDark));
				return;
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;
		void OnPropertyChanged(string name)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
	}
}