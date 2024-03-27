using System;

namespace Section.Eleventh
{
	enum Day { Mo, Tu, we, Th, Fr, Sa, Su};
	enum Month { Jan = 1, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec};

	struct Game
	{
		public string name;
		public string developer;
		public double rating;
		public string releaseDate;

		// cannot create a default constructor, don't support inheritence
		
		public void Display()
		{
            Console.WriteLine("Game 1's name is: {0}", name);
            Console.WriteLine("Game 1's developer is: {0}", developer);
            Console.WriteLine("Game 1's rating is: {0}", rating);
            Console.WriteLine("Game 1's released is: {0}", releaseDate);
        }
	}

	public class Section11
	{
		public static void Test()
		{
			//Game game1;

			//game1.name = "Pokemon Go";
			//game1.developer = "Niantic";
			//game1.rating = 3.6;
			//game1.releaseDate = "01.07.2016";

			//game1.Display();

			Day fr = Day.Fr;
			Day su = Day.Su;

			Day a = Day.Fr;

			Console.WriteLine(fr == a);
			Console.WriteLine(Day.Mo);
			Console.WriteLine((int)Month.Feb);
		}
	}
}

