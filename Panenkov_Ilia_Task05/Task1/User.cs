using System;
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
                if (value > DateTime.Now)
                {
                    throw new ArgumentException("error");
                }
                this.date_of_birth = value;
            }
        }
        public int Age
        {
            get
            {
				//создать переменную
                //счмтать разницу годов, месяцов6 дней
                //вычислить количество лет
				return DateTime.Now.Year - date_of_birth.Year;
            }
        }

        public override string ToString()
        {
            return $"Surname:{Surname}\nName: {Name}\nSecond name: {SecondName}\nBirthday: {Date_of_birth}\nAge: {Age}";
        }
       
        public User(string surname, string name, string secondName, DateTime birhtday)
        {
            this.Surname = surname;
            this.Name = name;
            this.SecondName = secondName;
            this.Date_of_birth = birhtday;
        }
    }
}
