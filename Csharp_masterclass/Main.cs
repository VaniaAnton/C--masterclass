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
			Car myCar = new Car();
			Console.WriteLine(myCar.Name);



			Console.ReadKey();
		}
	}
}

