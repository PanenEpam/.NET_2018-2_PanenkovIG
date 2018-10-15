using System;
using System.Collections.Generic;

namespace Task2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			Console.Write("Enter the original line: ");
            string FistString = Console.ReadLine();
            Console.Write("Enter the line for search: ");
            string SecondString = Console.ReadLine();
            var CharList = new List<char>();

            foreach (var ch in SecondString)
            {
                if (!CharList.Contains(ch))
                {
                    CharList.Add(ch);
                }
            }
            foreach (var ch in CharList)
            {
                FistString = FistString.Replace(ch.ToString(), ch.ToString() + ch.ToString());
            }
            Console.WriteLine($"Replase string: {FistString}");
        }
    }
}
