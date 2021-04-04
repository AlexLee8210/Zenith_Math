using SQLite;
using System;
using System.Collections.Generic;

namespace Zenith_Math.UserData
{
	[Table("records")]
	public class RecordData : IComparable
	{
		private string _id;
		[PrimaryKey, Column("_id"), Unique]
		public string Id { get; set; }
		public string Difficulty { get; set; }
		public string Mode { get; set; }
		public int Answered { get; set; }
		public int Correct { get; set; }
		public string Time { get; set; }

		public int CompareTo(object obj) //FOR SORTING ONLY
		{
			RecordData r = obj as RecordData;
			if (r != null)
			{
				if (Difficulty.Equals(r.Difficulty))
				{
					return Mode.CompareTo(r.Mode);
				}
				else
				{
					Dictionary<string, int> dict = new Dictionary<string, int>();
					dict.Add("beginner", 0);
					dict.Add("novice", 1);
					dict.Add("intermediate", 2);
					dict.Add("advanced", 3);
					return dict[Difficulty] - dict[r.Difficulty];
				}
			}
			return 1;
		}
		
		public int Compare(object obj) //COMPARE METHOD TO DETERMINE WHICH "RUN" IS A RECORD, GREATER NUMBER = BETTER RECORD
		{
			RecordData r = obj as RecordData;
			if (r != null)
			{
				if (Difficulty.Equals(r.Difficulty))
				{
					if (Mode.Equals("streak"))
					{
						if (Correct - r.Correct == 0)
						{
							return r.Time.CompareTo(Time); //if r time > , then this.Time is the faster/better one
						}
						return Correct - r.Correct;
					}
					else if (Mode.Equals("timed"))
					{
						return Correct - r.Correct;
					}
					else
					{
						return 1;
					}
				}
				else
				{
					Dictionary<string, int> dict = new Dictionary<string, int>();
					dict.Add("beginner", 0);
					dict.Add("novice", 1);
					dict.Add("intermediate", 2);
					dict.Add("advanced", 3);
					return dict[Difficulty] - dict[r.Difficulty];
				}
			}
			return 1;
		}
	}
}