using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Zenith_Math
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class QuestionPage : ContentPage
	{
		private string mode, startTime;
		private int hour, min, sec;
		private ProblemGenerator generator;
		private double answer;
		private int numCorrect, problemNum;
		private string timerString;
		private bool isBackwards;
		private bool TextWasChanged;
		public QuestionPage(string mode, string diff, int min = 0)
		{
			TextWasChanged = false;
			InitializeComponent();
			hour = 0;
			this.min = min;
			sec = 0;
			if (mode.Equals("timed"))
			{
				timer.Text = string.Format("{0}:{1}", min.ToString(), sec.ToString().PadLeft(2, '0'));
				startTime = timer.Text;
			}
			else
			{
				timer.Text = string.Format("{0}:{1}:{2}", hour.ToString(), min.ToString().PadLeft(2, '0'),
					sec.ToString().PadLeft(2, '0'));
			}

			this.mode = mode;
			problemNum = 0;
			generator = new ProblemGenerator(diff);

			numCorrect = 0;
			problemNum = 1;
			//generating first problem
			Tuple<string, double> prob = generator.GenerateProblem();
			problemView.Text = prob.Item1; //generate problem
			answer = prob.Item2;
			StartTimer();
		}

		private void StartTimer()
		{
			Device.StartTimer(TimeSpan.FromSeconds(1), () =>
			{
				if (mode.Equals("timed"))
				{
					CountDown();
					timerString = string.Format("{0}:{1}", min.ToString(), sec.ToString().PadLeft(2, '0'));
				}
				else
				{
					CountUp();
					timerString = string.Format("{0}:{1}:{2}", hour.ToString(), min.ToString().PadLeft(2, '0'),
						sec.ToString().PadLeft(2, '0'));
				}


				timer.Text = timerString;
				if (mode.Equals("timed"))
				{
					if (min == 0 && sec == 0)
					{
						Stop();
						return false;
					}
				}
				return true;
			});
		}

		private void Stop()
		{
			if (mode.Equals("timed"))
				timerString = startTime;
			App.Current.MainPage = new ResultsPage(mode, problemNum - 1, numCorrect, timerString);
		}

		private void CountDown()
		{
			if (sec == 0 && min > 0)
			{
				min--;
				sec = 59;
			}
			else if (min == 0 && sec == 0)
			{
				return;
			}
			else
			{
				sec--;
			}
		}

		private void CountUp()
		{
			if (sec == 59)
			{
				min++;
				sec = 0;
				if (min == 60)
				{
					min = 0;
					hour++;
				}
			}
			else
			{
				sec++;
			}
		}

		public void NextProblem(System.Object sender, EventArgs e)
		{
			string playerAns = problemEntry.Text;
			problemEntry.Text = "";
			problemNum++;

			double playerAnsDouble = 0.0;
			if (double.TryParse(playerAns, out playerAnsDouble))
			{
				if (playerAnsDouble == answer)
				{
					numCorrect++;
				}
				else if (mode.Equals("streak"))
				{
					Stop();
				}
			}
			else if (mode.Equals("streak"))
			{
				Stop();
			}
			problemNumLabel.Text = $"Problem: {problemNum}";
			Tuple<string, double> prob = generator.GenerateProblem();
			problemView.Text = prob.Item1; //generate problem
			answer = prob.Item2;
		}
		public void TypeBackwards(object sender, EventArgs e)
		{
			Switch backSwitch = (Switch)sender;
			isBackwards = backSwitch.IsToggled;
			if (isBackwards)
				problemEntry.CursorPosition = 0;
			/*else
				problemEntry.CursorPosition = problemEntry.Text.Length;*/
		}

		public void ProblemTextChanged(object sender, TextChangedEventArgs e)
		{
			if (isBackwards)
			{
				int pEntryLength = problemEntry.Text.Length;
				bool isAdding = e.OldTextValue.Length < e.NewTextValue.Length;
				if (isAdding)
				{
					problemEntry.CursorPosition = pEntryLength - 1;
				}
				else
				{
					problemEntry.CursorPosition = pEntryLength == 0 ? 0 : pEntryLength - 1;
				}

			}
		}
	}
}