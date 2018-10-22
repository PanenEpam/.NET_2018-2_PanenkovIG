using System;
namespace Task1
{
	class Line : Figure
    {
        protected int xStart, yStart, xFinish, yFinish;

        public Line(int xS, int yS, int xF, int yF)
        {
            xStart = xS;
            yStart = yS;
            xFinish = xF;
            yFinish = yF;
        }

      
		public override void Draw(IDrawer drawer)
        {
			drawer.DrawLine(0, 0, 10, 0);
        }
    }
}
