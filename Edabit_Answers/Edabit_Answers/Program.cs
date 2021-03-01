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
            Console.WriteLine(LuckyTicket(2));
            Console.WriteLine(LuckyTicket(4));
            Console.WriteLine(LuckyTicket(12));
            Console.WriteLine(LuckyTicket(14));
        }

        public static long LuckyTicket(int n)
        {
            long total = 0;
            for (int i = 0; i <= n / 2 * 9; i++)
            {
                total += Step1(n / 2, i);
            }
            return total;
        }
        static int Step2(int num, int sum)
        {
            if (num == 0)
                return sum == 0 ? 1 : 0;
            if (sum == 0)
                return 1;

            int returnVal = 0;

            for (int i = 0; i <= 9; i++)
                if (sum - i >= 0)
                    returnVal += Step2(num - 1, sum - i);

            return returnVal;
        }
        static long Step1(int num, int sum)
        {
            long returnVal = 0;

            for (int i = 0; i <= 9; i++)
                if (sum - i >= 0)
                    returnVal += Step2(num - 1, sum - i);

            return returnVal * returnVal;
        }
    }
}