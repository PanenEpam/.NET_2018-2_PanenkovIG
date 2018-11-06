using System;
using System.Collections.Generic;

namespace Task1
{

	class Employee : User//, IEquatable<Employee>
    {
        int experience;
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

        public string Position { get; set; }

		public override string ToString()
		{
			return base.ToString() + $"\nExperience: {Experience}\nPosition: {Position}";
		}


        public Employee( string surname, string name, string secondName, DateTime birthday, int age, int exp, string position) : 
            base(surname, name, secondName, birthday, age)
        {
            Surname = surname;
            Name = name;
            SecondName = secondName;
            Date_of_birth = birthday;
            Age = age;
			Experience = exp;
			Position = position;
        }

		public override bool Equals(Object obj)
		{
			if (obj == null)
			    throw new ArgumentNullException(nameof(obj));

			Employee employee = obj as Employee;
			if (employee == null)
				throw new ArgumentNullException(nameof(employee));

			return employee.Surname == Surname
						   && employee.Name == Name
						   && employee.SecondName == SecondName
						   && employee.Date_of_birth == Date_of_birth
						   && employee.Age == Age
						   && employee.Experience == Experience
						   && employee.Position == Position;         
		}

		public override int GetHashCode()
		{
			var hashCode = -154092;
			hashCode = hashCode * -1521134295 + experience.GetHashCode();
			hashCode = hashCode * -1521134295 + Experience.GetHashCode();
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Position);
			return hashCode;
		}
	}
    
    class MainClass
    {
        public static void Main(string[] args)
        {
			Employee e1 = new Employee("Ivanov", "Ivan", "Ivanovich", new DateTime(2000, 11, 9), 18, 5, "Proger");
			Employee e2 = new Employee("Vova", "Petrov", "Petrovich", new DateTime(1998, 1, 6), 20, 6, "Admin");
		    Console.WriteLine(e1);
			Console.WriteLine(e1.GetHashCode());
			Console.WriteLine("\n" + e2);
            Console.WriteLine(e2.GetHashCode());
			Console.WriteLine("\n" + e1.Equals(e2));

        }
    }
}
