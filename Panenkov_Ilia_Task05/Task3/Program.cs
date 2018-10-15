using System;

namespace Task3
{
	class Triangle
    {
        private int a;
        public int A
        {
            get => a;

            set
            {
                if (!int.TryParse(ToString(), out value) && value <= 0)
                {
                    throw new ArgumentException("Eroror! Please, enter the value again");
                }
                else
                {
                    this.a = value;
                }
            }
        }

        private int b;
        public int B
        {
            get => b;

            set
            {
                if (!int.TryParse(ToString(), out value) && value <= 0)
                {
                    throw new ArgumentException("Eroror! Please, enter the value again");

                }
                else
                {
                    this.b = value;
                }
            }
        }

        private int c;
        public int C
        {
            get => c;

            set
            {
                if (!int.TryParse(ToString(), out value) && value <= 0)
                {
                    throw new ArgumentException("Eroror! Please, enter the value again");

                }
                else
                {
                    this.c = value;
                }
            }
        }

        public double Perimetr()
        {
			if (a + b > c && a + c > b && b + c > a)
			{
				return a + b + c;
			}
			else
			Console.WriteLine("Error! Uncorect value");
		}

        public double Area()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public Triangle(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
    }

    class MainClass
    {
		public static void Main(string[] args)
        {
			Triangle t1 = new Triangle(2, 4, 4);
			Console.WriteLine(t1.Perimetr());
			Console.WriteLine(t1.Area());
        }
    }
}
