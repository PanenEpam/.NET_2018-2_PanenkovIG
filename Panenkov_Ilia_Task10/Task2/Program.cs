using System;

namespace Task2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Office office = new Office();
            Employee p1 = new Employee("Ivan", office);
            Employee p2 = new Employee("Vova", office);
            Employee p3 = new Employee("Lena", office);

            p1.GoToOffice(9);
            p2.GoToOffice(15);
            p3.GoToOffice(23);

            p1.GoHome();
            p2.GoHome();
            p3.GoHome();
        }
    }

    public class Office
    {
        public delegate void ComeDelegate(Employee o, OnComeEventArgs args);
        public event ComeDelegate Come;

        public delegate void LeaveDelegate(Employee e, EventArgs args);
        public event LeaveDelegate Leave;

        public void OnCome(Employee e, OnComeEventArgs args)
        {
            Come?.Invoke(e, args);

            Come += e.SayHi;
            Leave += e.SayGoodby;
        }

        public void OnLeave(Employee e, EventArgs args)
        {
            if (Leave != null)
                Leave -= e.SayGoodby;

            Leave?.Invoke(e, args);
        }
    }

    public class OnComeEventArgs : EventArgs
    {
        public string Name { get; private set; }
        public int Hours { get; private set; }

        public OnComeEventArgs(string name, int hours)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            if (hours < 0 || hours > 24)
                throw new ArgumentOutOfRangeException(nameof(hours));

            Hours = hours;
        }
    }

    public class Employee
    {
        public delegate void ComeEvenDelegate(Employee o, OnComeEventArgs args);
        public event ComeEvenDelegate Come;

        public delegate void LeaveEvenDelegate(Employee o, EventArgs args);
        public event LeaveEvenDelegate Leave;

        public string Name { get; private set; }
        public Office Office { get; private set; }

        public Employee(string name, Office office)
        {
            Name = name;
            Office = office ?? throw new ArgumentNullException(nameof(office));

            Come += office.OnCome;
            Leave += office.OnLeave;
        }

        public void SayHi(Employee e, OnComeEventArgs args)
        {
            string hello;

            if (args.Hours < 12)
                hello = "Good morning";
            else if (args.Hours > 12 && args.Hours < 17)
                hello = "Good day";
            else
                hello = "Good evening";


            Console.WriteLine($"{hello}, {args.Name} - Said {Name}");
        }

        public void SayGoodby(Employee e, EventArgs args)
        {
            Console.WriteLine($"Goodby,{e.Name} - Said {Name}");
        }

        public void GoToOffice(int time)
        {
            Come?.Invoke(this, new OnComeEventArgs(Name, time));
        }

        public void GoHome()
        {
            Leave?.Invoke(this, new EventArgs());
        }

        public void Leaved(Employee person)
        {
            Come -= person.SayHi;
        }
    }
}
