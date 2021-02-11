using System;
using System.Linq;
using System.Data;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;
using System.Numerics;
using System.Globalization;

namespace Edabit_Answers
{
    class Program
    {
		static void Main(string[] args)
		{
			Console.WriteLine(Permutations("AB"));
			Console.WriteLine(Permutations("CD"));
			Console.WriteLine(Permutations("EF"));
			Console.WriteLine(Permutations("NOT"));
		}

		public static string Permutations(string s)
		{
			if (s.Length == 2)
			{
				char[] array = s.ToCharArray();
				Array.Reverse(array);
				return s + " " + new string(array);
			}
			else
			{
				string element = s.Substring(0, 1);
				string substring = s.Remove(0, 1);
				string[] permuated = Permutations(substring).Split(' ');
				string newString = "";
				foreach (string pattern in permuated)
				{
					for (int i = 0; i <= pattern.Length; i++)
					{
						newString = newString + pattern.Insert(i, element) + " ";
					}
				}
				string[] tempArray = newString.Remove(newString.Length - 1, 1).Split(' ');
				Array.Sort(tempArray);
				newString = String.Join(" ", tempArray);
				return newString;
			}

		}
	}
}


