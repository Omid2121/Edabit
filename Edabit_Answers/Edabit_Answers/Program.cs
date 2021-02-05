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
    }
}


