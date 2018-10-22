using System;
namespace Task1
{
	public class ConsoleDrawer : IDrawer
	{
		public void DraweRing(float x1, float y1, int inR, int outR)
		{
			Console.WriteLine($"Ring: center ({x1},{y1}) innerRadius {inR} outRadius {outR}");
		}

		public void DrawLine(float x1, float y1, float x2, float y2)
		{
			Console.WriteLine($"Line: Statr ({x1},{y1}), finish ({x2},{y2})");		
		}

		public void DrawRectangle(double width, double height)
		{
			Console.WriteLine($"Rectangle: width {width} height {height}");
		}

		public void DrawRound(float x1, float y1, int r)
		{
			Console.WriteLine($"Round: center ({x1},{y1}) radius {r}");
		}
	}
}
