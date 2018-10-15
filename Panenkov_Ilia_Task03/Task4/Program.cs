using System;

namespace Task4
{
	class MainClass
	{
		public static void EvenSum(int[,] matrix)
		{
			int sum = 0;
			for (int i = 1; i <= 5; i++)
			{
				for (int j = 1; j <= 5; j++)
				{
                    if ((i+j) % 2 == 0)
					{
						sum += matrix[i, j];
					}
				}
            }
			Console.Write($"The sum of the elements in the even position :{sum}");
		}

		public static void Main(string[] args)
		{
			//int x, y;
			//Console.WriteLine("Please, enter the dimension of the two-dimensional array: ");
			//while (!int.TryParse(Console.ReadLine(), out x) || x <=0)
			//{
			//	Console.WriteLine("You entered an incorrect valu\nPlease, enter value againe");
			//}
			//while (!int.TryParse(Console.ReadLine(), out y) || y <=0)
            //{
            //    Console.WriteLine("You entered an incorrect valu\nPlease, enter value againe");
            //}

			int[,] matr = new int[6, 6];
			Random rand = new Random();
			for (int i = 1; i <= 5; i++)
			{
				for (int j = 1; j <= 5; j++)
				{
					matr[i, j] = rand.Next(-1, 11);
					Console.Write("{0}\t",matr[i, j]);
				}
				Console.WriteLine("\n");
			}

			EvenSum(matr);
		}
	}
}