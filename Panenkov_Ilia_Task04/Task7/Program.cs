using System;
using System.Text.RegularExpressions;

namespace Task7
{
    class MainClass
    {
		public static int Count(string str)
		{
			string pattern = @"((?:0?[0-9]|1[0-9]|2[0-3]):[0-5][0-9])";
			Regex regex = new Regex(pattern);
			MatchCollection match1 = regex.Matches(str);

			return match1.Count;

		}
        public static void Main(string[] args)
        {
			Console.WriteLine("Enter string: ");
			string str = Console.ReadLine();
			Count(str);
            
			Console.WriteLine($"Time is found {Count(str)} times");
        }
    }
}
