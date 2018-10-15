using System;

namespace Task3
{
    class MainClass
    {
		public static int Summ(int[] array)
		{
			int sum = 0;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] >= 0)
				{
					sum += array[i];
				}
			}
			return sum;
		}

		public static void Main(string[] args)
        {
			int[] arr = new int[15];
			Random rand = new Random();
			Console.WriteLine("Array: ");
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = rand.Next(-10, 10);
				Console.Write($"{arr[i]} ");
			}
           
			Summ(arr);
			Console.WriteLine($" \nSum: {Summ(arr)}");
        }
    }
}
