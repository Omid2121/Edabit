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
            Console.WriteLine(HexagonalNumbers(1));
            Console.WriteLine(HexagonalNumbers(7));
            Console.WriteLine(HexagonalNumbers(19));
            Console.WriteLine(HexagonalNumbers(21));
        }

        public static string HexagonalNumbers(int n = 1)
        {
            var root = GetRoot(n);
            var isValid = Math.Abs(root - (int)root) == 0;
            return !isValid ? "Invalid" : GetCenteredHexagon(n).ToString();
        }

        private static StringBuilder GetCenteredHexagon(int n)
        {
            var sb = new StringBuilder();
            int x = 0, y = (int)GetRoot(n), length = (int)GetRoot(n) * 2 - 1;

            for (var i = 0; i < length; i++)
            {
                var sequence = GetRoot(n) + x;
                sb.Append(GetSpaces(y));

                for (var j = 0; j < sequence; j++)
                    sb.Append("o").Append(j != (int)sequence - 1 ? " " : "");

                sb.Append(GetSpaces(y)).Append(i != (int)length - 1 ? "\n" : "");

                if (i < GetRoot(n) - 1)
                {
                    x++;
                    y--;
                }

                if (!(i >= GetRoot(n) - 1)) continue;
                x--;
                y++;
            }
            return sb;
        }

        private static double GetRoot(int n)
        {
            return (3 + Math.Sqrt(12 * n - 3)) / 6;
        }

        private static string GetSpaces(int i)
        {
            var space = "";
            for (var j = 0; j < i; j++)
                space += " ";

            return space;
        }
    }
}