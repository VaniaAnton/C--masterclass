using System;
using Internal;

namespace Section.Ninth
{
	public class InheritanceDemo
	{
		public Section9()
		{
		}
	}

    class Radio
    {
        //boolean to determine the state ot the radio
        public bool IsOn { get; set; }
        //string for the brand name of radio
        public string Brand { get; set; }

        public Radio(bool isOn, string brand)
        {
            this.Brand = brand;
            this.IsOn = isOn;
        }
        //switch on the radio
        public void SwitchOn()
        {
            IsOn = true;
        }
        //switch off the radio
        public void SwitchOff()
        {
            IsOn = false;
        }
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
    class TV
    {
        //boolean to determine the state ot the TV
        public bool IsOn { get; set; }
        //string for the brand name of TV
        public string Brand { get; set; }

        public TV(bool isOn, string brand)
        {
            this.Brand = brand;
            this.IsOn = isOn;
        }

        //switch on the TV
        public void SwitchOn()
        {
            IsOn = true;
        }
        //switch off the TV
        public void SwitchOff()
        {
            IsOn = false;
        }
        //method to watch TV
        public void ListenRadio()
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
}

