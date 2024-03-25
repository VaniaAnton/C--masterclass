using System;
using System.Collections;
using System.Collections.Generic;
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


			// Check IEnumerable interface

			DogShelter shelter = new DogShelter();

			foreach (Dog dog in shelter)
			{
				if (!dog.IsNaughtyDog)
				{
					dog.GiveTreat(2);
				}
				else
				{
                    dog.GiveTreat(1);
                }
			}

			//----------------------------------------
			//IEnumerable example 1

			IEnumerable<int> unknownCollection;
			unknownCollection = GetCollection(1);

			Console.WriteLine("This was a List<int>");
			foreach (int num in unknownCollection)
			{
				Console.Write(num + " ");
			}

			Console.WriteLine();
            unknownCollection = GetCollection(2);

            Console.WriteLine("This was a Queue<int>");
            foreach (int num in unknownCollection)
            {
                Console.Write(num + " ");
            }

            static IEnumerable<int> GetCollection(int option)
			{
				List<int> numbersList = new List<int>() { 1, 2, 3, 4, 5 };

				Queue<int> numbersQ = new Queue<int>();
				numbersQ.Enqueue(6);
				numbersQ.Enqueue(7);
				numbersQ.Enqueue(8);
				numbersQ.Enqueue(9);
				numbersQ.Enqueue(10);

				if (option == 1) { return numbersList; }
				else if (option == 2) { return numbersQ; }
				else { return new int[] { 11, 12, 13, 14, 15 };  }
				
			}

			//----------------------------------------
			//IEnumerable example 2

			List<int> numList = new List<int>() { 8, 6, 2 };
			int[] numArray = new int[] { 1, 7, 1, 3 };
			Console.WriteLine();

			CollectionSum(numList);

			CollectionSum(numArray);

			static void CollectionSum(IEnumerable<int> anyCollection)
			{
				int sum = 0;

				foreach (int n in anyCollection)
				{
					sum += n;
				}

				Console.WriteLine("The sum is {0}", sum);
			}

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

	//----------------------------------------------------------------------------------------

	//1. IEnumerable <T> for generic collections
	//2. IEnumerable for non generic collections

	///<summary> IEnumerable contains a single method that you must implement when implementing this interface;
	///GetEnumerator which returns an IEnumerator<T> object.
	///The returned IEnumerator<T> provides the ability to iterate through the collection
	///by explosing a Current property that points at the object we are currently at in the collection
	///</summary>
	///<param name="args"></param>

	///<summary>
	///when it is recommended to use the IEnumerable interface:
	///- Your collection represents a mssive database table,
	///you don't want to copy the entire thing into memory and cause performance issues in your app
	///When it is not recommended to use the IEnumerable interface:
	///You need the results right away and are possibly mutating / editing the objects later on.
	///In this case, it is better to use an array or a List.
	/// </summary>

	class Dog
	{
		public string Name { get; set; }
		public bool IsNaughtyDog { get; set; }

		public Dog(string name, bool isNaughtyDog)
		{
			Name = name;
			IsNaughtyDog = isNaughtyDog;
		}

		public void GiveTreat(int numOfTreads)
		{
			Console.WriteLine("Dog: {0} said wuoff {1} times!", Name, numOfTreads);
		}
	}

	class DogShelter: IEnumerable<Dog>
	{
		public List<Dog> dogs;

		public DogShelter()
		{
			dogs = new List<Dog>()
			{
				new Dog("Casper", false),
				new Dog("Sif", true),
				new Dog("Oreo", false),
				new Dog("Pix", false),
			};
		}

        IEnumerator<Dog> IEnumerable<Dog>.GetEnumerator()
        {
			return dogs.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}

