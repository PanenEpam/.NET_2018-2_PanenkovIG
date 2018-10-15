using System;
using System.Text.RegularExpressions;

namespace Task1
{
	class User
	{
		public string Surname { 
			get
			{
				return Surname;
			}
			set
			{
				if(string.IsNullOrEmpty(value))
				{
					throw new AggregateException("String cannot be empty");
				}
			} 
		}

		public string Name { 
			get
			{
				return Name;
			}
			set
			{
				if (string.IsNullOrEmpty(value))
                {
                    throw new AggregateException("String cannot be empty");
                }
			}
		}

		public string SecondName { get; set; }

		public DateTime Date { 
			get
			{
				return Date;
			} 
			set
			{
				
		//		int year;
		//		if (!Int32.TryParse(Console.ReadLine(), out year))
		//		{
		//			throw new ArgumentException("Not year");
		//		}

		//		if (year > 2018)
		//		{
		//			throw new ArgumentException("Not real year");
		//		}

		//		int month;
		//		if (!Int32.TryParse(Console.ReadLine(), out month))
  //              {
  //                  throw new ArgumentException("Not month");
  //              }

		//		if (month > 12)
  //              {
  //                  throw new ArgumentException("Not real month");
  //              }

		//		int day;
		//		if (!Int32.TryParse(Console.ReadLine(), out day))
  //              {
  //                  throw new ArgumentException("Not day");
  //              }

		//		if (day > 31)
  //              {
  //                  throw new ArgumentException("Not real day");
  //              }
		//		Date.Year = Convert.ToDateTime(year);
		//		value.Month = month;
		//		value.Day = day;
		//	}
		//}

		public int Age { 
			get
			{
				return Age;
			}
			set
			{
				if (!Int32.TryParse(Console.ReadLine(), out value))
				{
					throw new ArgumentException("Not ");
				}
			}
		}
	}

    class MainClass
    {
		
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
