using System;
using System.Collections.Generic;
using System.Text;

namespace Zenith_Math.ProblemGenerationClasses
{
	class MultiplicationTrick : ProblemGeneration
	{
		public MultiplicationTrick()
		{
			MakeDiffList(this.GetType(), "Multiplication Tricks", this);
		}

        public Tuple<string, double> P13012()//Multiplying by 1001
		{
			int max = 4;
			if (novice)
			{
				max = 3;
			}
			int digits = random.Next(1, max);
			int b = random.Next((int)Math.Pow(10, digits), (int)Math.Pow(10, digits + 1));

			int order = random.Next(0, 2);
			string str = "";
			if (order == 0)
			{
				str = 1001 + " × " + b;
			}
			else
			{
				str = b + " × " + 1001;
			}

			return Tuple.Create(str, (double)1001 * b);
		}
		public Tuple<string, double> P13013() //Multiplying by 101
		{
			int max = 3;

			if (novice)
			{
				max = 2;
			}
			int digits = random.Next(1, max);
			int order = random.Next(0, 2);
			int b = random.Next((int)Math.Pow(10, digits), (int)Math.Pow(10, digits + 1));
			string str = "";
			if (order == 0)
			{
				str = 101 + " × " + b;
			}
			else
			{
				str = b + " × " + 101;
			}

			return Tuple.Create(str, (double)101 * b);
		}
		public Tuple<string, double> P13014()//Multiplying by 11 trick
		{

			int max = 3;

			if (novice)
			{
				max = 3;
			}
			else if (intermediate)
			{
				max = 4;
			}
			else if (advanced)
			{
				max = 5;
			}
			int digits = random.Next(1, max);
			int order = random.Next(0, 2);
			int b = random.Next((int)Math.Pow(10, digits), (int)Math.Pow(10, digits + 1));
			string str = "";
			if (order == 0)
			{
				str = 11 + " × " + b;
			}
			else
			{
				str = b + " × " + 11;
			}

			return Tuple.Create(str, (double)11 * b);
		}
		public Tuple<string, double> P13015()//Multiplying by 111 trick
		{
			int max = 2;

			if (novice)
			{
				max = 2;
			}
			else if (intermediate)
			{
				max = 3;
			}
			else if (advanced)
			{
				max = 4;
			}
			int digits = random.Next(1, max);
			int order = random.Next(0, 2);
			int b = random.Next((int)Math.Pow(10, digits), (int)Math.Pow(10, digits + 1));

			string str = "";
			if (order == 0)
			{
				str = 111 + " × " + b;
			}
			else
			{
				str = b + " × " + 111;
			}

			return Tuple.Create(str, (double)111 * b);
		}
		public Tuple<string, double> P13016()//Multiplying by 12 trick
		{

			int max = 2;

			if (novice)
			{
				max = 2;
			}
			else if (intermediate)
			{
				max = 3;
			}
			else if (advanced)
			{
				max = 4;
			}

			int digits = random.Next(1, max);
			int order = random.Next(0, 2);
			int b = random.Next((int)Math.Pow(10, digits), (int)Math.Pow(10, digits + 1));
			string str = "";
			if (order == 0)
			{
				str = 12 + " × " + b;
			}
			else
			{
				str = b + " × " + 12;
			}

			return Tuple.Create(str, (double)12 * b);
		}
		public Tuple<string, double> P13017()//Multiplying by 125 trick
		{
			int digits = 0;
			int b = 0;
			int max = 3;

			if (intermediate)
			{
				max = 2;
				digits = random.Next(1, max);
				b = random.Next((int)Math.Pow(10, digits), (int)Math.Pow(10, digits + 1));
				b -= (b % 8);
			}
			else if (advanced)
			{
				digits = random.Next(1, max);
				b = random.Next((int)Math.Pow(10, digits), (int)Math.Pow(10, digits + 1));
			}

			int order = random.Next(0, 2);
			string str = "";
			if (order == 0)
			{
				str = 125 + " × " + b;
			}
			else
			{
				str = b + " × " + 125;
			}

			return Tuple.Create(str, (double)125 * b);
		}
		public Tuple<string, double> P13018()//Multiplying by 143 trick
		{
			int max = 3;
			if (intermediate)
			{
				max = 2;
			}
			int digits = random.Next(1, max);
			int b = random.Next((int)Math.Pow(10, digits), (int)Math.Pow(10, digits + 1));
			b -= (b % 7);
			if (advanced)
			{
				b += random.Next(0, 2);
			}
			int order = random.Next(0, 2);
			string str = "";
			if (order == 0)
			{
				str = 143 + " × " + b;
			}
			else
			{
				str = b + " × " + 143;
			}

			return Tuple.Create(str, (double)143 * b);
		}

        //chris code
        public static Tuple<string, double> P13048()
        {
            int o = random.Next(1, 10);
            int a = 0;
            int b = 0;
            if (novice)
            {
                int d = random.Next(1, 10);
                a = o + 10 * d;
                b = 10 - o + 10 * d;
            }
            else if (intermediate)
            {
                int d = random.Next(1, 15);
                a = o + 10 * d;
                b = 10 - o + 10 * d;
            }
            else if (advanced)
            {
                int d = random.Next(1, 20);
                a = o + 10 * d;
                b = 10 - o + 10 * d;
            }


            int order = random.Next(0, 2); //determines order
            string str = "";//The question that will actually appear
            if (order == 0)
            {//add
                int one = random.Next(2, b);
                int two = b - one;
                //order
                order = random.Next(0, 2);
                if (order == 0)
                    str = a + " × " + one + " + " + a + " × " + two;
                else
                    str = one + " × " + a + " + " + two + " × " + a;
            }
            else
            {//subtract
                int one = random.Next(1, 100);
                int two = b + one;

                //order
                order = random.Next(0, 2);
                if (order == 0)
                    str = a + " × " + two + " - " + a + " × " + one;
                else
                    str = two + " × " + a + " - " + one + " × " + a;
            }
            double res = a * b;
            return Tuple.Create(str, (double)a * b);
        }

        //13047
        public static Tuple<string, double> P13047()
        {

            //Template for a multiplying by "a" trick kind of thing
            double a = 25;
            //replace a with whatever
            int min = 2;//Min number of digits
            int max = 3;//Max number of digits
            int digits = 0;//Randomly chosen number of digits within a range
            int b = 0;//The number itself



            if (intermediate)
            {//Change conditions based on difficulty
                max = 2;

            }
            else if (advanced)
            {
                max = 3;

            }
            digits = random.Next(min - 1, max);//Chooses a number of digits
            b = random.Next((int)Math.Pow(10, digits), (int)Math.Pow(10, digits + 1));//Picks between 10^digits and 10^(digits+1)
            b = b - (b % 4);
            int order = random.Next(0, 2); //determines order
            string str = "";//The question that will actually appear
            int two, one;
            if (order == 0) //first determines if itll add or subtract
            {//add to 25
                one = random.Next(1, 25);
                two = 25 - one;
                //determines order
                order = random.Next(0, 2);
                if (order == 0)
                    str = two + " × " + b + " + " + one + " × " + b;
                else
                    str = b + " × " + two + " + " + b + " × " + one;
            }
            else
            {//diff is 25
                one = random.Next(1, 75);
                two = one + 25;
                //determines order
                order = random.Next(0, 2);
                if (order == 0)
                    str = two + " × " + b + " - " + one + " × " + b;
                else
                    str = b + " × " + two + " - " + b + " × " + one;

            }
            double res = b * 25;
            return Tuple.Create(str, res);
        }

        //13046
        public static Tuple<string, double> P13046()
        {
            int a = random.Next(11, 20);
            int b = random.Next(1, 10);


            if (advanced)
            {
                a = random.Next(11, 50);
            }
            int c = a + b;
            int d = random.Next(1, 10) * 10 - ((a - b) % 10);
            string str = a + "² - " + b + "² + " + c + " × " + d;

            double res = (a + b) * (a - b) + c * d;
            return Tuple.Create(str, res);
        }


        //13045
        public static Tuple<string, double> P13045()
        {
            int a = random.Next(2, 10);
            int b = random.Next(1, 10);
            int c = random.Next(1, 10);
            int n = random.Next(2, 4);
            n = (int)Math.Pow(10, n);
            if (advanced)
            {
                a = random.Next(2, 20);
            }

            int order = random.Next(0, 2); //determines order
            string str = "";//The question that will actually appear
            if (order == 0)
            {
                str = n * c - b + " × " + a + " + " + b * a;

            }
            else
            {
                str = n * c - b + " × " + a + " + " + b + " × " + a;
            }
            double res = (n * c - b) * a + a * b;
            return Tuple.Create(str, res);
        }

        //13044
        public static Tuple<string, double> P()
        {
            int a = 111 * random.Next(2, 10);
            int b = random.Next(1, 10);

            if (advanced)
            {
                b = random.Next(1, 37);
            }

            int order = random.Next(0, 2); //determines order
            string str = "";//The question that will actually appear
            if (order == 0)
            {
                str = a + " × " + b + "/37";

            }
            else
            {
                str = b + "/37 × " + a;
            }
            double res = a * b / 37;
            return Tuple.Create(str, res);
        }


        //13042
        public static Tuple<string, double> P13042()
        {
            int o = random.Next(1, 10);
            int a = 0;
            int b = 0;
            if (novice)
            {
                int d = random.Next(1, 10);
                a = o + 10 * d;
                b = 10 - o + 10 * d;
            }
            else if (intermediate)
            {
                int d = random.Next(1, 15);
                a = o + 10 * d;
                b = 10 - o + 10 * d;
            }
            else if (advanced)
            {
                int d = random.Next(1, 20);
                a = o + 10 * d;
                b = 10 - o + 10 * d;
            }


            int order = random.Next(0, 2); //determines order
            string str = "";//The question that will actually appear
            if (order == 0)
            {
                str = a + " × " + b;

            }
            else
            {
                str = b + " × " + a;
            }
            double res = a * b;
            return Tuple.Create(str, (double)a * b);
        }
        //13041
        public static Tuple<string, double> P13041()
        {
            int a = 1;
            string str = "";

            if (intermediate)
            {
                a = random.Next(5, 10);
            }
            else if (advanced)
            {
                a = random.Next(5, 50);
            }
            int b = 3 * a;
            int order = random.Next(0, 2);
            if (order == 0)
            {
                str = a + "² + " + b + "²";

            }
            else
            {

                str = b + "² + " + a + "²";
            }
            double res = Math.Pow(a, 2) + Math.Pow(b, 2);
            return Tuple.Create(str, (double)res);
        }


        //13040

        public static Tuple<string, double> P13040()
        {
            int a = 1;
            string str = "";

            if (intermediate)
            {
                a = random.Next(5, 10);
            }
            else if (advanced)
            {
                a = random.Next(5, 50);
            }
            int b = 2 * a;
            int order = random.Next(0, 2);
            if (order == 0)
            {
                str = a + "² + " + b + "²";

            }
            else
            {

                str = b + "² + " + a + "²";
            }
            double res = Math.Pow(a, 2) + Math.Pow(b, 2);
            return Tuple.Create(str, (double)res);
        }

        //13039
        public static Tuple<string, double> P13039()
        {
            int a = 1;
            string str = "";

            if (intermediate)
            {
                a = random.Next(5, 10);
            }
            else if (advanced)
            {
                a = random.Next(5, 50);
            }
            int b = 7 * a;
            int order = random.Next(0, 2);
            if (order == 0)
            {
                str = a + "² + " + b + "²";

            }
            else
            {

                str = b + "² + " + a + "²";
            }
            double res = Math.Pow(a, 2) + Math.Pow(b, 2);
            return Tuple.Create(str, (double)res);
        }



        //13038
        public static Tuple<string, double> P13038()
        {
            int o = random.Next(1, 10);
            int i = random.Next(2, 10); //i and i-1

            int a = 10 * o + i;
            int b = 10 * (i - 1) + (10 - o);
            string str = "";
            int order = random.Next(0, 2);
            //LMAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
            if (order == 0)
            {
                str = a + "² + " + b + "²";

            }
            else
            {

                str = b + "² + " + a + "²";
            }
            double res = Math.Pow(a, 2) + Math.Pow(b, 2);
            return Tuple.Create(str, (double)res);
        }


        //13037
        public static Tuple<string, double> P13037()
        {
            int t1 = random.Next(1, 9);
            int t2 = random.Next(1, 9);
            int o = 6;
            if (advanced)
            {
                o = random.Next(6, 10);
            }


            int a = 10 * t1 + o;
            int b = 10 * t1 + (10 - o);
            int c = 10 * t2 + o;
            int d = 10 * t2 + (10 - o);
            string str = a + "² - " + b + "² + " + c + "² - " + d + "²";
            //LMAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA

            double res = Math.Pow(a, 2) - Math.Pow(b, 2) + Math.Pow(c, 2) - Math.Pow(d, 2);
            return Tuple.Create(str, (double)res);
        }

        //13036
        public static Tuple<string, double> P13036()
        {
            int a = random.Next(41, 60);

            string str = a + "²";//LMAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA

            double res = a * a;
            return Tuple.Create(str, (double)res);
        }

        //13035
        public static Tuple<string, double> P13035()
        {
            int o = 5;
            int a = 0;
            int b = 0;
            if (novice)
            {
                int d = random.Next(1, 10);
                a = o + 10 * d;
            }
            else if (intermediate)
            {
                int d = random.Next(1, 15);
                a = o + 10 * d;
            }
            else if (advanced)
            {
                int d = random.Next(1, 20);
                a = o + 10 * d;
            }
            b = a;

            string str = b + "²";//LMAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA

            double res = a * b;
            return Tuple.Create(str, (double)a * b);
        }

        //13034
        public static Tuple<string, double> P13034()
        {
            int o = random.Next(1, 10);
            int a = 0;
            int b = 0;


            int d = random.Next(1, 10);
            a = 10 * d + o;
            b = 10 * (10 - d) + o;



            int order = random.Next(0, 2); //determines order
            string str = "";//The question that will actually appear
            if (order == 0)
            {
                str = a + " × " + b;

            }
            else
            {
                str = b + " × " + a;
            }
            double res = a * b;
            return Tuple.Create(str, (double)a * b);
        }


        //13033
        public static Tuple<string, double> P13033()
        {
            int a = 0;
            int b = 0;
            if (novice)
            {
                a = 5 + 10 * random.Next(1, 10);
                b = 5 + 10 * random.Next(1, 10);
            }
            else if (intermediate)
            {
                a = 5 + 10 * random.Next(1, 15);
                b = 5 + 10 * random.Next(1, 15);
            }
            else if (advanced)
            {
                a = 5 + 10 * random.Next(1, 20);
                b = 5 + 10 * random.Next(1, 20);
            }


            int order = random.Next(0, 2); //determines order
            string str = "";//The question that will actually appear
            if (order == 0)
            {
                str = a + " × " + b;

            }
            else
            {
                str = b + " × " + a;
            }
            double res = a * b;
            return Tuple.Create(str, (double)a * b);
        }


        //13032
        public static Tuple<string, double> P13032()
        {
            int a = 0;
            int b = 0;
            if (novice)
            {
                a = -random.Next(1, 10) + (int)Math.Pow(10, random.Next(2, 3));
                b = -random.Next(1, 10) + (int)Math.Pow(10, random.Next(2, 3));
            }
            else if (intermediate)
            {
                a = -random.Next(1, 10) + (int)Math.Pow(10, random.Next(2, 4));
                b = -random.Next(1, 10) + (int)Math.Pow(10, random.Next(2, 4));
            }
            else if (advanced)
            {
                a = -random.Next(1, 15) + (int)Math.Pow(10, random.Next(2, 4));
                b = -random.Next(1, 15) + (int)Math.Pow(10, random.Next(2, 4));
            }


            int order = random.Next(0, 2); //determines order
            string str = "";//The question that will actually appear
            if (order == 0)
            {
                str = a + " × " + b;

            }
            else
            {
                str = b + " × " + a;
            }
            double res = a * b;
            return Tuple.Create(str, (double)a * b);
        }
        //13031
        public static Tuple<string, double> P13031()
        {
            int a = 0;
            int b = 0;
            if (novice)
            {
                a = -random.Next(1, 10) + (int)Math.Pow(10, random.Next(2, 3));
                b = random.Next(1, 10) + (int)Math.Pow(10, random.Next(2, 3));
            }
            else if (intermediate)
            {
                a = -random.Next(1, 10) + (int)Math.Pow(10, random.Next(2, 4));
                b = random.Next(1, 10) + (int)Math.Pow(10, random.Next(2, 4));
            }
            else if (advanced)
            {
                a = -random.Next(1, 15) + (int)Math.Pow(10, random.Next(2, 4));
                b = random.Next(1, 15) + (int)Math.Pow(10, random.Next(2, 4));
            }


            int order = random.Next(0, 2); //determines order
            string str = "";//The question that will actually appear
            if (order == 0)
            {
                str = a + " × " + b;

            }
            else
            {
                str = b + " × " + a;
            }
            double res = a * b;
            return Tuple.Create(str, (double)a * b);
        }


        //13030
        public static Tuple<string, double> P13030()
        {
            int a = 0;
            int b = 0;
            if (novice)
            {
                a = random.Next(1, 10) + (int)Math.Pow(10, random.Next(2, 3));
                b = random.Next(1, 10) + (int)Math.Pow(10, random.Next(2, 3));
            }
            else if (intermediate)
            {
                a = random.Next(1, 10) + (int)Math.Pow(10, random.Next(2, 4));
                b = random.Next(1, 10) + (int)Math.Pow(10, random.Next(2, 4));
            }
            else if (advanced)
            {
                a = random.Next(1, 15) + (int)Math.Pow(10, random.Next(2, 4));
                b = random.Next(1, 15) + (int)Math.Pow(10, random.Next(2, 4));
            }


            int order = random.Next(0, 2); //determines order
            string str = "";//The question that will actually appear
            if (order == 0)
            {
                str = a + " × " + b;

            }
            else
            {
                str = b + " × " + a;
            }
            double res = a * b;
            return Tuple.Create(str, (double)a * b);
        }


        //13029
        public static Tuple<string, double> P13029()
        {
            int c = random.Next(1, 10);
            int d = random.Next(1, 10);
            int a = 10 * c + d;
            int b = 10 * d + c;



            int order = random.Next(0, 2); //determines order
            string str = "";//The question that will actually appear
            if (order == 0)
            {
                str = a + " × " + b;

            }
            else
            {
                str = b + " × " + a;
            }
            double res = a * b;
            return Tuple.Create(str, (double)a * b);
        }

        //13028
        public static Tuple<string, double> P13028()
        {

            //Template for a multiplying by "a" trick kind of thing
            int a = random.Next(2, 10) * 10;
            int d = random.Next(1, 10);

            if (intermediate)
            {
                a = random.Next(2, 20) * 10;

            }
            else if (advanced)
            {
                a = random.Next(2, 40) * 10;
            }
            int b = a + d;
            a -= d;

            int order = random.Next(0, 2); //determines order
            string str = "";//The question that will actually appear
            if (order == 0)
            {
                str = a + " × " + b;

            }
            else
            {
                str = b + " × " + a;
            }
            double res = a * b;
            return Tuple.Create(str, (double)a * b);
        }


        //13026
        public static Tuple<string, double> P13026()
        {

            //Template for a multiplying by "a" trick kind of thing
            int a = 77;
            //replace a with whatever
            int min = 2;//Min number of digits
            int max = 4;//Max number of digits
            int digits = 0;//Randomly chosen number of digits within a range
            int b = 0;//The number itself

            digits = random.Next(min - 1, max);//Chooses a number of digits
            b = random.Next((int)Math.Pow(10, digits), (int)Math.Pow(10, digits + 1));//Picks between 10^digits and 10^(digits+1)
            b = b - (b % 13);

            int order = random.Next(0, 2); //determines order
            string str = "";//The question that will actually appear
            if (order == 0)
            {
                str = a + " × " + b;

            }
            else
            {
                str = b + " × " + a;
            }
            double res = a * b;
            return Tuple.Create(str, (double)a * b);
        }

        //13023
        public static Tuple<string, double> P13023()
        {

            //Template for a multiplying by "a" trick kind of thing
            int a = 3367;
            //replace a with whatever
            int min = 2;//Min number of digits
            int max = 3;//Max number of digits
            int digits = 0;//Randomly chosen number of digits within a range
            int b = 0;//The number itself
            if (intermediate)
                max = 2;
            digits = random.Next(min - 1, max);//Chooses a number of digits
            b = random.Next((int)Math.Pow(10, digits), (int)Math.Pow(10, digits + 1));//Picks between 10^digits and 10^(digits+1)
            b = b - (b % 3);

            int order = random.Next(0, 2); //determines order
            string str = "";//The question that will actually appear
            if (order == 0)
            {
                str = a + " × " + b;

            }
            else
            {
                str = b + " × " + a;
            }
            double res = a * b;
            return Tuple.Create(str, (double)a * b);
        }

        //13019
        public static Tuple<string, double> P13019()
        {

            //Template for a multiplying by "a" trick kind of thing
            int a = 1443;
            //replace a with whatever
            int min = 2;//Min number of digits
            int max = 3;//Max number of digits
            int digits = 0;//Randomly chosen number of digits within a range
            int b = 0;//The number itself



            if (novice)
            {//Change conditions based on difficulty
                //max = 2;
            }
            else if (intermediate)
            {
                //max = 3;
            }
            else if (advanced)
            {
                //max = 4;
            }
            digits = random.Next(min - 1, max);//Chooses a number of digits
            b = random.Next((int)Math.Pow(10, digits), (int)Math.Pow(10, digits + 1));//Picks between 10^digits and 10^(digits+1)
            b = b - (b % 7);

            int order = random.Next(0, 2); //determines order
            string str = "";//The question that will actually appear
            if (order == 0)
            {
                str = a + " × " + b;

            }
            else
            {
                str = b + " × " + a;
            }
            double res = a * b;
            return Tuple.Create(str, (double)a * b);
        }

        //13027
        public static Tuple<string, double> P13027()
        {

            //Template for a multiplying by "a" trick kind of thing
            int a = random.Next(2, 30);
            int b = 0;//The number itself
            int c = random.Next(1, 10) * (int)(Math.Pow(-1, random.Next(0, 2)));

            if (novice)
            {//Change conditions based on difficulty
                a = random.Next(2, 10);
                b = 100 + c;
            }
            else if (intermediate)
            {
                b = (int)Math.Pow(10, random.Next(2, 4)) + c;
            }
            else if (advanced)
            {
                b = (int)Math.Pow(10, random.Next(2, 4)) + c;
            }

            int order = random.Next(0, 2); //determines order
            string str = "";//The question that will actually appear
            if (order == 0)
            {
                str = a + " × " + b;

            }
            else
            {
                str = b + " × " + a;
            }
            double res = b * a;
            return Tuple.Create(str, res);
        }





        //13025
        public static Tuple<string, double> P13025()
        {

            //Template for a multiplying by "a" trick kind of thing
            double a = 75;
            //replace a with whatever
            int min = 2;//Min number of digits
            int max = 3;//Max number of digits
            int digits = 0;//Randomly chosen number of digits within a range
            int b = 0;//The number itself



            if (novice)
            {//Change conditions based on difficulty
                max = 2;
                digits = random.Next(min - 1, max);//Chooses a number of digits
                b = random.Next((int)Math.Pow(10, digits), (int)Math.Pow(10, digits + 1));//Picks between 10^digits and 10^(digits+1)
                b = b - (b % 4);
            }
            else if (intermediate)
            {
                max = 3;
                digits = random.Next(min - 1, max);//Chooses a number of digits
                b = random.Next((int)Math.Pow(10, digits), (int)Math.Pow(10, digits + 1));//Picks between 10^digits and 10^(digits+1)
                b = b - (b % 4);
            }
            else if (advanced)
            {
                max = 4;
                digits = random.Next(min - 1, max);//Chooses a number of digits
                b = random.Next((int)Math.Pow(10, digits), (int)Math.Pow(10, digits + 1));//Picks between 10^digits and 10^(digits+1)
            }

            int order = random.Next(0, 2); //determines order
            string str = "";//The question that will actually appear
            if (order == 0)
            {
                str = a + " × " + b;

            }
            else
            {
                str = b + " × " + a;
            }
            double res = b * a;
            return Tuple.Create(str, res);
        }

        //13024
        public static Tuple<string, double> P13024()
        {

            //Template for a multiplying by "a" trick kind of thing
            double a = 50;
            //replace a with whatever
            int min = 2;//Min number of digits
            int max = 3;//Max number of digits
            int digits = 0;//Randomly chosen number of digits within a range
            int b = 0;//The number itself



            if (novice)
            {//Change conditions based on difficulty
                max = 2;
                digits = random.Next(min - 1, max);//Chooses a number of digits
                b = random.Next((int)Math.Pow(10, digits), (int)Math.Pow(10, digits + 1));//Picks between 10^digits and 10^(digits+1)
                b = b - (b % 2);
            }
            else if (intermediate)
            {
                max = 3;
                digits = random.Next(min - 1, max);//Chooses a number of digits
                b = random.Next((int)Math.Pow(10, digits), (int)Math.Pow(10, digits + 1));//Picks between 10^digits and 10^(digits+1)
                b = b - (b % 2);
            }
            else if (advanced)
            {
                max = 4;
                digits = random.Next(min - 1, max);//Chooses a number of digits
                b = random.Next((int)Math.Pow(10, digits), (int)Math.Pow(10, digits + 1));//Picks between 10^digits and 10^(digits+1)
            }

            int order = random.Next(0, 2); //determines order
            string str = "";//The question that will actually appear
            if (order == 0)
            {
                str = a + " × " + b;

            }
            else
            {
                str = b + " × " + a;
            }
            double res = b * a;
            return Tuple.Create(str, res);
        }

        //13022
        public static Tuple<string, double> P13022()
        {

            //Template for a multiplying by "a" trick kind of thing
            double a = 25;
            //replace a with whatever
            int min = 2;//Min number of digits
            int max = 3;//Max number of digits
            int digits = 0;//Randomly chosen number of digits within a range
            int b = 0;//The number itself



            if (novice)
            {//Change conditions based on difficulty
                max = 2;
                digits = random.Next(min - 1, max);//Chooses a number of digits
                b = random.Next((int)Math.Pow(10, digits), (int)Math.Pow(10, digits + 1));//Picks between 10^digits and 10^(digits+1)
                b = b - (b % 4);
            }
            else if (intermediate)
            {
                max = 3;
                digits = random.Next(min - 1, max);//Chooses a number of digits
                b = random.Next((int)Math.Pow(10, digits), (int)Math.Pow(10, digits + 1));//Picks between 10^digits and 10^(digits+1)
                b = b - (b % 4);
            }
            else if (advanced)
            {
                max = 4;
                digits = random.Next(min - 1, max);//Chooses a number of digits
                b = random.Next((int)Math.Pow(10, digits), (int)Math.Pow(10, digits + 1));//Picks between 10^digits and 10^(digits+1)
            }

            int order = random.Next(0, 2); //determines order
            string str = "";//The question that will actually appear
            if (order == 0)
            {
                str = "25" + " × " + b;

            }
            else
            {
                str = b + " × " + "25";
            }
            double res = b * 25;
            return Tuple.Create(str, res);
        }



        //13021
        public static Tuple<string, double> P13021()
        {

            //Template for a multiplying by "a" trick kind of thing
            double a = 16 + (2 / 3);
            //replace a with whatever
            int min = 2;//Min number of digits
            int max = 3;//Max number of digits
            int digits = 0;//Randomly chosen number of digits within a range
            int b = 0;//The number itself



            if (novice)
            {//Change conditions based on difficulty
                max = 2;
                digits = random.Next(min - 1, max);//Chooses a number of digits
                b = random.Next((int)Math.Pow(10, digits), (int)Math.Pow(10, digits + 1));//Picks between 10^digits and 10^(digits+1)
                b = b - (b % 6);
            }
            else if (intermediate)
            {
                max = 3;
                digits = random.Next(min - 1, max);//Chooses a number of digits
                b = random.Next((int)Math.Pow(10, digits), (int)Math.Pow(10, digits + 1));//Picks between 10^digits and 10^(digits+1)
                b = b - (b % 6);
            }
            else if (advanced)
            {
                max = 3;
                digits = random.Next(min - 1, max);//Chooses a number of digits
                b = random.Next((int)Math.Pow(10, digits), (int)Math.Pow(10, digits + 1));//Picks between 10^digits and 10^(digits+1)
                b = b - (b % 3);
            }

            int order = random.Next(0, 2); //determines order
            string str = "";//The question that will actually appear
            if (order == 0)
            {
                str = "16 2/3" + " × " + b;

            }
            else
            {
                str = b + " × " + "16 2/3";
            }
            double res = 50 * b / 3;
            return Tuple.Create(str, res);
        }

        //13020
        public static Tuple<string, double> P13020()
        {

            //Template for a multiplying by "a" trick kind of thing
            int a = 1;
            a = 15;
            //replace a with whatever
            int min = 2;//Min number of digits
            int max = 3;//Max number of digits
            int digits = 0;//Randomly chosen number of digits within a range
            int b = 0;//The number itself



            if (novice)
            {//Change conditions based on difficulty
                max = 2;
                digits = random.Next(min - 1, max);//Chooses a number of digits
                b = random.Next((int)Math.Pow(10, digits), (int)Math.Pow(10, digits + 1));//Picks between 10^digits and 10^(digits+1)
                b = b - (b % 2);
            }
            else if (intermediate)
            {
                max = 3;
                digits = random.Next(min - 1, max);//Chooses a number of digits
                b = random.Next((int)Math.Pow(10, digits), (int)Math.Pow(10, digits + 1));//Picks between 10^digits and 10^(digits+1)
                b = b - (b % 2);
            }
            else if (advanced)
            {
                max = 3;
                digits = random.Next(min - 1, max);//Chooses a number of digits
                b = random.Next((int)Math.Pow(10, digits), (int)Math.Pow(10, digits + 1));//Picks between 10^digits and 10^(digits+1)

            }

            int order = random.Next(0, 2); //determines order
            string str = "";//The question that will actually appear
            if (order == 0)
            {
                str = a + " × " + b;

            }
            else
            {
                str = b + " × " + a;
            }
            double res = a * b;
            return Tuple.Create(str, (double)a * b);
        }
    }
}
