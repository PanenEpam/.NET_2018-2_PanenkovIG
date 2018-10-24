using System;
using System.Collections.Generic;

namespace Task1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			int[] list = { 1, 3, 5, 2, 4 };

			DynamicArray<int> array = new DynamicArray<int> (list);

			Console.WriteLine(array);


		}

       

    }
}
