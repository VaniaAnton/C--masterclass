using System;
using System.Drawing;
using System.Xml.Linq;

namespace Section.Sixth
{
	public class Car
	{
		//member variable/fields
		private string _name;//private field typically used for storing data.
		private int _horsePower;
		private string _color;

		//Public properties
		public string Name
		{
			get { return _name; }//get accessor
			set {
				if(value == "")
				{
					_name = "HelLo, default name"
				}
				else
				{
					_name = value;
				}
			; }//set accessor
        }

		public void SetName(string name) { _name = name; }
		public string GetName() { return _name; }


        //Constructors
        //Default constructor
        public Car()
		{
            _name = "Car";
            Console.WriteLine(_name + " was created");
            _horsePower = 0;
            _color = "Red";
        }

        //Partial specification constructor
        public Car(string name, int horsePower = 0)
        {
            _name = name;
            Console.WriteLine(_name + " was created");
            _horsePower = horsePower;
            _color = "Red";
        }

        //Full specification constructor
        public Car(string name, int horsePower =0, string color = "black")
		{
			_name = name;
			Console.WriteLine(_name + " was created");
			_horsePower = horsePower;
			_color = color;
		}

		//Member Methods
		public void Drive()
		{
			Console.WriteLine(_name + " is driving");
		}

		public void Stop()
		{
			Console.WriteLine(_name + " was stopped");
		}

		public void Details()
		{
			Console.WriteLine("Horse Power = {0}, the car name is {1} and {2} color", _horsePower, _name, _color);
		}
	}
}

