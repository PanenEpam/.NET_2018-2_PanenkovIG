using System;

namespace Snake
{
	class Point
	{
		public int x;
		public int y;
		public char sym;

		public Point()
		{
		}

		public Point(int x, int y, char sym)
		{
			this.x = x;
			this.y = y;
			this.sym = sym;
		}

		public Point(Point p)
		{
			x = p.x;
			y = p.y;
			sym = p.sym;
		}

		public void Move(int offset, Direction direction)
		{
			if(direction == Direction.RIGHT)
			{
				x = x + offset;
			}
			else if(direction == Direction.LEFT)
			{
				x = x - offset;
			}
			else if(direction == Direction.UP)
			{
				y = y - offset;
			}
			else if(direction == Direction.DOWN)
			{
				y = y + offset;
			}
		}

		public bool IsHit(Point p)
		{
			return p.x == this.x && p.y == this.y;
		}

		public void Draw()
		{
            //if (sym == '@')
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.Write(sym);
            //}

			Console.SetCursorPosition(x, y);
			Console.Write(sym);			
		}

		public void Clear()
		{
			sym = ' ';
			Draw();
		}

	
	}
}
