using System;
namespace Task1
{
	class Rectangle : Figure
    {
        protected double width, height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        
		public override void Draw(IDrawer drawer)
        {
			drawer.DrawRectangle(4, 5);
        }
    }

}
