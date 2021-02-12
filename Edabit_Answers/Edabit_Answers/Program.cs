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
            Console.WriteLine(IncrementString("foo"));
            Console.WriteLine(IncrementString("foobar0009"));
            Console.WriteLine(IncrementString("foo099"));
            Console.WriteLine(IncrementString("foo9"));
        }

        public static string IncrementString(string txt)
        {
            int i = 0;
            int n = txt.Length;
            while (char.IsNumber(txt[n - 1 - i]))
                i++;
            if (i == 0)
                return txt + "1";
            string front_txt = txt.Substring(0, n - i);
            int num = int.Parse(txt.Substring(n - i)) + 1;
            string zeros = (i - num.ToString().Length) > 0 ? new String('0', (i - num.ToString().Length)) : "";
            return front_txt + zeros + num.ToString();
        }
    }
}


