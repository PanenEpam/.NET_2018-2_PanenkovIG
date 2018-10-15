using System;

namespace Project_1
{
    class MainClass1
    {
        static void Area(int x)
        {
            for (int i = 0; i < x; i++)
            {
                Console.Write(" ");
            }
        }

        static void Drow(int x)
        {
            for (int i = 0; i < x; i++)
            {
                Console.Write("*");
            }
        }

        public static void Main(string[] args)
        {
            int count;
            Console.WriteLine("Please, enter a number of sections :");
            while (!int.TryParse(Console.ReadLine(), out count) || count <= 0)
            {
                Console.WriteLine("You entered an incorrect value\nPlease, enter value again");
            }

            for (int i = 0; i <= count; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Area(count - j);
                    Drow(2 * j + 1);
                    Console.WriteLine();
                }
            }
        }
    }
}