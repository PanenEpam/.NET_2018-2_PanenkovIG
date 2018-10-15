using System;
using System.Globalization;

namespace Panenkov_Ilia_Task04 
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			DateTime date1 = new DateTime(2018, 10, 9);
			double number = 28434.3432;

			Console.WriteLine("Change cultutr:" +
			                  "\t\n1: 'ru' vs 'en'"+
			                  "\n2: 'en' vs 'invariant'" +
			                  "\n3: 'ru' vs 'invariant'\n");
			Console.Write("Enter the number of the difference: ");
			string str = Console.ReadLine();
			switch (str)
			{
				case "1":
					Console.WriteLine($"\nData {date1.ToString("d", CultureInfo.CreateSpecificCulture("ru-RU"))} vs {date1.ToString("d", CultureInfo.CreateSpecificCulture("en-US"))}");
					Console.WriteLine($"\nNumber {number.ToString("F", CultureInfo.CreateSpecificCulture("ru-RU"))} vs {number.ToString("F", CultureInfo.CreateSpecificCulture("en-US"))}");
					break;

				case "2":
					Console.WriteLine($"\nData {date1.ToString("d", CultureInfo.CreateSpecificCulture("en-US"))} vs {date1.ToString("d", DateTimeFormatInfo.InvariantInfo)}");
					Console.WriteLine($"\nNumber {number.ToString("F", CultureInfo.CreateSpecificCulture("en-US"))} vs {number.ToString("e4", CultureInfo.InvariantCulture)}");
					break;

				case "3":
					Console.WriteLine($"\nData {date1.ToString("d", CultureInfo.CreateSpecificCulture("ru-RU"))} vs {date1.ToString("d", DateTimeFormatInfo.InvariantInfo)}");
					Console.WriteLine($"\nNumber {number.ToString("F", CultureInfo.CreateSpecificCulture("ru-RU"))} vs {number.ToString("e4", CultureInfo.InvariantCulture)}");
					break;
                 
				default:
					Console.WriteLine("You have entered a non-existent difference!");
					break;
			}

		}
    }
}
