using System;

namespace Project_1
{
    class MainClass1
    {
        public static void Triangle(int n)
        {

            for (int y = 1; y <= n; y++)
            {
                for (int x = 1; x <= n * 2; x++)
                {
                    if (y <= n * 2 && y >= n - x + 1 && x <= y + n - 1)
                    {
                        Console.Write("*");
                    }

                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n");
            }
        }

        public static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the number of lines in the triangle: ");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine(
);
            }
            Triangle(n);
        }
    }
}
