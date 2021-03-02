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
            Console.WriteLine(Solve(new int[] { 7, 2 }));
            Console.WriteLine(Solve(new int[] { 2, 7, 3 }));
            Console.WriteLine(Solve(new int[] { 1000, 1000, 1000, 1000, 1000 }));
            Console.WriteLine(Solve(new int[] { 823, 912, 345, 100000, 867, 222, 991, 3, 40000 }));
        }

		public static int Solve(int[] boxes)
		{
			int[][] mtx = new int[boxes.Length][];
			for (int i = 0; i < mtx.Length; i++)
			{
				mtx[i] = new int[boxes.Length];
				mtx[i][i] = boxes[i];
			}

			for (int k = 1; k < mtx.Length; k++)
			{
				for (int i = 0; i + k < mtx.Length; i++)
				{
					int j = i + k;
					mtx[i][j] = Math.Max(boxes[i] - mtx[i + 1][j], boxes[j] - mtx[i][j - 1]);
				}
			}
			return mtx[0][mtx.Length - 1];
		}
	}
}