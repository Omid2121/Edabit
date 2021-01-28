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





     */

}
