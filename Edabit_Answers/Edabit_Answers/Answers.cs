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
     */

}
