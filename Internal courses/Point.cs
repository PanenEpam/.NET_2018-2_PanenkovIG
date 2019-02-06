using System;

namespace Snake
{
    public class Point
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

        public void Move(int offset, Directoin directoin)
        {
            if (directoin == Directoin.RIGHT)
            {
                x += offset;
            }
            else if(directoin == Directoin.LEFT)
            {
                x -= offset;
            }
            else if (directoin == Directoin.UP)
            {
                y -= offset;
            }
            else
            {
                y += offset;
            }
        }

        public void Clear()
        {
            sym = ' ';
            Draw();
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public  bool IsHit(Point p)
        {
            return p.x == this.x && p.y == this.y;
        }
    }
}
