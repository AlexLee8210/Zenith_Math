using System;
using System.Collections.Generic;
using System.Text;

namespace Zenith_Math.ProblemGenerationClasses
{
	class Memorization : ProblemGeneration
	{
		public Memorization()
		{
			MakeDiffList(this.GetType(), "Memorization", this);
		}

		// Units digit of x^n
		public Tuple<string, double> P11011()
		{
			int MIN_X = 0;
			int MAX_X = 0;
			int MIN_N = 0;
			int MAX_N = 0;
			if (novice)
			{
				MIN_X = 2;
				MAX_X = 10;
				MIN_N = 10;
				MAX_N = 100;
			}
			else if (intermediate)
			{
				MIN_X = 10;
				MAX_X = 100;
				MIN_N = 10;
				MAX_N = 100;
			}
			else if (advanced)
			{
				MIN_X = 100;
				MAX_X = 500;
				MIN_N = 1000;
				MAX_N = 2000;
			}
			int num_x = random.Next(MIN_X, MAX_X);
			int num_n = random.Next(MIN_N, MAX_N);
			int ans = 1;
			for (int i = 0; i < num_n; i++)
				ans = (ans * num_x) % 10;
			return Tuple.Create($"What is the unit's digit of {num_x}^{num_n}?", (double)ans);
		}
		// Square roots
		public Tuple<string, double> P11012()
		{
			int MIN_X = 0;
			int MAX_X = 0;
			if (novice)
			{
				MIN_X = 11;
				MAX_X = 51;
			}
			else if (intermediate)
			{
				MIN_X = 11;
				MAX_X = 101;
			}
			else if (advanced)
			{
				MIN_X = 50;
				MAX_X = 101;
			}
			int num = random.Next(MIN_X, MAX_X);
			int res = num * num;
			return Tuple.Create($"sqrt({res}) = ", (double)num);
		}
		// Cube roots
		public Tuple<string, double> P11013()
		{
			int MIN_X = 0;
			int MAX_X = 0;
			if (novice)
			{
				MIN_X = 11;
				MAX_X = 51;
			}
			else if (intermediate)
			{
				MIN_X = 11;
				MAX_X = 50;
			}
			else if (advanced)
			{
				MIN_X = 20;
				MAX_X = 100;
			}
			int num = random.Next(MIN_X, MAX_X);
			int res = num * num * num;
			return Tuple.Create($"cbrt({res}) = ", (double)num);
		}

	}
}
