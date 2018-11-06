using System;
namespace Mathematic
{
    public class MyClass
    {
		public static double Sqr( double a)
		{
			return a * a;
		}

		public static int Factorial(int i)
        {
            if (i <= 1)
                return 1;
            return i * Factorial(i - 1);
        }

    }
}
