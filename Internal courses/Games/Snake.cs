using System;
using System.Collections.Generic;
using System.Linq;


namespace Games
{

	enum Direction
	{
		LEFT,
        RIGHT,
        UP,
        DOWN
	}

	public class Snake
    {
		private List<Point> snake;
        private Direction direction;
		private int step = 1;
        private Point tail;
        private Point head;
		bool turn = true;

        public Snake(int x, int y, int length)
        {
            direction = Direction.RIGHT;
            snake = new List<Point>();
            for (int i = x - length; i < x; i++)
            {
                Point p = (i, y, '*');
                snake.Add(p);
                p.Draw();
            }
        }

        public Point GetHead() => snake.Last();
        public void Move()
        {
            head = GetNextPoint();
            snake.Add(head);
            tail = snake.First();
            snake.Remove(tail);
            tail.Clear();
            head.Draw();
            turn = true;
        }

        public Point GetNextPoint()
        {
            Point p = GetHead();
            switch (direction)
            {
                case Direction.LEFT:
                    p.x -= step;
                    break;
                case Direction.RIGHT:
                    p.x += step;
                    break;
                case Direction.UP:
                    p.y -= step;
                    break;
                case Direction.DOWN:
                    p.y += step;
                    break;
            }
            return p;
        }

        public void Rotation(ConsoleKey key)
        {
            if (turn)
            {
                switch (direction)
                {
                    case Direction.LEFT:
                    case Direction.RIGHT:
                        if (key == ConsoleKey.DownArrow)
                            direction = Direction.DOWN;
                        else if (key == ConsoleKey.UpArrow)
                            direction = Direction.UP;
                        break;
                    case Direction.UP:
                    case Direction.DOWN:
                        if (key == ConsoleKey.LeftArrow)
                            direction = Direction.LEFT;
                        else if (key == ConsoleKey.RightArrow)
                            direction = Direction.RIGHT;
                        break;
                }
                turn = false;
            }
        }

		public bool IsHit(Point p)
        {
            for (int i = snake.Count - 2; i > 0; i--)
            {
                if (snake[i] == p)
                {
                    return true;
                }
            }
            return false;
        }

		public bool Eat(Point p)
        {
            head = GetNextPoint();
            if (head == p)
            {
                snake.Add(head);
                head.Draw();
                return true;
            }
            return false;
        }


        

    }
}
