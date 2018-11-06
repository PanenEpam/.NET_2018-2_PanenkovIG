using System;
namespace Task1
{
    class MainClass
    {
        public delegate int Compariso(string a, string b);

        public static void Main(string[] args)
        {
            string[] str = { "qwert", "qwer", "qwe", "qw", "q", "a" };

            Array.Sort(str, SortString);

            foreach (var item in str)
            {
                Console.WriteLine(item);
            }
        }


        static int SortString(string x, string y)
        {
            if (x == null)
            {
                if (y == null)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                if (y == null)
                {
                    return 1;
                }
                else
                {
                    int result = x.Length.CompareTo(y.Length);

                    if (result != 0)
                    {
                        return result;
                    }
                    else
                    {
                        return x.CompareTo(y);
                    }
                }
            }
        }
    }
}