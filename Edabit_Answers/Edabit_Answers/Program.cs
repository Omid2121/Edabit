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
            Console.WriteLine(DartsSolver(new int[] { 3, 6, 8, 11, 15, 19, 22 }, 3, 35));
            Console.WriteLine(DartsSolver(new int[] { 2, 4, 7, 10, 13, 18, 24 }, 3, 29));
            Console.WriteLine(DartsSolver(new int[] { 3, 7, 11, 14, 18, 20, 25 }, 3, 40));
            Console.WriteLine(DartsSolver(new int[] { 3, 7, 11, 14, 18, 20, 25 }, 3, 8));
        }

        public static string[] DartsSolver(int[] sections, int darts, int target)
        {
            HashSet<string> r = new HashSet<string>();
            int[] combination = new int[] { 0 };
            Array.Resize(ref combination, darts);
            int length = sections.Length;
            int sum_darts;
            int num;
            for (int i = 0; i < Math.Pow(length, darts); i++)
            {
                sum_darts = 0;
                num = i;
                for (int j = 0; j < darts; j++)
                {
                    combination[j] = num % length;
                    sum_darts += sections[combination[j]];
                    num /= length;
                }
                if (sum_darts == target)
                {
                    Array.Sort(combination);
                    string str = "";
                    foreach (int k in combination)
                        str += sections[k].ToString() + "-";
                    r.Add(str.Substring(0, str.Length - 1));
                }
            }
            string[] arr_r = r.ToArray();
            return arr_r;
        }
    }
}