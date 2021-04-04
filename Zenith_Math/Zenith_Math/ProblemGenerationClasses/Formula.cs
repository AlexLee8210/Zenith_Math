using System;
using System.Collections.Generic;
using System.Text;

namespace Zenith_Math.ProblemGenerationClasses
{
	class Formula : ProblemGeneration
	{
		public Formula()
		{
			MakeDiffList(this.GetType(), "Formula", this);
		}

		public Tuple<string, double> p10001() {
			return Tuple.Create("Formula", 1.0);
		}
	}
}
