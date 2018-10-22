using System;
namespace Task1
{
	class MainClass
    {
        public static void Main(string[] args)
        {
			User Oleg = new User("Ivanov", "Ivan", "Ivanovich", new DateTime(1998, 04, 1));
			Console.WriteLine(Oleg);
        }
    }
}
