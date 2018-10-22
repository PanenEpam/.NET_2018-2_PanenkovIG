using System;
namespace Task1
{
    class User
    {

		protected string surname;
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
        
		protected string name;
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

		protected string secondName;
        public string SecondName
        {
            get => secondName;
            set => this.secondName = value;
        }

		protected DateTime date_of_birth;
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

		protected int age;
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

		public override string ToString()
		{
			return $"Surname:{Surname}\nName: {Name}\nSecond name: {SecondName}\nBirthday: {Date_of_birth}\nAge: {Age}";
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
}
