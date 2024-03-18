using System;

namespace Section.Ninth.Challenge
{
	public class RunProgram
	{
		public static void Run()
		{
			Employee ivan = new Employee("Apple", "Ivan", 15000);

			ivan.Work();
			ivan.Pause();

			Boss boss = new Boss("Apple", "Andre", 11000, "Porsche");

			boss.Lead();

			Trainee bob = new Trainee("Apple", "John", 5000, 40, 20);

			bob.Learn();
			bob.Work();
        }
	}

	class Employee
	{
		public string Name { get; set; }
		public string FirstName { get; set; }
		protected int Salary { get; set; }

		public Employee()
		{
			Name = "Petr";
			FirstName = "Paul";
			Salary = 5000;
		}
		public Employee(string name, string firstName, int salary)
		{
			this.Name = name;
			this.FirstName = firstName;
			this.Salary = salary;
		}

        public void Work()
        {
            Console.WriteLine("I'm working");
        }

        public void Pause()
        {
            Console.WriteLine("I'm having a break");
        }

    }

	class Boss : Employee
	{
		public string CompanyCar { get; set; }

		public Boss() { }

		public Boss(string name, string firstName, int salary, string companyCar):base(name, firstName, salary)
		{
			this.CompanyCar = companyCar;
        }

		public void Lead()
		{
			Console.WriteLine("I'm Leading");
		}
	}

	class Trainee : Employee
	{
		public int WorkingHours { get; set; }
		public int SchoolHours { get; set; }

        public Trainee() { }

        public Trainee(string name, string firstName, int salary, int workingHours, int schoolHours) : base(name, firstName, salary)
        {
			this.WorkingHours = workingHours;
			this.SchoolHours = schoolHours;
        }

		public void Learn()
		{
			Console.WriteLine("I'm learning for {0} hours", SchoolHours);
		}

        public new void Work()
        {
			Console.WriteLine("I worked {0} hours", this.WorkingHours);
        }
    }
}

