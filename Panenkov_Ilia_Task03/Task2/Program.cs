using System;

namespace Task2
{
    class MainClass
    {
		public static int[,,] Change(int[,,] matrix)
		{
			Console.WriteLine("Final: ");
			for (int x = 0; x < matrix.GetLength(0); x++)
			{
				for (int y = 0; y < ; y++)
				{
					for (int z = 0; z < 3; z++)
					{
						if (matrix[x,y,z] > 0)
                        {
							matrix[x, y, z] = 0;
                        }
						return matrix;
					}
				}
			}
		}


		public static void Main(string[] args)
		{

			int[,,] matr = new int[2, 2, 3];
			Random rand = new Random();

			Console.WriteLine("Original: ");
			for (int i = 0; i < 2; i++)
			{
                for (int j = 0; j < 2; j++)
				{
                    for (int k = 0; k < 3; k++)
					{
						matr[i, j, k] = rand.Next(-20, 20);
						Console.Write("{0} ", matr[i,j,k]);
					}
				}
			}

			Console.WriteLine("\n");
			Change(matr);                   
		}
    }
}
