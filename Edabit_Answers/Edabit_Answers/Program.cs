using System;
using System.Linq;
using System.Data;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;
using System.Numerics;

namespace Edabit_Answers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MysteryFunc(3));
            Console.WriteLine(MysteryFunc(9)); 
            Console.WriteLine(MysteryFunc(17));
            Console.WriteLine(MysteryFunc(24));
        }

        public static int MysteryFunc(int num)
        {
            int szam = 0;
            int hatvany = 1;

            while (num > hatvany * 2)
            {
                szam = szam * 10 + 2;
                hatvany = hatvany * 2;
            }
            return szam * 10 + num % hatvany;
        }
    }
}


