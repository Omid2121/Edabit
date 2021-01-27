using System;
using System.Linq;
using System.Data;
using System.Collections.Generic;


namespace Edabit_Answers
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine(Maskify("4556364607935616"));
            Console.WriteLine(Maskify("64607935121"));
            Console.WriteLine(Maskify("1"));
            Console.WriteLine(Maskify(""));
        }

        public static string Maskify(string str)
        {
            int amountOfStars = str.Length - 4;
            if (str.Length > 4)
            {
                return string.Concat("".PadLeft(amountOfStars, '*'),str.Substring(amountOfStars));
            }
            return str;
        }
    }
}
