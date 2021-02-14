using System;
using System.Collections.Generic;
using System.Text;

namespace Zenith_Math.ProblemGenerationClasses
{
	class ComplexNumbers : ProblemGeneration
	{
		Random random = new Random();
		private List<Func<Tuple<string, double>>> methods;
		private string diff;
		private bool beginner, novice, intermediate, advanced;

		private void GenBools()
		{
			beginner = diff.Equals("beginner");
			novice = diff.Equals("novice");
			intermediate = diff.Equals("intermediate");
			advanced = diff.Equals("advanced");
		}
		public Tuple<string, double> GenerateProblem()
		{
			int numMethods = methods.Count;

			int method = random.Next(0, numMethods);
			Tuple<string, double> problem = methods[method].Invoke();
			return problem;
		}
		public void SetDiff(string diff) => this.diff = diff;
	}
}
