using System;
namespace Task1
{
	class Ring : Round
    {
        protected double innerR;

        public Ring(double r, double ir) : base(r)
        {
            innerR = ir;
        }

       
		public override void Draw(IDrawer drawer)
        {
			drawer.DraweRing(0, 0, 3, 6);
        }
    }

}
