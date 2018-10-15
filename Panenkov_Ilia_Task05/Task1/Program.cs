using System;
using System.Text.RegularExpressions;

namespace Task1
{
	class User
	{
		
		
		private string surname;
		public string Surname
		{
			get => surname;

			set
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					throw new AggregateException("String cannot be empty");
				}
				this.surname = value;
			}
		}

		private string name;
		public string Name 
		{
			get => name;

			set
			{
				if (string.IsNullOrEmpty(value))
                {
                    throw new AggregateException("String cannot be empty");
                }
				this.name = value;
			}
		}

		private string secondName;
		public string SecondName
		{
			get => secondName;
			set => this.secondName = value;
		}

		private DateTime date_of_birth;
		public DateTime Date_of_birth
		{
			get => date_of_birth;

			set
			{
				if (value <= DateTime.Now && (age == default(int) || (age == DateTime.Now.Year - value.Year)))
				{
					date_of_birth = value;
				}
				this.date_of_birth = value;
			}
		}

		private int age;
		public int Age
		{
			get => age;

			set
			{
				if (value >= 0 && (age == default(int) || (age == DateTime.Now.Year - date_of_birth.Year)))
				{
					age = value;
				}
				this.age = value;
			}
		}

		public void GetInfo()
		{
			Console.WriteLine($"Surname:{Surname}\nName: {Name}\nSecond name: {SecondName}\nBirthday: {Date_of_birth}\nAge: {Age}");
		}
	

		public User(string surname, string name, string secondName, DateTime birhtday, int age)
		{
			this.Surname = surname;
			this.Name = name;
			this.SecondName = secondName;
			this.Date_of_birth = birhtday;
			this.age = age;
		}
	}

	class MainClass
    {
        public static void Main(string[] args)
        {
			User Oleg = new User("Ivanov", "Ivan", "Ivanovich", new DateTime(1998, 04, 1) ,20);
			Oleg.GetInfo();

        }
    }
}
