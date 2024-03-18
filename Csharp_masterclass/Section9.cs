using System;
using System.Threading;

namespace Section.Ninth
{
    //------------Inheritance 1 examples--------------
	public class InheritanceDemo
	{
        //run code for Inheritance 1
		public static void Test()
        {
            //Radio myRadio = new Radio(false, "Sony");
            //myRadio.SwitchOn();
            //myRadio.ListenRadio();

            //TV myTV = new TV(false, "Sansung");
            //myTV.SwitchOn();
            //myTV.WatchTV();

            Post post1 = new Post("Thanks for the birthday wishes", true, "Denis Panos");
            Console.WriteLine(post1.ToString());

            ImagePost imagePost = new ImagePost("Check out my new shoes", "Denis Panos", "http://images.com/shoes", true);
            VideoPost videoPost = new VideoPost("FallVideo", "Denis Panos", "http://video.com/fallvideo", 100, true);

            videoPost.Play();
            Console.ReadKey();
            videoPost.Stop();


            Console.WriteLine(imagePost.ToString());
            Console.WriteLine(videoPost.ToString());
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


    //--------More about Inheritance 2------------

    class Post
    {
        private static int currentPostId;

        protected int  ID { get; set; }
        protected string Title { get; set; }
        protected string SendByUsername { get; set; }
        protected bool IsPublic { get; set; }

        public Post()
        {
            ID = 0;
            Title = "My first post";
            IsPublic = true;
            SendByUsername = "Denis Panos";
        }

        public Post(string title, bool isPublic, string sendByUsername)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.IsPublic = isPublic;
            this.SendByUsername = sendByUsername;
        }

        protected int GetNextID()
        {
            return ++currentPostId;
        }

        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2}", this.ID, this.Title, this.SendByUsername);
        }
    }

    //ImagePost derives from Post and adda a property (ImageURL) and two constructors
    class ImagePost : Post
    {
        public string ImageURL { get; set; }

        public ImagePost() { }

        public ImagePost(string title, string sendByUsername, string imageURL, bool isPublic)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.IsPublic = isPublic;
            this.SendByUsername = sendByUsername;

            this.ImageURL = imageURL;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - {3}", this.ID, this.Title, this.ImageURL,  this.SendByUsername);
        }
    }

    //VideoPost with Timer and CallBack methods
    class VideoPost : Post
    {
        //member field
        protected bool isPlaying = false;
        protected int currDuration = 0;
        Timer timer;

        //properties
        public string VideoURL { get; set; }
        public int Length { get; set; }

        public VideoPost() { }

        public VideoPost(string title, string sendByUsername, string videoURL, int length, bool isPublic)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.IsPublic = isPublic;
            this.SendByUsername = sendByUsername;

            this.VideoURL = videoURL;
            this.Length = length;
        }

        public void Play()
        {
            if (!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Playing");
                timer = new Timer(TimerCallback, null, 0, 1000);
            }
        }

        private void TimerCallback(Object o)
        {
            if (currDuration < Length)
            {
                currDuration++;
                Console.WriteLine("Video at {0}s", currDuration);
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }
        public void Stop()
        {
            if (isPlaying)
            {
                isPlaying = false;
                Console.WriteLine("Stoppped at {0}s", currDuration);
                currDuration = 0;
                timer.Dispose();
            }
         
        }
        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - {3} - {4}", this.ID, this.Title, this.VideoURL, this.Length,  this.SendByUsername);
        }




    }

}

