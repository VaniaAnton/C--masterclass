using System;
using Section.First;
using Section.Third;
using Section.Forth;
using Section.Sixth;

namespace Section
{
	public class MainClass
	{
		static public void Main(string[] args)
		{
			Car my = new Car();
			my.Details();
			Car audi = new Car("Audi A4", 250, "red");
			audi.Drive();
			audi.Details();
            Car bmw = new Car("BMW M5", 350);
            bmw.Drive();
            bmw.Details();

            Console.WriteLine("Press 1 to stop the car!");
            string userInput = Console.ReadLine();
			if(userInput == "1")
			{
				audi.Stop();
			}
			else { Console.WriteLine("Still driving"); }


			Console.ReadKey();
		}
	}
}

