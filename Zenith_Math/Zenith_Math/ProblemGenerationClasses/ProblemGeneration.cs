using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Text;
using System.IO;

namespace Zenith_Math.ProblemGenerationClasses
{
	public class ProblemGeneration
	{
		protected static Dictionary<ProblemGeneration, List<MethodInfo>> beginnerDict = new Dictionary<ProblemGeneration, List<MethodInfo>>();
		protected static Dictionary<ProblemGeneration, List<MethodInfo>> noviceDict = new Dictionary<ProblemGeneration, List<MethodInfo>>();
		protected static Dictionary<ProblemGeneration, List<MethodInfo>> intermediateDict = new Dictionary<ProblemGeneration, List<MethodInfo>>();
		protected static Dictionary<ProblemGeneration, List<MethodInfo>> advancedDict = new Dictionary<ProblemGeneration, List<MethodInfo>>();

		protected static Dictionary<ProblemGeneration, List<MethodInfo>> currentDict;

		protected static Random random = new Random();
		protected static string diff = "";
		protected static bool beginner, novice, intermediate, advanced;
		private static Arithmetic arithmetic = new Arithmetic();
		private static Algebra algebra = new Algebra();
		private static Conversion conversion = new Conversion();

		private int numMethods = 0;
		//ProbGenerators
		public ProblemGeneration()
		{

		}
		public ProblemGeneration(string diff)
		{
			SetDiff(diff);
		}
		public Dictionary<ProblemGeneration, List<MethodInfo>> GetBeginnerDict()
		{
			return beginnerDict;
		}
		public Tuple<string, double> GenerateProblem(bool typeBased = false)
		{
			//if(typeBased)
			//{

			//}
			//else
			//{

			//}
			int index = random.Next(0, currentDict.Count);
			ProblemGeneration key = currentDict.Keys.ElementAt(index);
			List<MethodInfo> methodList = currentDict[key];
			MethodInfo method = methodList[random.Next(0, methodList.Count)];

			return (Tuple<string, double>)method.Invoke(key, null);
		}
		public void SetDiff(string d)
		{
			diff = d;
			beginner = diff.Equals("beginner");
			novice = diff.Equals("novice");
			intermediate = diff.Equals("intermediate");
			advanced = diff.Equals("advanced");
			switch (diff)
			{
				case "beginner":
					currentDict = beginnerDict;
					break;
				case "novice":
					currentDict = noviceDict;
					break;
				case "intermediate":
					currentDict = intermediateDict;
					break;
				case "advanced":
					currentDict = advancedDict;
					break;
			}
		}
		protected void MakeDiffList(Type thisType, string type, ProblemGeneration probClass)
		{
			List<MethodInfo>[] lists = new List<MethodInfo>[4];
			for (int i = 0; i < 4; i++)
			{
				lists[i] = new List<MethodInfo>();
			}

			var assembly = IntrospectionExtensions.GetTypeInfo(typeof(MainPage)).Assembly;
			Stream stream = assembly.GetManifestResourceStream("Zenith_Math.Resources.nsCSV.csv");
			using (StreamReader reader = new System.IO.StreamReader(stream))
			{
				bool read = false;
				reader.ReadLine();
				while(!reader.EndOfStream)
				{
					string line = reader.ReadLine();
					string[] values = line.Split(',');
					Console.WriteLine(line);
					if (values[0].Equals(type))
					{
						Console.WriteLine("EQUALS");
						if (!read)
							read = true;
						for (int i = 2; i < values.Length; i++)
						{
							string val = values[i];
							if (val.Length > 1)
							{
								lists[i - 2].Add(thisType.GetMethod("P" + values[1]));
							}
						}
					}
					else
					{
						if (read)
							break;
					}
				}
				reader.Close();
				beginnerDict.Add(probClass, lists[0]);
				noviceDict.Add(probClass, lists[1]);
				intermediateDict.Add(probClass, lists[2]);
				advancedDict.Add(probClass, lists[3]);
			}
		}
	}
}
