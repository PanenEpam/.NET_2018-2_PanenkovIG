using System;

namespace Task5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int Sum = 0;
            int n;
            Console.WriteLine("Please, enter a number less than 1000");
            while (!int.TryParse(Console.ReadLine(), out n) || n >= 1000)
            {
                Console.WriteLine("You entered an incorrect value\nPleas, enter value again");
            }
            for (int i = 0; i < n; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    Sum += i;
                }
            }
            Console.WriteLine($"The sum of multiples of 3 and 5 = {Sum}");
        }
    }
}
