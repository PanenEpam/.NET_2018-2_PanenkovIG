using System;

namespace Task2
{   
	class MainClass
    {
        public static void Main(string[] args)
        {
			Round r1 = new Round(3, 5, 12);
			Console.WriteLine($"Area: {r1.Area}");
			Console.WriteLine($"Lenght: {r1.Lenght}");
        }
    }
}
