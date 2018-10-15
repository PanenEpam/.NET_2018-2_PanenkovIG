using System;

namespace Task2
{
	class Round
	{
		private int x;
		public int X
		{
			get => x;

			set
			{
				if (!Int32.TryParse(ToString(), out value))
				{
					throw new ArgumentException("Error");
				}

				else
				{
					this.x = value;
				}
			}
		}

		private int y;
		public int Y
		{
			get => y;

			set
			{
				if (!Int32.TryParse(ToString(), out value))
                {
                    throw new ArgumentException("Error");
                }

                else
                {
                    this.y = value;
                }
			}
		}

		private double radius;
		public double Radius
		{
			get => radius;

			set
			{
				if (!Double.TryParse(ToString(), out value) && value <= 0)
                {
                    throw new ArgumentException("Error");
                }

                else
                {
					this.radius = value;
                }	
			}
		}
        
		public double GetLenght()
		{
			return 2 * Math.PI * this.radius;
		}

		public double GerArea()
		{
			return Math.PI * radius * radius;
		}

		public Round(int x, int y, double radius)
		{
			this.x = x;
			this.y = y;
			this.radius = radius;
		}
	}

	class MainClass
    {
        public static void Main(string[] args)
        {
			Round r1 = new Round(3, 5, 12);
			double area = r1.GerArea();
			Console.WriteLine(area);
			double lenght = r1.GetLenght();
			Console.WriteLine(lenght);
        }
    }
}
