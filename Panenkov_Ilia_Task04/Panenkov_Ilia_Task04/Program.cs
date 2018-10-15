using System;
using System.Text;

namespace Panenkov_Ilia_Task04
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			Console.WriteLine("Entrer string:");
			string text = Console.ReadLine();
			char[] pattern = new char[] {' ', ',', '.', '?', '!', '*', '&'};
			string[] SplitArray = text.Split(pattern);

			StringBuilder Sum = new StringBuilder();
            
			int count = 1;
			for (int i = 0; i < SplitArray.Length; i++)
			{
				Sum.Append(SplitArray[i]);
				count++;
			}

			int Average = 0;
			Console.WriteLine($"Average word lenght: {Average = Sum.Capacity / count}"); 
		}
    }
}
