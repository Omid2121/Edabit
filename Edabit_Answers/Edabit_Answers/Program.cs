using System;
using System.Linq;
using System.Data;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Edabit_Answers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Collatz(10, 15));
            Console.WriteLine(Collatz(53782, 72534));
            Console.WriteLine(Collatz(72221, 11198));
            Console.WriteLine(Collatz(1723817263, 837249873748));
        }

        public static string Collatz(Int64 a, Int64 b)
        {
            while (true)
            {
                if (a == 1) return "a";
                if (b == 1) return "b";
                a = a % 2 == 0 ? a / 2 : 3 * a + 1;
                b = b % 2 == 0 ? b / 2 : 3 * b + 1;
            }
        }
    }
}

