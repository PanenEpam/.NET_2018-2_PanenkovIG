using System;
using System.Text;
using System.Diagnostics;

namespace Task4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			string str = "";
            StringBuilder sb = new StringBuilder();
            int N = 100;
			var stopWatch = new Stopwatch();
			stopWatch.Start();
            for (int i = 0; i < N; i++)
            {
                str += "*";
            }
			stopWatch.Stop();
			Console.WriteLine("String: " + stopWatch.Elapsed.TotalMilliseconds);

			stopWatch.Restart();
            for (int i = 0; i < N; i++)
            {
                sb.Append("*");
            }
			stopWatch.Stop();
			Console.WriteLine($"StringBulder {stopWatch.Elapsed.TotalMilliseconds}");
        }
    }
}
