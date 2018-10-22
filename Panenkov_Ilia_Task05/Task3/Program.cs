using System;

namespace Task3
{
    class MainClass
    {
		public static void Main(string[] args)
        {
			Triangle t1 = new Triangle(2, 4, 4);
			Console.WriteLine($"Perimetr: {t1.Perimetr}");
			Console.WriteLine($"Area: {t1.Area}");
        }
    }
}
