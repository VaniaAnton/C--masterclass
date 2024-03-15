using System;

namespace Section.Ninth
{
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

    //Child class
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
}

