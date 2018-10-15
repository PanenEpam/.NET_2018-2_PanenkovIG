using System;

namespace Panenkov_Ilia_Task03
{
    class MainClass
    {

        
        public static void Main(string[] args)
        {
			int[] arrey = new int[20];
			Random rand = new Random();

			for (int i = 0; i < arrey.Length; i++)
			{
				arrey[i] = rand.Next(0, 50);
            }

			Console.WriteLine("Original array: ");
			foreach (var item in arrey)
            {
                Console.Write($"{item} ");
            }
            
			Console.WriteLine($"\n\nMax: {Max(arrey)}");
			Console.WriteLine($"\nMin: {Min(arrey)}");

			Console.WriteLine("\nFinal array:");
			SortArray(arrey); 
			for (int i = 0; i < arrey.Length; i++)
			{
				Console.Write($"{arrey[i]} ");
			}
		}



		public static int Max(int[] arr)
        {
			int max = arr[0];
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] > max)
				{
					max = arr[i];
				}
			}
			return max;
		}
        
		public static int Min(int[] arr)
		{
			int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
				if (arr[i] < min)
                {
					min = arr[i];
                }
            }
			return min;
		}


		public static void SortArray(int[] arr)
        {
			int temp = 0;

			for (int i = 0; i < arr.Length; i++)
            {
				for (int j = 0; j < arr.Length - i - 1; j++)
                {
					if (arr[j] > arr[j + 1])
                    {
						temp = arr[j];
						arr[j] = arr[j + 1];
						arr[j + 1] = temp;
                    }
                }
            }
		}
    }
}
