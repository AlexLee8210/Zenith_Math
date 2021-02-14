using System;
using System.Collections.Generic;
using System.Text;

namespace Zenith_Math.ProblemGenerationClasses
{
	public class Algebra : ProblemGeneration
	{
		public Algebra()
		{
			MakeDiffList(this.GetType(), "Algebra", this);
		}
		//Alex's code for P1001 (Yu's is probably better)
/*        public Tuple<string, double> P1001() //Smallest/Largest root of (ax+b)^2=c^2, b, n,
        {
            int s = random.Next(0, 2);
            int max = 10;
            //For novice, it can multiply by 1000
            if (novice)
                max = 4;
            int a = (int)Math.Pow(10, random.Next(1, max));
            int b = random.Next(1, 1000);
            int order = random.Next(0, 2);
            string str = "What is the ";
            //Determines order for variation
            switch (order)
            {
                case 0:
                    str = $"{a} × {b} = ";
                    break;
                case 1:
                    str = $"{b} × {a} = ";
                    break;
            }
            double res = a * b;
            return Tuple.Create(str, res);
        }*/
		public Tuple<string, double> P1001()
		{
			int a = random.Next(1, 11);
			int c = random.Next(1, 11);
			int b = random.Next(-10, 11);
			bool smallest = random.Next(0, 2) == 0;
			int min = Math.Min((-c - b) / a, (c - b) / a);
			int max = Math.Max((-c - b) / a, (c - b) / a);
			if (smallest)
				return Tuple.Create($"Smallest root of ({a}x+{b})^2 = {c}^2", (double)min);
			return Tuple.Create($"Largest root of ({a}x+{b})^2 = {c}^2", (double)max);
		}

		// (ax+b)^2=c^2
		public Tuple<string, double> P1002()
		{
			int a = random.Next(1, 11);
			int c = random.Next(1, 11);
			int b = random.Next(-10, 11);
			bool smallest = random.Next(0, 2) == 0;
			int min = Math.Min((-c - b) / a, (c - b) / a);
			int max = Math.Max((-c - b) / a, (c - b) / a);
			if (smallest)
				return Tuple.Create($"Smallest root of ({a}x+{b})^2 = {c}^2", (double)min);
			return Tuple.Create($"Largest root of ({a}x+{b})^2 = {c}^2", (double)max);
		}

	}
}
