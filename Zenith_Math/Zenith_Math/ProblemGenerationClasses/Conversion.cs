using System;
using System.Collections.Generic;
using System.Text;

namespace Zenith_Math.ProblemGenerationClasses
{
	class Conversion : ProblemGeneration
	{
		public Conversion()
		{
			MakeDiffList(this.GetType(), "Conversion", this);
		}
		// Convert from miles to feet
		public Tuple<string, double> P7015()
		{
			int MAX_MILES = 10;
			if (novice)
				MAX_MILES = 10;
			else if (intermediate)
				MAX_MILES = 15;
			else if (advanced)
				MAX_MILES = 20;
			bool miles_to_feet = (random.Next(0, 2) == 0);
			int num_miles = random.Next(2, MAX_MILES + 1);
			int num_feet = num_miles * 5280;
			if (miles_to_feet)
				return Tuple.Create($"{num_miles} mi = ______ ft", (double)num_feet);
			return Tuple.Create($"{num_feet} ft = ______ mi", (double)num_miles);
		}

		// Convert from miles to yards
		public Tuple<string, double> P7016()
		{
			int MAX_MILES = 9;
			if (novice)
				MAX_MILES = 9;
			else if (intermediate)
				MAX_MILES = 9;
			else if (advanced)
				MAX_MILES = 15;
			bool miles_to_yards = (random.Next(0, 2) == 0);
			int num_miles = random.Next(2, MAX_MILES + 1);
			int num_yards = num_miles * 1760;
			if (miles_to_yards)
				return Tuple.Create($"{num_miles} mi = ______ yd", (double)num_yards);
			return Tuple.Create($"{num_yards} yd = ______ mi", (double)num_miles);
		}

		// Convert from in^2 to ft^2
		public Tuple<string, double> P7018()
		{
			int MAX_FT_2 = 9;
			if (novice)
				MAX_FT_2 = 9;
			else if (intermediate)
				MAX_FT_2 = 99;
			else if (advanced)
				MAX_FT_2 = 99;
			bool ft_to_in = (random.Next(0, 2) == 0);
			int num_ft = random.Next(2, MAX_FT_2 + 1);
			int num_in = num_ft * 144;
			if (ft_to_in)
				return Tuple.Create($"{num_ft} ft = ______ in", (double)num_in);
			return Tuple.Create($"{num_in} in = ______ ft", (double)num_ft);
		}

		// Convert from yards to inches
		public Tuple<string, double> P7019()
		{
			int MAX_YARDS = 9;
			if (novice)
				MAX_YARDS = 9;
			else if (intermediate)
				MAX_YARDS = 99;
			else if (advanced)
				MAX_YARDS = 99;
			bool yards_to_inches = (random.Next(0, 2) == 0);
			int num_yards = random.Next(2, MAX_YARDS + 1);
			int num_inches = num_yards * 36;
			if (yards_to_inches)
				return Tuple.Create($"{num_yards} yd = ______ in", (double)num_inches);
			return Tuple.Create($"{num_inches} in = ______ yd", (double)num_yards);
		}

		// Convert from gross to numbers
		public Tuple<string, double> P7021()
		{
			int MAX_GROSS = 5;
			if (novice)
				MAX_GROSS = 9;
			else if (intermediate)
				MAX_GROSS = 20;
			else if (advanced)
				MAX_GROSS = 50;
			bool gross_to_num = (random.Next(0, 2) == 0);
			int num_gross = random.Next(2, MAX_GROSS + 1);
			int num = num_gross * 144;
			if (gross_to_num)
				return Tuple.Create($"{num_gross} gross = ______", (double)num);
			return Tuple.Create($"{num} = ______ gross", (double)num_gross);
		}

		// Convert from ounces to quarts
		public Tuple<string, double> P7022()
		{
			int MAX_QUARTS = 5;
			if (novice)
				MAX_QUARTS = 9;
			else if (intermediate)
				MAX_QUARTS = 50;
			else if (advanced)
				MAX_QUARTS = 99;
			bool quarts_to_oz = (random.Next(0, 2) == 0);
			int num_quarts = random.Next(2, MAX_QUARTS + 1);
			int num_oz = num_quarts * 32;
			if (quarts_to_oz)
				return Tuple.Create($"{num_quarts} quarts = ______ oz", (double)num_oz);
			return Tuple.Create($"{num_oz} oz = ______ quarts", (double)num_quarts);
		}

	}
}
