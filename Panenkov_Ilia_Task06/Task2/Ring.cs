using System;
namespace Task2
{
	class Ring
    {
		private Round inner;
		private Round outer;

        public int X {
			get
			{
				return inner.X;
			}
			set
			{
				inner.X = value;
				outer.X = value;
			}
		}

        public int Y { 
			get
			{
				return outer.Y;
			}

			set
			{
				inner.Y = value;
				outer.Y = value;
			}
		}

   
        public int InRadius
        {
			get => inner.Radius;

            set
            {
				inner.Radius = value;
            }
        }
        
        public int outRadius
        {
            get => outRadius;

            set
            {
				outer.Radius = value;
            }
        }

        public Ring(int x, int y, int inRadius, int outRadius)
        {
			inner = new Round(x, y, inRadius);
			outer = new Round(x, y, outRadius);	
        }

		public double Area
		{
			get => outer.Area - inner.Area;
		}

		public double Lenght
		{
			get => outer.Lenght + inner.Lenght;
		}         
    }
}
