using System;
using System.Linq;
using System.Data;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace Edabit_Answers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetFrame(4, 5, '#'));
            Console.WriteLine(GetFrame(10, 3, '*')); 
            Console.WriteLine(GetFrame(2, 5, '0'));
            Console.WriteLine(GetFrame(3, 2, '$'));
        }

        public static string[] GetFrame(int w, int h, char ch)
        {
            if (w < 3 || h < 3)
                return new string[] { "invalid" };
            string[] res = new string[h];
            for (int i = 0; i < h; i++)
                if (i == 0 || i == h - 1)
                    res[i] = new string(ch, w);
                else
                    res[i] = ch.ToString() + new string(' ', w - 2) + ch.ToString();
            return res;
        }
    }
}


