using System;
using System.Linq;
using System.Data;
using System.Collections.Generic;


namespace Edabit_Answers
{
    class Program
    {
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
    }
}

