using System;
using System.Linq;
namespace Games
{
    public struct Point
    {
		public int x { get; set; }
        public int y { get; set; }
        public char ch { get; set; }

        public static implicit operator Point((int, int, char) value) =>
            new Point { x = value.Item1, y = value.Item2, ch = value.Item3 };

        public void Draw()
        {
            DrawPoint(ch);
        }

        public void Clear()
        {
            DrawPoint(' ');
        }

        private void DrawPoint(char _ch)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(_ch);
        }

		public override bool Equals(object obj)
		{
			if (!(obj is Point))
			{
				return false;
			}

			var point = (Point)obj;
			return x == point.x &&
				   y == point.y &&
				   ch == point.ch;
		}

		public override int GetHashCode()
		{
			var hashCode = 1985651929;
			hashCode = hashCode * -1521134295 + x.GetHashCode();
			hashCode = hashCode * -1521134295 + y.GetHashCode();
			hashCode = hashCode * -1521134295 + ch.GetHashCode();
			return hashCode;
		}

		public static bool operator ==(Point a, Point b) =>
        (a.x == b.x && a.y == b.y) ? true : false;
        public static bool operator !=(Point a, Point b) =>
            (a.x != b.x || a.y != b.y) ? true : false;
    }
}


    
