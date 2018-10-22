using System;
namespace Task1
{
    public interface IDrawer
    {
		void DrawLine(float x1, float y1, float x2, float y2);
		void DrawRound(float x1, float y1, int r);
		void DraweRing(float x1, float y1, int inR, int outR);
		void DrawRectangle(double width, double height);
    }
}
