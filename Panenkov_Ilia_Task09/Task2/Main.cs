using System;
using System.Collections.Generic;

namespace Task2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			var list = new DynamicArray<int>{ 1, 4, 6, 3, 4, 7, 5, 3 };

			foreach (var item in list)
            {
                Console.Write($"{item}  ");
            }
            
        }
    }
}
