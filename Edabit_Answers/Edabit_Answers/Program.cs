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
            Console.WriteLine(Moran(132));
            Console.WriteLine(Moran(133));
            Console.WriteLine(Moran(134));
            Console.WriteLine(Moran(135));
        }

        public static string Moran(int n)
        {
            int sum = n.ToString().Select(x => int.Parse(x.ToString())).Sum();
            if (IsPrime(n / sum)) return "M";
            if (n % sum == 0) return "H";
            return "Neither";
        }
        public static bool IsPrime(int n)
        {
            if (n <= 1) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;
            var boundary = (int)Math.Floor(Math.Sqrt(n));
            for (int i = 3; i <= boundary; i += 2)
                if (n % i == 0) return false;
            return true;
        }
    }
}


