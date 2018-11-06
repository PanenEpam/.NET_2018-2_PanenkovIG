using System;
using System.Linq;

namespace NetBasicsDemo
{
    public class HashCodeDemo
    {
        public static void Main(string[] args)
        {

			TwoDPointWithHash[] arr = new TwoDPointWithHash[1000];

			int minValue = -500;
			int maxValue = 500;

			for (int i = 0; i < arr.Length; i++)
			{
				for (int j = minValue; j < maxValue; j++)
				{
					arr[i] = new TwoDPointWithHash(j, j);   
                }
			}

			int[] arrayHashCode = new int[arr.Length];

			for (int i = 0; i < arr.Length; i++)
			{
				arrayHashCode[i] = arr[i].GetHashCode();
			}

			double procent;

			procent = 1 - (arrayHashCode.Distinct().Count() / arrayHashCode.Length) * 100;

			Console.WriteLine($"{procent}%");
		}
    }


    class TwoDPointWithHash : TwoDPoint
    {
        public TwoDPointWithHash(int x, int y) : base(x, y)
        { 
		
		}

		public override int GetHashCode()
		{
			int hashBase = 17;
			hashBase = (hashBase * 23) + x;
			hashBase = (hashBase * 23) + y;

			return hashBase;
		}      
    }

    
}
