using System;
namespace Task2
{
	class Round
    {
        private int x;
        public int X { get; set; }

        private int y;
        public int Y { get; set; }

        private double radius;
        public double Radius
        {
            get => radius;

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Error");
                }

                else
                {
                    this.radius = value;
                }
            }
        }

        public double Lenght
        {
            get
            {

                return 2 * Math.PI * this.radius;
            }
        }

        public double Area
        {
            get
            {
                return Math.PI * radius * radius;
            }

        }

        public Round(int x, int y, double radius)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }
    }
}
