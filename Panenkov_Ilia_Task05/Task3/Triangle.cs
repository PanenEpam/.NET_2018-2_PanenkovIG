using System;
namespace Task3
{
	class Triangle
    {
        private int a;
        public int A
        {
            get => a;

            //set
            //{
            //    if (value <= 0)
            //    {
            //        throw new ArgumentException("Eroror! Please, enter the value again");
            //    }
            //    else
            //    {
            //        this.a = value;
            //    }
            //}
        }

        private int b;
        public int B
        {
            get => b;

            //set
            //{
            //    if (value <= 0)
            //    {
            //        throw new ArgumentException("Eroror! Please, enter the value again");

            //    }
            //    else
            //    {
            //        this.b = value;
            //    }
            //}
        }

        private int c;
        public int C
        {
            get => c;

            //set
            //{
            //    if (value <= 0)
            //    {
            //        throw new ArgumentException("Eroror! Please, enter the value again");

            //    }
            //    else
            //    {
            //        this.c = value;
            //    }
            //}
        }

        public double Perimetr
        {
            get
            {
                if (a + b > c && a + c > b && b + c > a)
                {
                    return a + b + c;
                }
                else throw new ArgumentException("Error");
            }
        }

        public double Area
        {
            get
            {
                double p = (a + b + c) / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
        }

        public Triangle(int a, int b, int c)
        {
            if (a + b > c && a + c > b && b + c > a)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            else throw new ArgumentException("This in not triang");
        }
    }
}
