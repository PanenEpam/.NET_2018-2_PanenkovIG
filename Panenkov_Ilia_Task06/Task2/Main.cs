using System;

namespace Task2
{      
	class MainClass
    {
        public static void Main(string[] args)
        {
			Ring r1 = new Ring(1, 1, 3, 6);
			Console.WriteLine($"Area ;{r1.Area}");
			Console.WriteLine($"Lenght ;{r1.Lenght}");         
        }
    }
}
