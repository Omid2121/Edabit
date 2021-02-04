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
    }
}


