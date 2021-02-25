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
            Console.WriteLine(WhatsTheTime("1110010000111011110101100100010100101001000011101111010010010001000111101110001110111"));
            Console.WriteLine(WhatsTheTime("1110111000101010010100010101010100101011100011101111010100010001010111101110000010111"));
            Console.WriteLine(WhatsTheTime("0100111000111011111000010100010101010000100011101110100001010100000111100010001110001"));
            Console.WriteLine(WhatsTheTime("1110111000111011100100010101000101111011100011101111000001010001010111101110001110111"));
        }

        public static string WhatsTheTime(string bitmap)
        {
            List<int> binary = new List<int>() { 31599, 11415, 29671, 29647, 23497, 31183, 18927, 29257, 31727, 31689 };
            List<string> array = new List<string>();
            for (int i = 0; i < 5; i++)
                array.Add(bitmap.Substring(i * 17, 17));
            string s1 = "", s2 = "", s3 = "", s4 = "";
            for (int i = 0; i < array.Count; i++)
            {
                s1 += array[i].Substring(0, 3);
                s2 += array[i].Substring(4, 3);
                s3 += array[i].Substring(10, 3);
                s4 += array[i].Substring(14, 3);
            }
            return string.Concat(binary.FindIndex(i => i == Convert.ToInt32(s1, 2)), binary.FindIndex(i => i == Convert.ToInt32(s2, 2)), ":"
                , binary.FindIndex(i => i == Convert.ToInt32(s3, 2)), binary.FindIndex(i => i == Convert.ToInt32(s4, 2)));
        }
    }
}