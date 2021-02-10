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
			Console.WriteLine(SmallestTransform(399));
			Console.WriteLine(SmallestTransform(1234));
			Console.WriteLine(SmallestTransform(153));
			Console.WriteLine(SmallestTransform(7777));
		}

		public static int SmallestTransform(int num)
		{
			var digits = num.ToString().Select(c => Convert.ToInt32(c)).ToList();

			return digits.Distinct().Select(c => digits.Select(d => Math.Abs(d - c)).Sum()).Min();
		}
	}
}


