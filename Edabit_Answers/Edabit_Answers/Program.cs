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
            Console.WriteLine(ThreeSum(new int[] { 0, 1, -1, -1, 2 }));
            Console.WriteLine(ThreeSum(new int[] { 0, 0, 0, 5, -5 }));
            Console.WriteLine(ThreeSum(new int[] { 1, 2, 3 }));
            Console.WriteLine(ThreeSum(new int[1]));
        }

        public static List<int[]> ThreeSum(int[] arr)
        {
            List<int[]> res = new List<int[]>();
            for (int i = 0; i < arr.Length - 2; i++)
                for (int j = i + 1; j < arr.Length - 1; j++)
                    for (int k = j + 1; k < arr.Length; k++)
                        if (arr[i] + arr[j] + arr[k] == 0)
                        {
                            int[] triple = new int[] { arr[i], arr[j], arr[k] };
                            bool found = false;
                            foreach (int[] t in res)
                                if (t[0] == triple[0] && t[1] == triple[1] && t[2] == triple[2])
                                    found = true;
                            if (!found)
                                res.Add(triple);
                        }
            return res;
        }
    }
}