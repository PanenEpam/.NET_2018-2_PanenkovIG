using System;

namespace Task1
{

    class Employee : User
    {
        private int experience;
        public int Experience
        {
            get => experience;

            set
            {
                if (!int.TryParse(ToString(), out experience) && experience < 0 && experience < Age)
                {
                    throw new ArgumentException("Error! Incorect value");
                }
                else this.experience = value;
            }
        }

        private string position;
        public string Position { get; set; }

		public override string ToString()
		{
			return base.ToString() + $" Experience: {Experience},\nPosition: {Position}";
		}

		public Employee( string surname, string name, string secondName, DateTime birthday, int age, int exp, string position) : 
		base(surname, name, secondName, birthday, age)
        {
			this.Surname = surname;
			this.Name = name;
			this.SecondName = secondName;
			this.Date_of_birth = birthday;
			this.Age = age;
            this.experience = exp;
            this.position = position;
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
			Employee e1 = new Employee("Ivanov", "Ivan", "Ivanovich", new DateTime(2000, 11, 9), 18, 5, "Programmer");
		    Console.WriteLine(e1);
        }
    }
}
