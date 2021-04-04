using System;
using System.Collections.Generic;
using System.Text;
using Zenith_Math.ProblemGenerationClasses;

namespace Zenith_Math
{
	class ProblemGenerator
	{
		private static ProblemGeneration pg = new ProblemGeneration();
		public ProblemGenerator(string diff)
		{
			SetDiff(diff);
		}
		public ProblemGeneration GetProblemGeneration()
		{
			return pg;
		}
		public void SetDiff(string diff)
		{
			pg.SetDiff(diff);
		}
		public Tuple<string, double> GenerateProblem()
		{
			return pg.GenerateProblem();
		}
	}
}