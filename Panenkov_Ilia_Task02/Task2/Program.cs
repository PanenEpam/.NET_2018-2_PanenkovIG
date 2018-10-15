using System;

namespace Project_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the number of lines in the triangle: ");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("You entered an incorrect value\nPlease, enter value again");
            }

            for (int y = 1; y <= n; y++)
            {
                for (int x = 1; x <= y; x++)
                {
                    Console.Write('*');
                }
                Console.Write("\n");
            }
        }
    }
}
