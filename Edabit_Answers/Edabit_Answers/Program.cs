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
            Console.WriteLine(TrackRobot(">>.."));
            Console.WriteLine(TrackRobot("..<.<."));
            Console.WriteLine(TrackRobot("..<<..>>..<<..>>.."));
            Console.WriteLine(TrackRobot("<>>>><><<<><>>>><><<<><>>><>"));
            Console.WriteLine(TrackRobot("...................................................................................................."));
        }

		public static int[] TrackRobot(string steps)
		{
			var pos = steps.ToCharArray().Aggregate(new int[] { 0, 0, 0 }, (arr, ch) => {
				if (ch == '.')
				{
					if (arr[2] == 0) arr[0]++;
					else if (arr[2] == 1) arr[1]++;
					else if (arr[2] == 2) arr[0]--;
					else arr[1]--;
				}
				else
				{
					arr[2] = (arr[2] + (ch == '<' ? 1 : 5)) % 4;
				}
				return arr;
			});
			return new int[] { pos[0], pos[1] };
		}
	}
}