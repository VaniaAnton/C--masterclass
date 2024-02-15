using System;

namespace Section.Third
{
	public class Section3
	{
            public static void Test()
            {
                string n1 = "A";
                string n2 = "B";
                string n3 = "C";
                GreetFriend(n1, n2, n3);
            }

            static void GreetFriend(string a, string b, string c)
            {
                Console.WriteLine("Hi {0}, my Friend", a);
                Console.WriteLine("Hi {0}, my Friend", b);
                Console.WriteLine("Hi {0}, my Friend", c);
            }
        
	}
}

