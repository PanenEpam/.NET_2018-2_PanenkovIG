using System;
namespace Task2
{
	public class GeometricalProgression : ISeries
    {
        double start, step;
        int currentIndex;

		public GeometricalProgression(double start, double step)
        {
            this.start = start;
            this.step = step;
            this.currentIndex = 1;
        }

        public double GetCurrent()
        {
			return start * Math.Pow(step, currentIndex - 1);
        }

        public bool MoveNext()
        {
            currentIndex++;
            return true;
        }

        public void Reset()
        {
            currentIndex = 1;
        }
    }
}
