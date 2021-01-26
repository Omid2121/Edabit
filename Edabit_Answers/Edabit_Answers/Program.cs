using System;

namespace Edabit_Answers
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine(ParseArray(new object[] { 1, 2, "a", "b" }));
            Console.WriteLine(ParseArray(new object[] { "abc", 123, "def", 456 }));
            Console.WriteLine(ParseArray(new object[] { 1, 2, 3, 17, 24, 3, "a", "123b" }));
        }

		public static string[] ParseArray(object[] arr)
		{
			string[] output = new string[arr.Length];

			int i = 0;
			foreach (object o in arr)
			{
				output[i] = o.ToString();
				i++;
			}
			return output;
		}
	}
}
