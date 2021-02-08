using System;
using System.Collections.Generic;
using System.Text;

namespace Edabit_Answers
{
    /*
    //Answers.

     //Array of Multiples

            public static int[] Multiples(int num, int length)
        {
            int[] multiples = new int[length];

            for (int i = 0; i < length; i++)
            {
                multiples[i] = num * (i + 1);
            }
            return multiples;
        }


    //The Collatz Conjecture

    static void Main(string[] args)
        {
            Console.WriteLine(Counter(10));
        }

        public static int Counter(int num)
        {
            int count = 0;
            while (num > 1)
            {
                if (num % 2 == 0)
                {
                    num /= 2;
                    count++;
                }
                else if (num % 2 != 0)
                {
                    num = num * 3 + 1;
                    count++;
                }
            }
            return count;
        }


    //Reverse the Case

     public static void Main()
        {
            string str1;
            char[] arr1;
            int l, i;
            l = 0;
            char ch;
            Console.Write("\n\nReplace lowercase characters by uppercase and vice-versa :\n");
            Console.Write("--------------------------------------------------------------\n");
            Console.Write("Input the string : ");
            str1 = Console.ReadLine();
            l = str1.Length;
            arr1 = str1.ToCharArray(0, l);

            Console.Write("\nAfter conversion, the string is : ");
            for (i = 0; i < l; i++)
            {
                ch = arr1[i];
                if (Char.IsLower(ch)) 
                    Console.Write(Char.ToUpper(ch));
                else
                    Console.Write(Char.ToLower(ch)); 
            }
            Console.Write("\n\n");
        }


    //Find the Characters Counterpart Char Code

     public static void Main()
        {
            Console.WriteLine(CounterpartCharCode('A'));
            Console.WriteLine(CounterpartCharCode('a'));
            Console.WriteLine(CounterpartCharCode('B'));
        }

        public static int CounterpartCharCode(char symbol)
        {
            if (char.IsLower(symbol))
                symbol = char.ToUpper(symbol);
            else
                symbol = char.ToLower(symbol);

            return (int)symbol;
        }



    //Equality Check

    public static void Main()
        {
            Console.WriteLine(CheckEquality(1, true));
            Console.WriteLine(CheckEquality(0,"0"));
            Console.WriteLine(CheckEquality(1,1));
        }

		public static bool CheckEquality(object a, object b)
		{
			bool equality = false;
			if (a.GetType() == b.GetType())
			{
				if (a.Equals(b))
				{
					equality = true;
				}
			}
			return equality;
		}


    //Find the Largest Numbers in a Group of Arrays

    public static double[] FindLargest(double[][] values)
        {
            var outputArr = new double[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                outputArr[i] = values[i].Max();
            }
            return outputArr;
        }


    //A Circle and Two Squares

     public static void Main()
        {
            Console.WriteLine(square_areas_difference(6));
            Console.WriteLine(square_areas_difference(7));
            Console.WriteLine(square_areas_difference(17));
        }

        public static int square_areas_difference(int radius)
        {
            int big = (radius + radius) * (radius + radius);
            int small = (radius * radius) * 2;
            return big - small;
        }
    }


    //Convert All Array Items to String

    public static string[] ParseArray(object[] arr)
		{
			string[] output = new string[arr.Length];

			int i = 0;
			foreach (object o in arr)
			{
				output[i] = o.ToString();
				i++;
			}
			return output;
		}


    //Find the Bomb

    public static void Main()
        {
            Console.WriteLine(Bomb("There is a bomb."));
			Console.WriteLine(Bomb("Hey, did you think there is a bomb?"));
			Console.WriteLine(Bomb("This goes boom!!!"));
		}

		public static string Bomb(string str)
		{
			return str.ToLower().Contains("bomb") ? "Duck!!!" : "There is no bomb, relax.";
		}


    //Count Ones in Binary Representation of Integer

      public static void Main()
        {
            Console.WriteLine(Binary(12));
			Console.WriteLine(Binary(100));
			Console.WriteLine(Binary(999));
		}

		public static int Binary(int num)
		{
			int count = 0;
			string binary = Convert.ToString(num, 2);
            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '1')
                {
                    count++;
                }
            }
            return count;
		}



    //Pentagonal Number

     public static void Main()
        {
            Console.WriteLine(pentagonal(1));
            Console.WriteLine(pentagonal(3));
            Console.WriteLine(pentagonal(8));
        }

        public static int pentagonal(int num)
        {
            return (5 * num * num - 5 * num + 2) / 2;
        }


    //Return the Middle Character(s) of a String

    public static void Main()
        {
            Console.WriteLine(MidChar("test"));
            Console.WriteLine(MidChar("money"));
            Console.WriteLine(MidChar("middle"));
            Console.WriteLine(MidChar("A"));

        }

        public static string MidChar(string str)
        {
             int mid = str.Length / 2;
            if (str.Length % 2 == 0)
            {
                return str.Substring((str.Length / 2) - 1, 2);
            }
            else if (str.Length % 2 != 0)
            {
                return str.Substring((str.Length / 2), 1);
            }
            return str;
        }


    //Solve the Equation

    public static void Main()
        {
            Console.WriteLine(Equation("1+1"));
            Console.WriteLine(Equation("7*4-2"));
            Console.WriteLine(Equation("1+1+1+1+1"));
            Console.WriteLine(Equation("5+5/2"));

        }

        public static int Equation(string str)
        {
            return Convert.ToInt32(new DataTable().Compute(str, null));
        }


    //Filter out Strings from an Array

     public static void Main()
        {
            Console.WriteLine(FilterArray(new object[] { 1, 2, "a", "b" }));
            Console.WriteLine(FilterArray(new object[] { 1, "a", "b", 0, 15 }));
            Console.WriteLine(FilterArray(new object[] { 1, 2, "aasf", "1", "123", 123 }));
            Console.WriteLine(FilterArray(new object[] { "jsyt", 4, "yt", 6 }));
        }

        public static int[] FilterArray(object[] arr)
        {
            var ints = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] is Int32)
                {
                    ints.Add((int)arr[i]);
                }
            }
            return ints.ToArray();
        }


    //Maskify the String

     public static void Main()
        {
            Console.WriteLine(Maskify("4556364607935616"));
            Console.WriteLine(Maskify("64607935121"));
            Console.WriteLine(Maskify("1"));
            Console.WriteLine(Maskify(""));
        }

        public static string Maskify(string str)
        {
            int amountOfStars = str.Length - 4;
            if (str.Length > 4)
            {
                return string.Concat("".PadLeft(amountOfStars, '*'),str.Substring(amountOfStars));
            }
            return str;
        }


    //Odd and Even more then two

     static void Main(string[] args)
        {
            Console.WriteLine(OddAndEven(new[] { 5, 5, 5, 5, 5 }));
            Console.WriteLine(OddAndEven(new[] { 1, 2, 3, 4 }));
            Console.WriteLine(OddAndEven(new[] { 3, 3, 5, 5, 5, 5 }));
            Console.WriteLine(OddAndEven(new[] { 1, 5, 5, 7, 8, 10 }));
        }

        public static bool OddAndEven(int[] nums)
        {
            int oddNum = 0, evenNum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (oddNum < 2 && evenNum < 2)
                {
                    if (nums[i] % 2 == 0)
                    {
                        evenNum++;
                        oddNum = 0;
                    }
                    else
                    {
                        oddNum++;
                        evenNum = 0;
                    }
                }
            }
            return oddNum == 2 || evenNum == 2;
        }



    //Bool

    static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 3, 5, 5, 3, 7 }));
            Console.WriteLine(test(new[] { 3, 5, 5, 4, 1, 5, 7 }));
            Console.WriteLine(test(new[] { 3, 5, 5, 5, 5, 5 }));
            Console.WriteLine(test(new[] { 2, 4, 5, 5, 6, 7, 5 }));
        }

        public static bool test(int[] nums)
        {
            bool flag = true;
            int arrayLen = nums.Length;

            for (int i = 0; i < arrayLen; i++)
            {
                if (nums[i] == 5)
                {
                    if ((i > 0 && nums[i - 1] == 5) || (i < arrayLen - 1 && nums[i + 1] == 5))
                    {
                        flag = true;
                    }
                    else return false;
                }
            }
            return flag;
        }



    //Shift first to last

     static void Main(string[] args)
        {
            int[] item = shift(new[] { 10, 20, -30, -40, 50 });
            Console.Write("New array: ");
            foreach (var i in item)
            {
                Console.Write(i.ToString() + " ");
            }
        }

        public static int[] shift(int[] nums)
        {
            int size = nums.Length;
            int[] shiftNums = new int[size];

            for (int i = 0; i < size; i++)
            {
                shiftNums[i] = nums[(i + 1) % size];
            }
            return shiftNums;
        }



    //

    static void Main(string[] args)
        {
            int[] item = test(new[] { 1, 2, 3, 5, 7, 9, 10 }, 3);
            Console.Write("New array: ");
            foreach (var i in item)
            {
                Console.Write(i.ToString() + " ");
            }
        }

        public static int[] test(int[] nums, int count)
        {
            int[] evens = new int[count];
            int j = 0;
            for (int i = 0; j < count; i++)
            {
                if (nums[i] % 2 != 0)
                {
                    evens[j] = nums[i];
                    j++;
                }
            }
            return evens;
        }



    //Compare the inputs

     static void Main(string[] args)
        {

            Console.WriteLine(Compare(78, 95));
            Console.WriteLine(Compare(20, 30));
            Console.WriteLine(Compare(21, 25));
            Console.WriteLine(Compare(28, 28));

            Console.ReadLine();
        }

        public static int Compare(int x, int y)
        {
            if (x <= 30 && y >= 20 || x >= 20 && y <= 30)
            {
                var max = Math.Max(x, Math.Max(x, y));
                return max;
            }
            return 0;
        }



    //last 3 chars converts to upper case
    static void Main(string[] args)
        {

            Console.WriteLine(test("Python"));
            Console.WriteLine(test("Javascript"));
            Console.WriteLine(test("js"));
            Console.WriteLine(test("PHP"));

            Console.ReadLine();
        }

        public static string test(string str)
        {
            if (str.Length > 2)
            {
                return str.Remove(str.Length - 3) + str.Substring(str.Length - 3).ToUpper();
            }
            return str.ToUpper();
        }



    // copies n time the string
    static void Main(string[] args)
        {

            Console.WriteLine(test("JS",2));
            Console.WriteLine(test("JS",3));
            Console.WriteLine(test("jS",1));
            Console.WriteLine(test("JS",4));

            Console.ReadLine();
        }

        public static string test(string str, int n)
        {
            string result = String.Empty;
            for (int i = 0; i < n; i++)
            {
                result += str;
            }
            return result;
        }



    //every other char is output.
    static void Main(string[] args)
        {
            Console.WriteLine(Test("Python"));
            Console.WriteLine(Test("PHP"));
            Console.WriteLine(Test("JS"));

            Console.ReadLine();
        }

        public static string Test(string str)
        {
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (i % 2 == 0)
                {
                    result += str[i];
                }
            }
            return result;
        }



    //

    static void Main(string[] args)
        {
            int[] item = test(new[] { 1, 2, 5, 3, 5, 7, 5, 9, 11 });
            Console.Write("New array: ");
            foreach (var i in item)
            {
                Console.Write(i.ToString() + " ");
            }
        }

        public static int[] test(int[] nums)
        {
            int size = nums.Length, index = 0;
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                if (nums[i] != 5)
                {
                    array[index] = nums[i];
                }
            }
            return array;
        }


    //Hashtag before and after

     static void Main(string[] args)
        {
            List<string> mylist = Hashtag(new List<string>(new string[] { "1", "2", "3", "4" }));
            foreach (var i in mylist)
            {
                Console.Write(i.ToString() + " ");
            }
        }

        public static List<string> Hashtag(List<string> str)
        {
            IEnumerable<string> s = str.Select(x => "#" + x + "#");
            return s.ToList();
        }



    //Compares how many same chars placed in same pos in strings

    static void Main(string[] args)
        {
            Console.WriteLine(Compare("abcdefgh", "abijsklm"));
            Console.WriteLine(Compare("abcde", "osuefrcd"));
            Console.WriteLine(Compare("pqrstuvwx", "pqkdiewx"));
            Console.ReadLine();
        }

        public static int Compare(string str1, string str2)
        {
            var counter = 0;
            for (int i = 0; i < str1.Length - 1; i++)
            {
                var firstString = str1.Substring(i, 2);
                for (int j = 0; j < str2.Length - 1; j++)
                {
                    var secoundString = str2.Substring(j, 2);
                    if (firstString == secoundString)
                        counter++;
                }
            }
            return counter;
        }



    //ReverseAndNot

    static void Main(string[] args)
        {
            Console.WriteLine(ReverseAndNot(123));
            Console.WriteLine(ReverseAndNot(632156));
            Console.WriteLine(ReverseAndNot(989898762));
        }

        public static string ReverseAndNot(int i)
        {
            string str_i = i.ToString();
            string rev_str_i = new string(str_i.Reverse().ToArray());
            return rev_str_i + str_i;
        }



    //Power Ranger

    static void Main(string[] args)
        {
            Console.WriteLine(PowerRanger(2, 49, 65));
            Console.WriteLine(PowerRanger(3, 1, 27));
            Console.WriteLine(PowerRanger(10, 1, 5));
            Console.WriteLine(PowerRanger(4, 250, 1300));
        }

        public static int PowerRanger(int power, int min, int max)
        {
            int counter = 0;
            for (int i = min; i <= max; i++)
            {
                if (Math.Pow(i, 1.0 / power) % 1 == 0) counter++;
            }
            return counter;
        }



    //Find the Vertex of a Quadratic

            static void Main(string[] args)
        {
            Console.WriteLine(FindVertex(2, 49, 65));
            Console.WriteLine(FindVertex(3, 1, 27));
            Console.WriteLine(FindVertex(10, 1, 5));
            Console.WriteLine(FindVertex(4, 250, 1300));
        }

        public static double[] FindVertex(int a, int b, int c)
        {
            var x = (double)(-b) / (2 * a);
            return new double[] { x, a * x * x + b * x + c };
        }



    //Smooth Sentences

    static void Main(string[] args)
        {
            Console.WriteLine(IsSmooth("Marta appreciated deep perpendicular right trapezoids"));
            Console.WriteLine(IsSmooth("Someone is outside the doorway"));
            Console.WriteLine(IsSmooth("She eats super righteously"));
            Console.WriteLine(IsSmooth("Mad dislikes sharp pointy yoyos"));
        }

        public static bool IsSmooth(string sentence)
        {
            var arr = sentence.Split(' ');
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (Char.ToLower(arr[i].Last()) != Char.ToLower(arr[i + 1].First()))
                    return false;
            }
            return true;
        }



    //Next Prime

     static void Main(string[] args)
        {
            Console.WriteLine(NextPrime(1));
            Console.WriteLine(NextPrime(12));
            Console.WriteLine(NextPrime(22));
            Console.WriteLine(NextPrime(33));
        }

        public static int NextPrime(int num)
        {
            int nextP = num;

            while (!IsPrime(nextP))
            {
                nextP++;
            }

            return nextP;
        }

        private static bool IsPrime(int n)
        {
            if (n < 2) return false;

            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }



    //Valid Hex Code

     static void Main(string[] args)
        {
            Console.WriteLine(IsValidHexCode("#EAECEE"));
            Console.WriteLine(IsValidHexCode("#CD5C5C"));
            Console.WriteLine(IsValidHexCode("#eaecee"));
            Console.WriteLine(IsValidHexCode("#CD5C&C"));
        }

        public static bool IsValidHexCode(string str)
        {
            Regex rgx = new Regex(@"#[A-Fa-f0-9]{6}$");
            return rgx.IsMatch(str);
        }



    //Is the Die Loaded

    static void Main(string[] args)
        {
            Console.WriteLine(FairDie(new[] { 44, 52, 33, 40, 41, 30 }));
            Console.WriteLine(FairDie(new[] { 34, 27, 23, 20, 32, 28 }));
            Console.WriteLine(FairDie(new[] { 10, 20, 11, 5, 19, 16 }));
            Console.WriteLine(FairDie(new[] { 10, 20, 11, 5, 19, 16 }));
        }

        public static bool FairDie(int[] arr)
        {
            var exp = arr.Sum() / arr.Length;
            return arr.Sum(n => Math.Pow(n - exp, 2)) / exp < 11.07;
        }



    //A Week Later

        static void Main(string[] args)
        {
            Console.WriteLine(WeekAfter("01/01/2021"));
            Console.WriteLine(WeekAfter("01/01/2000"));
            Console.WriteLine(WeekAfter("21/12/1989"));
            Console.WriteLine(WeekAfter("12/03/2020"));
        }

        public static string WeekAfter(string date)
        {
            var dmy = date.Split('/').Select(s => int.Parse(s)).ToArray();
            var dat = new DateTime(dmy[2], dmy[1], dmy[0]).AddDays(7);
            return $"{dat.Day:00}/{dat.Month:00}/{dat.Year}";
        }



    //3n + 1 Problem (Collatz Conjecture)

            static void Main(string[] args)
        {
            Console.WriteLine(Collatz(10, 15));
            Console.WriteLine(Collatz(53782, 72534));
            Console.WriteLine(Collatz(72221, 11198));
            Console.WriteLine(Collatz(1723817263, 837249873748));
        }

        public static string Collatz(Int64 a, Int64 b)
        {
            while (true)
            {
                if (a == 1) return "a";
                if (b == 1) return "b";
                a = a % 2 == 0 ? a / 2 : 3 * a + 1;
                b = b % 2 == 0 ? b / 2 : 3 * b + 1;
            }
        }



    //C*ns*r*d Str*ngs

    static void Main(string[] args)
        {
            Console.WriteLine(Uncensor("Wh*r* d*d my v*w*ls g*?", "eeioeo"));
            Console.WriteLine(Uncensor("abcd", ""));
            Console.WriteLine(Uncensor("*PP*RC*S*", "UEAE"));
            Console.WriteLine(Uncensor("Ch**s*, Gr*mm*t -- ch**s*", "eeeoieee"));
        }

		public static string Uncensor(string txt, string vowels)
		{
			StringBuilder sb = new StringBuilder(); int index = 0;
			for (int i = 0; i < txt.Length; i++)
			{
				if (txt[i] == '*')
				{
					sb.Append(vowels[index]); index++;
				}
				else sb.Append(txt[i]);
			}
			return sb.ToString();
		}



    //Reverse Coding Challenge #1

            static void Main(string[] args)
        {
            Console.WriteLine(MysteryFunc("A4B5C2"));
            Console.WriteLine(MysteryFunc("C2F1E5"));
            Console.WriteLine(MysteryFunc("T4S2V2"));
            Console.WriteLine(MysteryFunc("A1B2C3D4"));
        }

        public static string MysteryFunc(string str)
        {
            string answer = "";
            for (int i = 0; i < str.Length; i = i + 2)
            {
                answer = answer + new string(str[i], (int)char.GetNumericValue(str[i + 1]));
            }

            return answer;
        }



    //Convert to Hex

    static void Main(string[] args)
        {
            Console.WriteLine(ConvertToHex("hello world"));
            Console.WriteLine(ConvertToHex("Big Boi"));
            Console.WriteLine(ConvertToHex("Marty Poppinson"));
            Console.WriteLine(ConvertToHex("abcdefghi"));
        }

        public static string ConvertToHex(string inputword)
        {
            return inputword.ToCharArray().Aggregate("", (a, b) => a + ((byte)b).ToString("X") + " ").ToLower().Trim();
        }



    //Clear Brackets

    static void Main(string[] args)
        {
            Console.WriteLine(Brackets("(a*(b-c)..... )"));
            Console.WriteLine(Brackets(")(a-b-45/7*(a-34))"));
            Console.WriteLine(Brackets("sin(90...)+.............cos1)"));
            Console.WriteLine(Brackets(")))((("));
        }

        public static bool Brackets(string str)
        {
            int checker = 0;
            var brackets = str.Where(x => x == '(' || x == ')').ToArray();
            if (brackets.Count() == 0)
                return true;
            for (int i = 0; i < brackets.Count(); i++)
            {
                if (brackets[i] == '(')
                    checker++;
                else
                    checker--;
                if (checker < 0)
                    return false;
            }
            return true;
        }



    //Sock Pairs

     static void Main(string[] args)
        {
            Console.WriteLine(SockPairs("AA"));
            Console.WriteLine(SockPairs("ABABC"));
            Console.WriteLine(SockPairs("CABBACCC"));
            Console.WriteLine(SockPairs("AAACCBB"));
        }

        public static int SockPairs(string socks)
        {
            int cnt = 0;
            char[] arr = socks.ToCharArray();
            Array.Sort(arr);

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1])
                {
                    cnt++;
                    i++;
                }
            }

            return cnt;
        }



    //Reverse Coding Challenge #5

            static void Main(string[] args)
        {
            Console.WriteLine(MysteryFunc(832));
            Console.WriteLine(MysteryFunc(51));
            Console.WriteLine(MysteryFunc(7977));
            Console.WriteLine(MysteryFunc(1));
        }

        public static int MysteryFunc(int num)
        {
            List<char> a = new List<char>(num.ToString().ToList());
            a.Sort();
            int x = 0;
            int i = a.Count - 1;
            foreach (var stuff in a)
            {
                x += Convert.ToInt32(Math.Pow(10, i) * char.GetNumericValue(stuff));
                i--;
            }
            return num - x;
        }



    //Consecutive Numbers

            static void Main(string[] args)
        {
            Console.WriteLine(Cons(new[] { 5, 1, 4, 3, 2 }));
            Console.WriteLine(Cons(new[] { 5, 1, 4, 3, 2, 8 })); 
            Console.WriteLine(Cons(new[] { 5, 6, 7, 8, 9, 9 }));
            Console.WriteLine(Cons(new[] { 5, 3 }));
        }

        public static bool Cons(int[] arr)
        {
            Array.Sort(arr);
            for (int i = 1; i < arr.Length; i++)
                if (arr[i] - arr[i - 1] != 1)
                    return false;
            return true;
        }



    //Count the Number of Duplicate Characters

            static void Main(string[] args)
        {
            Console.WriteLine(DuplicateCount("abcde"));
            Console.WriteLine(DuplicateCount("aabbcde")); 
            Console.WriteLine(DuplicateCount("Indivisibilities"));
            Console.WriteLine(DuplicateCount("Aa"));
        }

        public static int DuplicateCount(string str) =>
            str.GroupBy(c => c).Count(x => x.Count() > 1);



    //Creating a Picture Frame

     static void Main(string[] args)
        {
            Console.WriteLine(GetFrame(4, 5, '#'));
            Console.WriteLine(GetFrame(10, 3, '*')); 
            Console.WriteLine(GetFrame(2, 5, '0'));
            Console.WriteLine(GetFrame(3, 2, '$'));
        }

        public static string[] GetFrame(int w, int h, char ch)
        {
            if (w < 3 || h < 3)
                return new string[] { "invalid" };
            string[] res = new string[h];
            for (int i = 0; i < h; i++)
                if (i == 0 || i == h - 1)
                    res[i] = new string(ch, w);
                else
                    res[i] = ch.ToString() + new string(' ', w - 2) + ch.ToString();
            return res;
        }



    //Longest Common Ending

    static void Main(string[] args)
        {
            Console.WriteLine(LongestCommonEnding("multiplication", "ration"));
            Console.WriteLine(LongestCommonEnding("potent", "tent")); 
            Console.WriteLine(LongestCommonEnding("skyscraper", "carnivore"));
            Console.WriteLine(LongestCommonEnding("skyscraper", "carnivore"));
        }

        public static string LongestCommonEnding(string str1, string str2)
        {
            for (int i = 0; i < str1.Length; i += 1)
            {
                string subStr = str1.Substring(i);
                if (str2.EndsWith(subStr))
                {
                    return subStr;
                }
            }
            return "";
        }



    //Find Number of Repetitions of Substring

    static void Main(string[] args)
        {
            Console.WriteLine(NumberOfRepeats("abcabcabcabc"));
            Console.WriteLine(NumberOfRepeats("bcbcbc")); 
            Console.WriteLine(NumberOfRepeats("llbllbllbllbllbllb"));
            Console.WriteLine(NumberOfRepeats("kc"));
        }

		public static int NumberOfRepeats(string str)
		{
			for (int i = 2; i <= str.Length / 2; i++)
			{
				var nr = str.Length / i;
				if (str.Length % i == 0 && new string('?', nr).Replace("?", str.Substring(0, i)) == str)
				{
					return nr;
				}
			}
			return 1;
		}



    //Almost Palindrome

            static void Main(string[] args)
        {
            Console.WriteLine(AlmostPalindrome("abcdcbg"));
            Console.WriteLine(AlmostPalindrome("abccia")); 
            Console.WriteLine(AlmostPalindrome("abcdaaa"));
            Console.WriteLine(AlmostPalindrome("1234312"));
        }

        public static bool AlmostPalindrome(string str)
        {
            int count = 0;
            string reversedStr = string.Join("", str.Reverse());
            for (int i = 0; i < str.Length; i++)
                if (reversedStr[i] != str[i])
                    count++;
            return count == 2;
        }



    //Reversing a Binary String

            static void Main(string[] args)
        {
            Console.WriteLine(reversedBinaryInteger(10));
            Console.WriteLine(reversedBinaryInteger(12)); 
            Console.WriteLine(reversedBinaryInteger(25));
            Console.WriteLine(reversedBinaryInteger(45));
        }

        public static int reversedBinaryInteger(int num)
        {
            string s = Convert.ToString(num, 2);
            char[] array = s.ToCharArray();
            Array.Reverse(array);
            s = new string(array);
            return Convert.ToInt32(s, 2);
        }



    //Replace Letters With Position In Alphabet

            static void Main(string[] args)
        {
            Console.WriteLine(AlphabetIndex("Wow, does that work?"));
            Console.WriteLine(AlphabetIndex("The river stole the gods.")); 
            Console.WriteLine(AlphabetIndex("We have a lot of rain in June."));
            Console.WriteLine(AlphabetIndex("Lets all be unique together until we realise we are all the same."));
        }

        public static string AlphabetIndex(string str)
        {
            var alphabet = "_abcdefghijklmnopqrstuvwxyz";
            var indexStr = new StringBuilder();

            foreach (char c in str.ToLower())
            {
                if (Char.IsLetter(c))
                {
                    indexStr.Append(alphabet.IndexOf(c) + " ");
                }
            }

            return indexStr.ToString().Trim();
        }



    //Nth Fibonacci Number

            static void Main(string[] args)
        {
            Console.WriteLine(Fibonacci(10));
            Console.WriteLine(Fibonacci(20)); 
            Console.WriteLine(Fibonacci(30));
            Console.WriteLine(Fibonacci(40));
        }

        public static string Fibonacci(int n)
        {
            BigInteger a = 0;
            BigInteger b = 1;
            BigInteger c = 1;
            for (int i = 0; i < n; i++)
            {
                c = a;
                a = b;
                b += c;
            }
            return a.ToString();
        }



    //Print Grid

    static void Main(string[] args)
        {
            Console.WriteLine(PrintGrid(3,6));
            Console.WriteLine(PrintGrid(5,3)); 
            Console.WriteLine(PrintGrid(4,1));
            Console.WriteLine(PrintGrid(1,3));
        }

        public static int[,] PrintGrid(int rows, int cols)
        {
            var res = new int[rows, cols];
            for (var r = 0; r < rows; r++)
            {
                for (var c = 0; c < cols; c++)
                {
                    res[r, c] = r + 1 + c * rows;
                }
            }
            return res;
        }



    //The Day Rob Was Born in Dutch

    static void Main(string[] args)
        {
            Console.WriteLine(WeekdayRobWasBornInDutch(1970, 9, 21));
            Console.WriteLine(WeekdayRobWasBornInDutch(1945, 9, 2)); 
            Console.WriteLine(WeekdayRobWasBornInDutch(2001, 9, 11));
            Console.WriteLine(WeekdayRobWasBornInDutch(2002, 5, 11));
        }

        public static string WeekdayRobWasBornInDutch(int year, int month, int day)
        {
            DateTime date = new DateTime(year, month, day);
            System.Globalization.CultureInfo dutch = new System.Globalization.CultureInfo("nl-NL");

            string myDay = dutch.DateTimeFormat.DayNames[(int)date.DayOfWeek];
            return myDay;
        }



    //Rhyme Time

     static void Main(string[] args)
        {
            Console.WriteLine(DoesRhyme("Sam I am!", "Green eggs and ham."));
            Console.WriteLine(DoesRhyme("Sam I am!", "Green eggs and HAM.")); 
            Console.WriteLine(DoesRhyme("You are off to the races", "a splendid day."));
            Console.WriteLine(DoesRhyme("and frequently do?", "you gotta move."));
        }

        public static bool DoesRhyme(string str1, string str2)
        {
            var vowels = new[] { 'a', 'e', 'i', 'o', 'u' };
            var firstLastWord = str1.ToLower().Split(' ').Last();
            var secondLastWord = str2.ToLower().Split(' ').Last();

            return vowels.Intersect(firstLastWord).SequenceEqual(vowels.Intersect(secondLastWord));
        }



    //Reverse Coding Challenge #2

    static void Main(string[] args)
        {
            Console.WriteLine(MysteryFunc(3));
            Console.WriteLine(MysteryFunc(9)); 
            Console.WriteLine(MysteryFunc(17));
            Console.WriteLine(MysteryFunc(24));
        }

        public static int MysteryFunc(int num)
        {
            int szam = 0;
            int hatvany = 1;

            while (num > hatvany * 2)
            {
                szam = szam * 10 + 2;
                hatvany = hatvany * 2;
            }
            return szam * 10 + num % hatvany;
        }



    //Difference Cipher

        static void Main(string[] args)
        {
            Console.WriteLine(Encrypt("Hello"));
            Console.WriteLine(Encrypt("The neighbours are strange..")); 
            Console.WriteLine(Encrypt("OK"));
            Console.WriteLine(Encrypt("Sunshine"));
			Console.WriteLine(Decrypt(new[] { 84, 20, -3, -69, 78, -9, 4, -2, 1, -6, 13, 6, -3, 1, -83, 65, 17, -13, -69, 83, 1, -2, -17, 13, -7, -2, -55, 0 }));
			Console.WriteLine(Decrypt(new[] { 73, 43, -77, 76, -83, 65, -65, 83, -14, -2, 15, -13, 15, -83 }));
		}

		public static int[] Encrypt(string str)
		{
			List<int> nums = new List<int> { str[0] };
			for (int i = 0; i < str.Length - 1; i++)
				nums.Add(str[i + 1] - str[i]);
			return nums.ToArray();
		}

		public static string Decrypt(int[] arr)
		{
			char last = (char)arr[0];
			return $"{last}{string.Join("", arr.Skip(1).Select(s => last = (char)(last + s)))}";
		}



    //Magic Square

            static Func<int, IEnumerable<int>> Range = (n) => Enumerable.Range(0, n);

        public static bool IsMagicSquare(int[][] arr)
        {
            var size = arr.Length;
            var magic = arr[0].Sum();
            return Range(size).All(r => Range(size).Sum(c => arr[r][c]) == magic)
                && Range(size).All(c => Range(size).Sum(r => arr[r][c]) == magic)
                && Range(size).Sum(r => arr[r][r]) == magic
                && Range(size).Sum(r => arr[size - r - 1][r]) == magic;
        }



    //XOR Cipher

            static void Main(string[] args)
        {
            Console.WriteLine(XORCipher("11", "22"));
            Console.WriteLine(XORCipher("1020304", "403201"));
            Console.WriteLine(XORCipher("c611d9bdd9de38b9eb", "23a0745505d4d25494"));
            Console.WriteLine(XORCipher("7d1e875da9d5e89b54c7eaf", "3541599be591709795cebd5"));
        }

        static Func<int, char> int2hex = n => n.ToString("x")[0];
        static Func<char, int> hex2int = h => int.Parse(h.ToString(), NumberStyles.HexNumber);
        static Func<char, char, char> XORHex = (first, second) => int2hex(hex2int(first) ^ hex2int(second));

        public static string XORCipher(string msg1, string msg2)
        {
            return new string(msg1.Zip(msg2, XORHex).ToArray());
        }



    //Dead End Number Sequence

            static void Main(string[] args)
        {
            Console.WriteLine(DeadEnd(5));
            Console.WriteLine(DeadEnd(11));
            Console.WriteLine(DeadEnd(12345));
            Console.WriteLine(DeadEnd(101));
        }

        public static long[] DeadEnd(long n)
        {
            var seq = new List<long>();
            while (!seq.Contains(n))
            {
                seq.Add(n);
                var s = (long)$"{n}".ToCharArray().Sum(c => c - '0');
                n = n % s > 0 ? n * s : n / s;
            }
            return new long[] { (long)seq.Count, seq.Last() };
        }



    //Consecutive Numbers

            static void Main(string[] args)
        {
            Console.WriteLine(IsThereConsecutive(new int[] { 1, 3, 5, 5, 3, 3, 1 }, 3, 2));
            Console.WriteLine(IsThereConsecutive(new int[] { 1, 2, 3, 4, 5 }, 1, 1));
            Console.WriteLine(IsThereConsecutive(new int[] { 1 }, 1, 0));
            Console.WriteLine(IsThereConsecutive(new int[] { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 0, 0 }, 5, 2));
        }

        public static bool IsThereConsecutive(int[] arr, int n, int times)
        {
            return times == 0
                ? !arr.Contains(n)
                : string.Join("", arr.Select(i => $"{i}").ToArray()).Contains(new string(n.ToString()[0], times));
        }



    //String Factoring

            static void Main(string[] args)
        {
            Console.WriteLine(StringFactor(new int[] { 2, 2, 2, 3, 3 }));
            Console.WriteLine(StringFactor(new int[] { 2, 7 }));
            Console.WriteLine(StringFactor(new int[] { 1, 1 }));
            Console.WriteLine(StringFactor(new int[] { 2, 3, 3 }));
        }

        public static string StringFactor(int[] arr)
        {
            return string.Join(" x ",
                arr
                    .GroupBy(i => i)
                    .Select(g => g.Count() > 1 ? $"{g.Key}^{g.Count()}" : $"{g.Key}")
            );
        }



    //Longest Abecedarian Word

            static void Main(string[] args)
        {
            Console.WriteLine(LongestAbecedarian(new string[] { "ace", "spades", "hearts", "clubs" }));
            Console.WriteLine(LongestAbecedarian(new string[] { "forty", "choppy", "ghost" }));
            Console.WriteLine(LongestAbecedarian(new string[] { "one", "two", "three" }));
            Console.WriteLine(LongestAbecedarian(new string[] { "aa bbb cccc" }));
        }

        public static string LongestAbecedarian(string[] arr)
        {
            return arr
                .Where(w => w == new string(w.ToCharArray().OrderBy(c => c).ToArray()))
                .OrderByDescending(w => w.Length)
                .FirstOrDefault() ?? "";
        }



    //True Alphabetical Order

            static void Main(string[] args)
        {
            Console.WriteLine(TrueAlphabetic("hello world"));
            Console.WriteLine(TrueAlphabetic("edabit is awesome"));
            Console.WriteLine(TrueAlphabetic("have a nice day"));
            Console.WriteLine(TrueAlphabetic("joshua senoron"));
        }

        public static string TrueAlphabetic(string str)
        {
            var q = str.Replace(" ", "")
                    .ToCharArray()
                    .OrderByDescending(c => c);
            var letters = new Stack<char>(q.ToArray());
            var q2 = Enumerable
                .Range(0, str.Length)
                .Select(i => str[i] == ' ' ? ' ' : letters.Pop());
            return new string(q2.ToArray());
        }



    //Imaginary Coding Interview

            static void Main(string[] args)
        {
            Console.WriteLine(Interview(new int[] { 5, 5, 10, 10, 15, 15, 20, 20 }, 120 ));
            Console.WriteLine(Interview(new int[] { 2, 3, 8, 6, 5, 12, 10, 18 }, 120));
            Console.WriteLine(Interview(new int[] { 2, 3, 8, 6, 5, 12, 10, 18 }, 64));
            Console.WriteLine(Interview(new int[] { 5, 5, 10, 10, 15, 20, 50 }, 160));
        }

        public static string Interview(int[] arr, int tot)
        {
            var timeLimits = new int[] { 5, 5, 10, 10, 15, 15, 20, 20 };
            return arr.Zip(timeLimits, (a, b) => a <= b).Count(s => s) == 8 && tot <= 120
                ? "qualified"
                : "disqualified";
        }



    //camelCase ⇄ snake_case

    static void Main(string[] args)
        {
            Console.WriteLine(ToSnakeCase("hello_edabit"));
            Console.WriteLine(ToSnakeCase("helloEdabit"));
            Console.WriteLine(ToSnakeCase("is_modal_open"));
            Console.WriteLine(ToSnakeCase("getColor"));
        }

        public static string ToSnakeCase(string str)
        {
            return Regex.Replace(str, "[A-Z]", "_$0").ToLower();
        }
        public static string ToCamelCase(string str)
        {
            return Regex.Replace(str, "_[a-z]", delegate (Match m) {
                return m.ToString().TrimStart('_').ToUpper();
            });
        }



    //Parseltongue

            static void Main(string[] args)
        {
            Console.WriteLine(IsParselTongue("Sshe ssselects to eat that apple. "));
            Console.WriteLine(IsParselTongue("She ssselects to eat that apple. "));
            Console.WriteLine(IsParselTongue("Beatrice samples lemonade"));
            Console.WriteLine(IsParselTongue("You ssseldom sssspeak sso boldly, ssso messmerizingly."));
        }

        public static bool IsParselTongue(string sentence)
        {
            string[] words = sentence.Split(' ');
            int parsel = 0;
            int temp = 0;

            for (int i = 0; i < words.Length; i++)
            {
                if (!words[i].ToLower().Contains('s')) parsel++;
                for (int m = 0; m < words[i].Length - 1; m++)
                {
                    if (Char.ToLower(words[i][m]) == 's' && Char.ToLower(words[i][m + 1]) == 's') temp++;
                }
                if (temp > 0) parsel++;
                temp = 0;

            }
            Console.WriteLine(words.Length);
            Console.WriteLine(parsel);

            return parsel == words.Length;
        }



    //Need Help With Your Packing?

            static void Main(string[] args)
        {
            Console.WriteLine(CanFit(new int[] { 2, 1, 2, 5, 4, 3, 6, 1, 1, 9, 3, 2 }, 4));
            Console.WriteLine(CanFit(new int[] { 7, 1, 2, 6, 1, 2, 3, 5, 9, 2, 1, 2, 5 }, 5));
            Console.WriteLine(CanFit(new int[] { 2, 7, 1, 3, 3, 4, 7, 4, 1, 8, 2 }, 4));
            Console.WriteLine(CanFit(new int[] { 1, 3, 3, 3, 2, 1, 1, 9, 7, 10, 8, 6, 1, 2, 9 }, 8));
        }

        public static bool CanFit(int[] weights, int bags)
        {
            var total = weights.ToList().Aggregate((a, b) => a + b);
            var canCarry = bags * 10;
            return total <= canCarry;
        }



    //Triple + Double = So Much Trouble

            static void Main(string[] args)
        {
            Console.WriteLine(Trouble(451999277, 41177722899));
            Console.WriteLine(Trouble(1222345, 12345));
            Console.WriteLine(Trouble(666789, 12345667));
            Console.WriteLine(Trouble(33789, 12345337));
        }

        public static bool Trouble(long num1, long num2)
        {
            char nr = ' ';
            string nr1 = num1.ToString();
            string nr2 = num2.ToString();
            for (int i = 0; i < nr1.Length - 2; i++)
            {
                if (nr1[i] == nr1[i + 1] && nr1[i] == nr1[i + 2])
                {
                    nr = nr1[i];
                }
            }
            if (nr != ' ')
            {
                for (int j = 0; j < nr2.Length - 1; j++)
                {
                    if (nr2[j] == nr && nr2[j + 1] == nr)
                        return true;
                }
            }
            else return false;
            return false;
        }



    //Sum of Factors of Factors

            static void Main(string[] args)
        {
            Console.WriteLine(SumFF(69));
            Console.WriteLine(SumFF(12));
            Console.WriteLine(SumFF(420));
            Console.WriteLine(SumFF(619));
        }

        static IEnumerable<int> Factors(int n)
        {
            for (int i = 2; i < 1 + n / 2; i++)
            {
                if (n % i == 0) yield return i;
            }
        }

        public static int SumFF(int a)
        {
            return Factors(a).Select(f => Factors(f).Sum()).Sum();
        }



    //Average Word Length

            static void Main(string[] args)
        {
            Console.WriteLine(AverageWordLength("A B C."));
            Console.WriteLine(AverageWordLength("What a gorgeous day."));
            Console.WriteLine(AverageWordLength("Dude, this is so awesome!"));
            Console.WriteLine(AverageWordLength("Have you ever wondered what Saturn looks like?"));
        }

        public static double AverageWordLength(string str)
        {
            Regex rgx = new Regex("[^a-zA-Z0-9 -]");
            str = rgx.Replace(str, "");
            Console.WriteLine(str);

            string[] words = str.Split(' ');
            int total = 0;
            foreach (string word in words)
            {
                total += word.Length;
            }
            return Math.Round((double)total / words.Length, 2);
        }



    //Convert "Zero" and "One" to "1" and "0"

            static void Main(string[] args)
        {
            Console.WriteLine(TextToNumberBinary("zero one zero one zero one zero one"));
            Console.WriteLine(TextToNumberBinary("Zero one zero ONE zero one zero one"));
            Console.WriteLine(TextToNumberBinary("zero one zero one zero one zero one one two"));
            Console.WriteLine(TextToNumberBinary("zero one zero one zero one zero three"));
        }

        public static string TextToNumberBinary(string str)
        {
            string result = "";
            string[] nums = str.Split(' ');
            foreach (string s in nums)
            {
                if (s.ToLower() == "zero" || s.ToLower() == "one")
                {
                    if (s.ToLower() == "zero") result += "0";
                    if (s.ToLower() == "one") result += "1";
                }
                else
                {
                    continue;
                }
            }
            return result.Length % 8 == 0 ? result : result.Substring(0, result.Length - (result.Length % 8));
        }



    //Valid JavaScript Comments

    static void Main(string[] args)
        {
            Console.WriteLine(CommentsCorrect("//////"));
            Console.WriteLine(CommentsCorrect("/////"));
        }

        public static bool CommentsCorrect(string str)
        {
            if (str.Length % 2 != 0)
                return false;

            string curCommentSymbol = "";

            for (int i = 0; i < str.Length - 1; i++)
            {

                if (curCommentSymbol == "/*")
                {
                    string temp = str[i].ToString() + str[i + 1].ToString();

                    if (temp == curCommentSymbol)
                        return false;
                    else if (temp == "//")
                        return false;
                }


                curCommentSymbol = str[i].ToString() + str[i + 1].ToString();
                i++;

            }

            return true;
        }



    //Cup Swapping

            static void Main(string[] args)
        {
            Console.WriteLine(CupSwapping(new String[] { "AB", "CA" }));
            Console.WriteLine(CupSwapping(new String[] { "AB", "CA", "AB" }));
            Console.WriteLine(CupSwapping(new String[] { "AC", "CA", "CA", "AC" }));
            Console.WriteLine(CupSwapping(new String[] { "BA", "AC", "CA", "BC" }));
        }

        public static string CupSwapping(string[] swaps)
        {
            return swaps.Aggregate(
                  "B",
                  (curr, move) =>
                      move.Contains(curr) ? move.Replace(curr, "") : curr);
        }



    //Block the Square in Tic Tac Toe

    static void Main(string[] args)
        {
            Console.WriteLine(BlockPlayer(0,3));
            Console.WriteLine(BlockPlayer(0,4));
            Console.WriteLine(BlockPlayer(3,5));
            Console.WriteLine(BlockPlayer(2,1));
        }

        public static int BlockPlayer(int a, int b)
        {
            int[][] solutions = { new int[] { 0, 1, 2 }, new int[] { 3, 4, 5 }, new int[] { 6, 7, 8 }, new int[] { 0, 3, 6 }, new int[] { 1, 4, 7 }, new int[] { 2, 5, 8 }, new int[] { 0, 4, 8 }, new int[] { 2, 4, 6 } };
            int block = 0;
            for (int i = 0; i < solutions.Length; i++)
            {
                if (solutions[i].Contains(a) && solutions[i].Contains(b))
                {
                    block = Convert.ToInt32(string.Join("", solutions[i]).Replace(a.ToString(), "").Replace(b.ToString(), ""));
                    break;
                }
            }
            return block;
        }



    //Split the String into N Cases of Equal Length

            static void Main(string[] args)
        {
            Console.WriteLine(SplitNCases("Incomprehensible", 4));
            Console.WriteLine(SplitNCases("Unscrupulous", 2));
            Console.WriteLine(SplitNCases("Evaluation", 10));
            Console.WriteLine(SplitNCases("Fool's Errand", 20));
        }

        public static string[] SplitNCases(string input, int cases)
        {
            int len_input = input.Length;
            if (len_input % cases > 0)
                return new string[] { "Error" };
            int len_sub = len_input / cases;
            string[] res = new string[cases];
            for (int i = 0; i < cases; i++)
                res[i] = input.Substring(i * len_sub, len_sub);
            return res;
        }



    //Palindrome Timestamps

            static void Main(string[] args)
        {
            Console.WriteLine(PalendromeTimestamps(2, 12, 22, 4, 35, 10));
            Console.WriteLine(PalendromeTimestamps(12, 12, 12, 13, 13, 13));
            Console.WriteLine(PalendromeTimestamps(6, 33, 15, 9, 55, 10));
            Console.WriteLine(PalendromeTimestamps(10, 22, 01, 12, 22, 21));
        }

        public static int PalendromeTimestamps(int h1, int m1, int s1, int h2, int m2, int s2)
        {
            TimeSpan t = new TimeSpan(h1, m1, s1);
            TimeSpan second = new TimeSpan(0, 0, 1);
            TimeSpan end = new TimeSpan(h2, m2, s2);
            string str_t = t.ToString();
            string str_r = string.Concat(str_t.ToArray().Reverse());
            int count = str_t == str_r ? 1 : 0;
            while (t < end)
            {
                t = t.Add(second);
                str_t = t.ToString();
                str_r = string.Concat(str_t.ToArray().Reverse());
                count += str_t == str_r ? 1 : 0;
            }
            return count;
        }



    //Moran Numbers

    static void Main(string[] args)
        {
            Console.WriteLine(Moran(132));
            Console.WriteLine(Moran(133));
            Console.WriteLine(Moran(134));
            Console.WriteLine(Moran(135));
        }

        public static string Moran(int n)
        {
            int sum = n.ToString().Select(x => int.Parse(x.ToString())).Sum();
            if (IsPrime(n / sum)) return "M";
            if (n % sum == 0) return "H";
            return "Neither";
        }
        public static bool IsPrime(int n)
        {
            if (n <= 1) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;
            var boundary = (int)Math.Floor(Math.Sqrt(n));
            for (int i = 3; i <= boundary; i += 2)
                if (n % i == 0) return false;
            return true;
        }



     */

}
