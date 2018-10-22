using System;

namespace Task2
{
    public static class Interfaces
    {
        public static void Main(string[] args)
        {
			ISeries progression = new GeometricalProgression(2, 2);
            Console.WriteLine("Progression:");
            PrintSeries(progression);
        }

        static void PrintSeries(ISeries series)
        {
            series.Reset();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(series.GetCurrent());
                series.MoveNext();
            }
        }
    }  
}
