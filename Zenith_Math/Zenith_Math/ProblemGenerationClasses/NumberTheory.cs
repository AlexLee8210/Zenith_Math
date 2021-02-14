using System;
using System.Collections.Generic;
using System.Text;

namespace Zenith_Math.ProblemGenerationClasses
{
	class NumberTheory : ProblemGeneration
	{
		public NumberTheory()
		{
			MakeDiffList(this.GetType(), "NumberTheory", this);
		}
		private int GCD(int a, int b)
		{
			while (b != 0)
			{
				a %= b;
				int temp = a;
				a = b;
				b = temp;
			}
			return a;
		}

		private int LCM(int a, int b)
		{
			return (a / GCD(a, b)) * b;
		}

		// Greatest Common Factor
		public Tuple<string, int> P14001()
		{
			int ans = random.Next(5, 20);
			int A = ans * random.Next(2, 13);
			int B = A;
			while (B == A)
				B = ans * random.Next(2, 13);

			if (novice)
			{
				ans = GCD(A, B);
				return Tuple.Create($"GCF of {A} and {B} is", ans);
			}
			int C = B;
			while (C == B || C == A)
				C = ans * random.Next(2, 13);
			ans = GCD(A, GCD(B, C));
			return Tuple.Create($"GCF of {A}, {B}, and {C} is", ans);
		}

		// Primes between A and B (B > A)
		public Tuple<string, int> P14002()
		{
			// all primes from 1 to 1000
			bool[] isPrime = new bool[1001];
			for (int i = 0; i < 1001; i++)
				isPrime[i] = true;
			isPrime[0] = isPrime[1] = false;
			for (int i = 2; i * i <= 1000; i++)
				if (isPrime[i])
					for (int j = i * i; j <= 1000; j += i)
						isPrime[j] = false;

			int B = random.Next(20, 101);
			int A = B - random.Next(5, 11);
			if (advanced)
			{
				B = random.Next(30, 101);
				A = B - random.Next(5, 21);
			}
			int count = 0;
			for (int i = A; i <= B; i++)
			{
				if (isPrime[i])
					count++;
			}
			return Tuple.Create($"How many primes are between {A} and {B} inclusive?", count);
		}

		// Lowest Common Multiple
		public Tuple<string, int> P14003()
		{
			int A = random.Next(2, 40);
			int B = A;
			while (B == A)
				B = random.Next(2, 40);
			int ans = LCM(A, B);

			if (novice)
			{
				return Tuple.Create($"LCM of {A} and {B} is", ans);
			}
			int C = B;
			while (C == B || C == A)
				C = random.Next(2, 40);
			ans = LCM(A, LCM(B, C));
			return Tuple.Create($"LCM of {A}, {B}, and {C} is", ans);
		}

		// Remainder when divided by 10
		public Tuple<string, int> P14008()
		{
			int num = random.Next(50, 99999999);
			int res = num % 10;
			return Tuple.Create($"{num} mod 10 = ", res);
		}

		// Remainder when divided by 11
		public Tuple<string, int> P14009()
		{
			int num;
			if (novice)
			{
				num = random.Next(50, 1000);
			}
			else if (intermediate)
			{
				num = random.Next(50, 1000);
			}
			else
			{
				num = random.Next(1000, 1000000);
			}
			int res = num % 11;
			return Tuple.Create($"{num} mod 11 = ", res);
		}

		// Remainder when divided by 12
		public Tuple<string, int> P14010()
		{
			int num;
			if (novice)
			{
				num = random.Next(50, 1000);
			}
			else if (intermediate)
			{
				num = random.Next(50, 1000);
			}
			else
			{
				num = random.Next(1000, 1000000);
			}
			int res = num % 12;
			return Tuple.Create($"{num} mod 12 = ", res);
		}

		// Remainder when divided by 2
		public Tuple<string, int> P14011()
		{
			int num;
			if (novice)
			{
				num = random.Next(50, 1000);
			}
			else if (intermediate)
			{
				num = random.Next(50, 1000);
			}
			else
			{
				num = random.Next(1000, 1000000);
			}
			int res = num % 2;
			return Tuple.Create($"{num} mod 2 = ", res);
		}

		// Remainder when divided by 3
		public Tuple<string, int> P14012()
		{
			int num;
			if (novice)
			{
				num = random.Next(50, 1000);
			}
			else if (intermediate)
			{
				num = random.Next(50, 1000);
			}
			else
			{
				num = random.Next(1000, 1000000);
			}
			int res = num % 3;
			return Tuple.Create($"{num} mod 3 = ", res);
		}

		// Remainder when divided by 4
		public Tuple<string, int> P14013()
		{
			int num;
			if (novice)
			{
				num = random.Next(50, 1000);
			}
			else if (intermediate)
			{
				num = random.Next(50, 1000);
			}
			else
			{
				num = random.Next(1000, 1000000);
			}
			int res = num % 4;
			return Tuple.Create($"{num} mod 4 = ", res);
		}

		// Remainder when divided by 5
		public Tuple<string, int> P14014()
		{
			int num;
			if (novice)
			{
				num = random.Next(50, 1000);
			}
			else if (intermediate)
			{
				num = random.Next(50, 1000);
			}
			else
			{
				num = random.Next(1000, 1000000);
			}
			int res = num % 5;
			return Tuple.Create($"{num} mod 5 = ", res);
		}

		// Remainder when divided by 6
		public Tuple<string, int> P14015()
		{
			int num;
			if (novice)
			{
				num = random.Next(50, 1000);
			}
			else if (intermediate)
			{
				num = random.Next(50, 1000);
			}
			else
			{
				num = random.Next(1000, 1000000);
			}
			int res = num % 6;
			return Tuple.Create($"{num} mod 6 = ", res);
		}

		// Remainder when divided by 8
		public Tuple<string, int> P14016()
		{
			int num;
			if (novice)
			{
				num = random.Next(50, 1000);
			}
			else if (intermediate)
			{
				num = random.Next(50, 1000);
			}
			else
			{
				num = random.Next(1000, 1000000);
			}
			int res = num % 8;
			return Tuple.Create($"{num} mod 8 = ", res);
		}

		// Remainder when divided by 9
		public Tuple<string, int> P14017()
		{
			int num;
			if (novice)
			{
				num = random.Next(50, 1000);
			}
			else if (intermediate)
			{
				num = random.Next(50, 1000);
			}
			else
			{
				num = random.Next(1000, 1000000);
			}
			int res = num % 9;
			return Tuple.Create($"{num} mod 9 = ", res);
		}
	}
}
