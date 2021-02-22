using System;
using System.Linq;
using System.Data;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;
using System.Numerics;
using System.Globalization;
using System.Collections;

namespace Edabit_Answers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Farey(1));
            Console.WriteLine(Farey(3));
            Console.WriteLine(Farey(5));
            Console.WriteLine(Farey(13));
        }

		public static string[] Farey(int n)
		{
			var sortedElements = new SortedList();
			string fraction;
			for (int i = 0; i <= n; i++)
			{
				for (int j = i; j <= n; j++)
				{
					if (j == 0) continue;
					fraction = "" + i + "/" + j;
					if (!sortedElements.ContainsKey(i / (double)j))
					{
						sortedElements.Add(i / (double)j, fraction);
					}
				}
			}
			var values = sortedElements.GetValueList();
			var result = new string[sortedElements.Count];
			for (int i = 0; i < result.Length; i++)
			{
				result[i] = (string)values[i];
			}
			return result;
		}
	}
}