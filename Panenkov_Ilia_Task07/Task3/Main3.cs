using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task3
{
    public static class Interfaces
    {
        public static void Main(string[] args)
        {
			IIndexableSeries list = new List(new double[] { 4, 6, 3, 5, 3, 5, 4, 2 });
            Console.WriteLine("List:");
            PrintSeries(list);
			PrintIIndex(list, 3);
            
        }

		static void PrintIIndex(IIndexableSeries indexableSeries, int index )
		{
			Console.WriteLine("Index " + indexableSeries[index]);
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

