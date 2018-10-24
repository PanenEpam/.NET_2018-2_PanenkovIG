using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;

namespace Task1
{
    class MainClass
    {
		public static void Main(string[] args)
		{
			string text = File.ReadAllText("/Users/admin/Documents/ epam/Tasks/Panenkov_Ilia_Task09/text.txt");
			Regex regex = new Regex(@"\w*");
			Console.WriteLine(text);

			var words = regex.Matches(text);
			var query = words
				.Cast<Match>()
				.Select(c => c.Value.ToLower())
				.GroupBy(c => c)
				.Select(c => new
				{
					Key = c.Key,
					Count = c.Select(w => 1).Aggregate((a, b) => a + b)
				})
				.OrderByDescending(c => c.Count);

			foreach (var word in query)
				Console.WriteLine("{0}: {1}", word.Key, word.Count);
		}
    }
}
