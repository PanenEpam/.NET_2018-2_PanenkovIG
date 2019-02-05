using System;
using System.Threading;

namespace Games
{
	   
    class Games
    {
		static readonly int x =9;
		static readonly int y = 5;
		static Walls walls;
		static Food food;
		static Snake snake;
		static Timer timer;

		public static void Main(string[] args)
        {
			walls = new Walls(x, y, '#');
			food = new Food(x, y, '@');
			food.CreateFood();
			snake = new Snake(x / 2, y / 2, 3);
			timer = new Timer(Loop, null, 0, 200);

			Console.SetWindowSize(x + 1, y + 1);
			Console.SetBufferSize(x + 1, y + 1);
			Console.CursorVisible = false;

			while (true)
			{
				if (Console.KeyAvailable)
				{
					ConsoleKeyInfo key = Console.ReadKey();
					snake.Rotation(key.Key);
				}
			}
        }

		static void Loop(object obj)
		{
			if (walls.IsHit(snake.GetHead()) || snake.IsHit(snake.GetHead()))
			{
				timer.Change(0, Timeout.Infinite);
			}
			else if (snake.Eat(food.food))
			{
				food.CreateFood();
			}
			else
			{
				snake.Move();
			}
		}
    }

}
