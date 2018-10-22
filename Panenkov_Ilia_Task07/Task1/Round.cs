using System;
namespace Task1
{
	class Round : Figure
    {
        protected double radius;

        public Round(double r)
        {
            radius = r;
        }

       
		public override void Draw(IDrawer drawer)
        {
			drawer.DrawRound(0, 0, 3);
        }
    }
}
