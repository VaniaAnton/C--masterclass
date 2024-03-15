using System;

namespace Section.Ninth
{
    //------------Inheritance examples--------------
	public class InheritanceDemo
	{
		public static void Test()
        {
            Radio myRadio = new Radio(false, "Sony");
            myRadio.SwitchOn();
            myRadio.ListenRadio();

            TV myTV = new TV(false, "Sansung");
            myTV.SwitchOn();
            myTV.WatchTV();
        }
	}
    //Child classes
    class Radio : ElectricalDevice
    {
        public Radio(bool isOn, string brand):base(isOn, brand){}
        //method to listen to the radio
        public void ListenRadio()
        {
            if (IsOn)
            {
                //listen to radio
                Console.WriteLine("Listening to the radio!");
            }
            else
            {
                //print the error
                Console.WriteLine("Radio is switched off, switch it on first");
            }
        }

    }
    class TV : ElectricalDevice
    {

        public TV(bool isOn, string brand):base(isOn, brand)
        {
            this.Brand = brand;
            this.IsOn = isOn;
        }
        //method to watch TV
        public void WatchTV()
        {
            if (IsOn)
            {
                //watch TV
                Console.WriteLine("Watching TV!");
            }
            else
            {
                //print the error
                Console.WriteLine("TV is switched off, switch it on first");
            }
        }
    }

    //Parent/Base class
    class ElectricalDevice
    {
        //boolean to determine the state ot the Electrical Device
        public bool IsOn { get; set; }
        //string for the brand name of Electrical Device
        public string Brand { get; set; }

        public ElectricalDevice(bool isOn, string brand)
        {
            this.Brand = brand;
            this.IsOn = isOn;
        }

        //switch on the Electrical Device
        public void SwitchOn()
        {
            IsOn = true;
        }
        //switch off the Electrical Device
        public void SwitchOff()
        {
            IsOn = false;
        }
    }

    //--------Virtual and Override methods----------

    public class VirtualOverrideDemo
    {
        public static void Test()
        {
            Dog dog = new Dog("Sif", 15);
            Console.WriteLine($"{dog.Name} is {dog.Age} years old");
            dog.MakeSound();
            dog.Play();
            dog.Eat();
        }
    }

    class Animal
    {
        //name property
        public string Name { get; set; }
        //age property
        public int Age { get; set; }
        //age property
        public bool IsHungry { get; set; }

        public Animal(string name, int age)
        {
            Age = age;
            Name = name;
            //in our case all our animals are hungry by default :)
            IsHungry = true;
        }

        //an empty virtuAL method for other classes to override
        public virtual void MakeSound()
        {

        }
        //a virtual method called Eat which sub classes can override
        public virtual void Eat()
        {
            if (IsHungry)
            {
                
                Console.WriteLine($"{Name} is eating");
            }
            else
            {
                Console.WriteLine($"{Name} is not hungry");
            }
        }

        public virtual void Play()
        {
            Console.WriteLine($"{Name} is playing");
        }
    }

    class Dog : Animal
    {
        //check if dog is happy
        public bool IsHappy { get; set; }

        //simple constructor where we pass the name and age to our base constructor
        public Dog(string name, int age):base(name, age)
        {
            // all dogs are happy :)
            IsHappy = true;
        }

        //simple override of the virtual method Eat()
        public override void Eat()
        {
            //to call the eat method from our base class we use the keyword "base"
            base.Eat();
        }

        // override of the virtual method Eat()
        public override void MakeSound()
        {
            //since every animal make a totally different sound
            //each animal will implement their own version of MakeSound
            Console.WriteLine("WUUF");

        }
        //override of the virtual method Play()
        public override void Play()
        {
            if (IsHappy)
            {
                base.Play();
            }
            
        }
    }

}

