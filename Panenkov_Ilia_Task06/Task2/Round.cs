using System;
namespace Task2
{
	class Round
    {
		protected int x;
		public int X { get; set; }
        
		protected int y;
		public int Y { get; set; }

		protected int radius;
        public int Radius
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
			get => 2 * Math.PI * this.radius;
        }

        public double Area
        {
			get => Math.PI * radius * radius;
        }

		public Round(int x, int y, int radius)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }
    }
}
