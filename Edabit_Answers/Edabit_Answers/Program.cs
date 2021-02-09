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
            Console.WriteLine(RollingCipher("abcd", 1));
            Console.WriteLine(RollingCipher("abcd", -1));
            Console.WriteLine(RollingCipher("abcd", 3));
            Console.WriteLine(RollingCipher("abcd", 26));
        }

        public static string RollingCipher(string str, int n)
        {
            Func<char, char> shiftChar = x =>
            {
                int newVal = (x - 97 + n) % 26;
                int shifted = (newVal < 0) ? 26 + newVal : newVal;
                return (char)(shifted + 97);
            };
            return string.Join("", str.Select(shiftChar));
        }
    }
}


