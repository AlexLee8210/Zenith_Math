using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Zenith_Math.ProblemGenerationClasses
{
	public class Arithmetic : ProblemGeneration
	{
		public Arithmetic()
		{
			MakeDiffList(this.GetType(), "Arithmetic", this);
		}
		public Tuple<string, double> P2001() //Multiplying by powers of 10, b, n,
		{
			int max = 3;
			//For novice, it can multiply by 1000
			if (novice)
				max = 4;
			int a = (int)Math.Pow(10, random.Next(1, max));
			int b = random.Next(1, 1000);
			int order = random.Next(0, 2);
			string str = "";
			//Determines order for variation
			switch (order)
			{
				case 0:
					str = $"{a} × {b}";
					break;
				case 1:
					str = $"{b} × {a}";
					break;
			}
			double res = a * b;
			return Tuple.Create(str, res);
		}
		public Tuple<string, double> P2002()//Addition up to 12+12, b
		{
			int a = random.Next(1, 13);
			int b = random.Next(1, 13);
			double res = a + b;

			return Tuple.Create($"{a} + {b}", res);
		}
		public Tuple<string, double> P2003() //Division up to 144 ÷ 12, b
        {
			//lol chris made this so if it succeeds its his achievement
            int a = random.Next(1, 13);
            int b = random.Next(1, 13);
            int res = a  *  b;
            return Tuple.Create($"{res} ÷ {a}", (double)(b));
        }
		public Tuple<string, double> P2004()//Subtraction up to 12 and 12, b
		{
			int a = random.Next(1, 13);
			int b = random.Next(1, 13);

			return Tuple.Create($"{a+b} - {a}", (double)(b));
		}
		public Tuple<string, double> P2005()//Multiplication up to 12 x 12, b 
		{
			int a = random.Next(1, 13);
			int b = random.Next(1, 13);
			return Tuple.Create($"{a} × {b}", (double)(a * b));
		}
		public Tuple<string, double> P2006() //2 by 2 digit addition, b, n, i
		{
			int a, b, max1, max2;
			if (beginner) //changed it so it uses max, much more efficient
			{
				a = random.Next(1, 9);
				max1 = 10 - a;
				a *= 10;
				max2 = random.Next(0, 10);
				a += max2;
				max2 = 10 - max2;

				b = random.Next(1, max1) * 10;
				b += random.Next(0, max2);

				return Tuple.Create($"{a} + {b}", (double)a + b);
			}
			else
			{
				a = random.Next(10, 100);
				b = random.Next(10, 100);
				return Tuple.Create($"{a} + {b}", (double)a + b);
			}
		}
		public Tuple<string, double> P2007() //2 by 2 digit subtraction, b, n, i
		{
			int a, b, max1, max2, neg;
			if (beginner) //no carrying
			{
				//generates 10's place
				a = random.Next(1, 9);
				max1 = 10 - a;
				a *= 10;

				//generates 1's place
				max2 = random.Next(1, 9);
				a += max2;
				max2 = 10 - max2;

				b = random.Next(1, max1) * 10;
				b += random.Next(1, max2);

				return Tuple.Create($"{a + b} - {a}", (double)b);
			}
			else
			{
				a = random.Next(10, 90);
				max1 = 100 - a;	//so its always 2 digits
				b = random.Next(10, max1); 
				if(diff.Equals("intermediate"))
				{
					neg = random.Next(0, 2) == 0 ? -1 : 1;
					b *= -1;
				}
				return Tuple.Create($"{a+b} - {a}", (double)b);
			}
		}
        public Tuple<string, double> P2008() //3 by 1 digit addition, b, n
        {
            int a, b; 
			int res=0;
            if (beginner)
            {
                
				res = random.Next(100, 1000);
				//Let's make sure the ones digit isn't 0
                a = random.Next(1,10);
				res = res - (res  %  10)+a;
				//Now res won't end in 0
				a = random.Next(1,a+1);
				b = res - a;
				// b is a three digit number that may end in 0, but a will not end

                int order = random.Next(0, 2);
                string str = "";
                //Determines order for variation
                switch (order)
                {
                    case 0:
                        str = $"{a} + {b}";
                        break;
                    case 1:
                        str = $"{b} + {a}";
                        break;
                }
                return Tuple.Create(str, (double)res);
            }
            else
            {
                a = random.Next(100, 1000);
                b = random.Next(1, 10);
                return Tuple.Create($"{a} + {b}", (double)a + b);
            }
        }
		public Tuple<string, double> P2009() //3 by 1 digit division, b, n, i
		{
			if (beginner)
			{
				int a = random.Next(1, 6);
				//to reduce the chance that its just 1 xd
				if (a == 1)
					a = random.Next(1, 6);
				if (a == 5) //to reduce the chance that its just 5, 6, 7, 8, or 9 
				{
					a = random.Next(5, 10);
					//converting to binary cuz it can only be 100, 101, 110, or 111 lol
					int b = random.Next(4, 8);
					string binary = Convert.ToString(b, 2);

					b = int.Parse(binary);

					return Tuple.Create($"{b * a} ÷ {a}", (double)b);
				}
				else
				{
					int max = (int)Math.Ceiling(10.0 / a);
					int b = 0, num = 0;
					for (int i = 2; i >= 0; i--)
					{
						num = random.Next(1, max);
						num *= (int)Math.Pow(10, i);
						b += num;
					}
					return Tuple.Create($"{b * a} ÷ {a}", (double)b);
				}
			}
			else
			{
				int res = random.Next(100, 1000);
				int a = random.Next(1, 10);
				int b = res / a;
				if (b < 100) // in case res/a is < 100
					b++;
				res = a * b;
				return Tuple.Create($"{res} ÷ {a}", (double)b);
			}
		}
		public Tuple<string, double> P2010() //3 by 1 digit multiplication, b, n, i
		{
			int a, b, order;
			string str;
			if(beginner)
			{
				a = random.Next(1, 6);
				if (a == 1)
					a = random.Next(1, 6);
				if (a == 5) 
				{
					a = random.Next(5, 10);
					//converting to binary cuz it can only be 100 <- already in 2001, 101, 110, or 111 lol
					b = random.Next(5, 8);
					string binary = Convert.ToString(b, 2);
					b = int.Parse(binary);

					order = random.Next(0, 2);
					str = "";
					//Determines order for variation
					switch (order)
					{
						case 0:
							str = $"{a} × {b}";
							break;
						case 1:
							str = $"{b} × {a}";
							break;
					}
				}
				else
				{
					int max = (int)Math.Ceiling(10.0 / a);
					b = 0;
					int num = 0;
					for (int i = 2; i >= 0; i--)
					{
						num = random.Next(1, max);
						num *= (int)Math.Pow(10, i);
						b += num;
					}
					order = random.Next(0, 2);
					str = "";
					switch (order)
					{
						case 0:
							str = $"{a} × {b}";
							break;
						case 1:
							str = $"{b} × {a}";
							break;
					}
				}
			}
			else
			{
				a = random.Next(100, 1000);
				b = random.Next(100, 1000);
				return Tuple.Create($"{a} × {b}", (double)(a*b));
			}
			return Tuple.Create(str, (double)(a * b));
		}
		public Tuple<string, double> P2011() //3 by 1 digit subtraction, b, n
		{
			int a = 0, b = 0;
			if (beginner)
			{
				a = random.Next(10, 100) * 10;
				b = random.Next(1, 9);
				a += random.Next(b, 10);
			}
			else
			{
				a = random.Next(100, 1000);
				b = random.Next(1, 10);
			}
			return Tuple.Create($"{a} - {b}", (double)a - b);
		}
		public Tuple<string, double> P2012() // 3 by 4 digit addition, b, (n, i, a undecided)?
		{
			int a = 0, b = 0;
			if (beginner)
			{
				int num = 0;
				a = random.Next(100, 1000);
				b = random.Next(1, 10) * 1000;
				//100s place
				num = a / 100;
				b += random.Next(0, 10 - num) * 100;
				//10s place
				num = a / 10;
				num %= 10;
				b += random.Next(0, 10 - num) * 10;
				//1s place
				num = a;
				num %= 10;
				b += random.Next(0, 10 - num);
			}
			else
			{
				a = random.Next(100, 1000);
				b = random.Next(1000, 10000);
			}

			int order = random.Next(0, 2);
			string str = "";
			switch (order)
			{
				case 0:
					str = $"{a} + {b}";
					break;
				case 1:
					str = $"{b} + {a}";
					break;
			}
			return Tuple.Create(str, (double)a + b);
		}
		public Tuple<string, double> P2013() //2 by 1 digit addition, b, n, i
		{
			int a = 0, b = 0;
			if (beginner)
			{
				int max = 0;
				a = random.Next(1, 10);
				b = random.Next(1, 10) * 10;
				max = 10 - a;
				b += random.Next(0, max);
			}
			else
			{
				a = random.Next(1, 10);
				b = random.Next(10, 100);
			}

			int order = random.Next(0, 2);
			string str = "";
			switch (order)
			{
				case 0:
					str = $"{a} + {b}";
					break;
				case 1:
					str = $"{b} + {a}";
					break;
			}
			return Tuple.Create(str, (double)a + b);
		}
		public Tuple<string, double> P2014() //2 by 1 digit subtraction, b, n,
		{
			int a = 0, b = 0;
			if (beginner)
			{
				a = random.Next(1, 10) * 10;
				b = random.Next(1, 10);
				a += random.Next(b, 10);
			}
			else
			{
				a = random.Next(10, 100);
				b = random.Next(1, 10);
			}

			return Tuple.Create($"{a} - {b}", (double)a - b);
		}
	}
}
