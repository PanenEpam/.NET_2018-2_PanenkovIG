using System;
using System.Text.RegularExpressions;

namespace Task5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			Console.Write("Entter string: ");
			string TegString = Console.ReadLine();
			string TegPattern = @"(<.*?>)";

			Regex regex = new Regex(TegPattern);
			Console.Write($"\nReplase string: {regex.Replace(TegString, "_")}");
        }
    }
}
