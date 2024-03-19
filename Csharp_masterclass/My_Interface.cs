using System;
namespace Section.Ninth.Interface
{
	class TestInterface
	{
		public static void Test()
		{
			Chair officeChair = new Chair("Brown", "Plastic");
			Chair gamingChair = new Chair("Red", "Wood");

			Car damagedCar = new Car(80f, "Red");

			//add the two chairs to the IDestroyable list of the car
			//so that when we destroy the car the destroyable objects
			//that are near the car wiil get destroyed as well
			damagedCar.DestroyablesNearby.Add(officeChair);
			damagedCar.DestroyablesNearby.Add(gamingChair);

			damagedCar.Destroy();
		}
	}
	interface IDestroyable
	{
		//property to store the audio file of the destruction sound
		string DestructionSound { get; set; }

		//method to destroy an object
		void Destroy();
	}
	class Furniture
	{
		public string Color { get; set; }
		public string Material { get; set; }

		public Furniture()
		{
			Color = "White";
			Material = "Wood";
		}

		public Furniture(string color, string material)
		{
			Color = color;
			Material = material;
		}
	}

	class Chair : Furniture, IDestroyable
	{
        public string DestructionSound { get; set; }
        public Chair(string color, string material) : base(color, material)
		{
			DestructionSound = "ChairDestructionSound.mp3";
		}

        public void Destroy()
        {
			Console.WriteLine($"The {Color} chair was destroyed");
            Console.WriteLine("Playing destruction sound {0}", DestructionSound);
            Console.WriteLine("Spawlind chair parts");

        }
    }

	class Vehicle
	{
		public float Speed { get; set; }
		public string Color { get; set; }

		public Vehicle()
		{
			Speed = 120f;
			Color = "White";
		}

		public Vehicle(float speed, string color)
		{
			Speed = speed;
			Color = color;
		}
	}
	class Car : Vehicle , IDestroyable
	{
		// implement the interface's prop
		public string DestructionSound { get; set; }

		//creating a new prop to store the destroyable objects hearby
		//when a gar gets destroyed it should also destroy the nearby object
		//this list is of type IDestroyable which means it can store any object
		//that implements this interface and we can only access th properties and
		//methods in this interface
		public List<IDestroyable> DestroyablesNearby;

		public Car(float speed, string color) : base(speed, color)
		{
			DestructionSound = "CarExplosionSound.mp3";

			//initialize the list of destroyable objects
			DestroyablesNearby = new List<IDestroyable>();

		}

		public void Destroy()
		{
			Console.WriteLine("Playing destruction sound {0}", DestructionSound);
			Console.WriteLine("Create fire");

			foreach (IDestroyable item in DestroyablesNearby)
			{
				item.Destroy();
			}
		}

        
    }
}

