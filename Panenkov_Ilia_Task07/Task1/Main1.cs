using System;

namespace Task1
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
			Figure[] fig = new Figure[4];
            
			for (int i = 0; i < fig.Length; i++)
			{
				fig[0] = new Rectangle(10, 20);
				fig[1] = new Round(10);
				fig[2] = new Ring(5, 10);
				fig[3] = new Line(0, 0, 10, 0);
			}

			ConsoleDrawer console = new ConsoleDrawer();
			for (int i = 0; i < fig.Length; i++)
			{
				fig[i].Draw(console);
			}
		}
	}
}
