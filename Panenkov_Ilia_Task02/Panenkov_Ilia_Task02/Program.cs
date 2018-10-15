using System;

namespace Task1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("enter the value of the sides of the rectangle: ");
            while ((!int.TryParse(Console.ReadLine(), out a) || a <= 0) ||
                   (!int.TryParse(Console.ReadLine(), out b) || b <= 0))
            {
                Console.WriteLine("You entered an incorrect value\nPlease, enter value again ");
            }
            Console.WriteLine($"Square {a * b}");
        }
    }
}
