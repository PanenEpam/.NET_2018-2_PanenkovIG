using System;
using System.Collections.Generic;
using System.Linq;

namespace Snake
{
    public class Snake : Figure
    {   
        Directoin directoin;

        public Snake(Point tail, int lenght, Directoin _directoin)
        {
            directoin = _directoin;
            pList = new List<Point>();

            for (int i = 0; i < lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, directoin);
                pList.Add(p);
            }

        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, directoin);
            return nextPoint;
        }

        public void Rotation(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
            {
                directoin = Directoin.LEFT;
            }
            else if (key == ConsoleKey.RightArrow)
            {
                directoin = Directoin.RIGHT;
            }
            else if (key == ConsoleKey.UpArrow)
            {
                directoin = Directoin.UP;
            }
            else if (key == ConsoleKey.DownArrow)
            {
                directoin = Directoin.DOWN;
            }
        }

        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                pList.Add(food);
                return true;
            }
            else
                return false;
        }
    }
}
