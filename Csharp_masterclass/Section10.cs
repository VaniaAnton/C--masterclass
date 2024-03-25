using System;
using System.Threading;
using System.Collections.Generic;

namespace Section.Tenth
{
	public class PolymorphismDemo
	{
		public static void Test()
		{
            var cars = new List<Auto>
            {
                new Audi(200, "blue", "A4"),
                new BMW(250, "red", "M3"),
            };

            foreach (var car in cars)
            {
                car.Repair();
            }

            Auto bmwZ3 = new BMW(200, "black", "Z3");
            Auto audiA3 = new Audi(150, "white", "A3");
            bmwZ3.ShowDetails();
            audiA3.ShowDetails();

            bmwZ3.SetCarIDInfo(1234, "Ivan A.");
            audiA3.SetCarIDInfo(505, "John A.");
            bmwZ3.GetCarIDInfo();
            audiA3.GetCarIDInfo();

            BMW bmwX5 = new BMW(300, "green", "X5");
            bmwX5.ShowDetails();

            Auto carB = (Auto)bmwX5;
            carB.ShowDetails();

            M3 myM3 = new M3(260, "red", "Super turbo");
            myM3.ShowDetails();
		}
	}

    class Auto
    {
        public int HP { get; set; }
        public string Color { get; set; }

        //Has a relationship
        protected CarIDInfo carIDInfo = new CarIDInfo();

        public void SetCarIDInfo(int id, string owner)
        {
            carIDInfo.ID = id;
            carIDInfo.Owner = owner;
        }

        public void GetCarIDInfo()
        {
            Console.WriteLine("The car ID id {0}, and it's owner is {1}", carIDInfo.ID, carIDInfo.Owner);
        }

        public Auto() { }
        public Auto(int hp, string color)
        {
            HP = hp;
            Color = color;
        }

        public void ShowDetails()
        {
            Console.WriteLine("HP is {0}, color is {1}", HP, Color);
        }

        public virtual void Repair()
        {
            Console.WriteLine("Car was repaired");
        }
    }

    class Audi:Auto
	{
		public string Model { get; set; }
		private string brand = "Audi";

        public Audi(int hp, string color, string model) : base(hp, color)
        {
            Model = model;
        }
        public new void ShowDetails()
        {
            Console.WriteLine("HP is {0}, color is {1}, brand is {2}", HP, Color, brand);
        }

        public override void Repair()
        {
            Console.WriteLine("The Audi {0} was repaired", Model);
        }
    }

	class BMW:Auto
	{
        private string brand = "BMW";
        public string Model { get; set; }

       
		public BMW(int hp, string color, string model):base(hp, color)
		{
			Model = model;
		}

        public new void ShowDetails()
        {
            Console.WriteLine("HP is {0}, color is {1}, brand is {2}", HP, Color, brand);
        }

        public sealed override void Repair()
        {
            Console.WriteLine("The BMW {0} was repaired", Model);
        }

    }

    class M3 :BMW
    {
        public M3(int hp, string color, string model):base(hp, color, model)
        {
             
        }

        //public override void Repair()
        //{
        //    base.Repair();
        //}
    }

    class CarIDInfo
    {
        public int ID { get; set; } = 0;
        public string Owner { get; set; } = "No owner";

    }


}

