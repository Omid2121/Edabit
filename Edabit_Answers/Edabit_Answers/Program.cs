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
            Console.WriteLine(TapCode("greeting"));
            Console.WriteLine(TapCode("confrontation"));
            Console.WriteLine(TapCode("leadership"));
            Console.WriteLine(TapCode(".... .... ... .... ... ... .. .... .. .. .. ... .... ...."));
            Console.WriteLine(TapCode("... . ... .... ..... .... . . ... . .... .... ..... ...."));
        }

		public static string TapCode(string text)
		{
			string res = "";
			if (text[0] != '.')
			{
				text = text.Replace('k', 'c');
				for (int i = 0; i < text.Length; i++)
				{
					int n = text[i] - 'a' + (text[i] > 'k' ? 0 : 1);
					res += new String('.', n / 5 + (n % 5 == 0 ? 0 : 1));
					res += " ";
					res += new String('.', (n % 5 == 0 ? 5 : n % 5));
					res += (i < text.Length - 1) ? " " : "";
				}
				return res;
			}
			else
			{
				string[] parts = text.Split(' ');
				for (int i = 0; i < parts.Length; i += 2)
				{
					int n = ((parts[i].Length - 1) * 5
									 + parts[i + 1].Length
									 + (int)'a');
					if (n < (int)'k')
					{
						n -= 1;
					}
					res += (char)n;
				}
				return res;
			}
		}
	}
}


