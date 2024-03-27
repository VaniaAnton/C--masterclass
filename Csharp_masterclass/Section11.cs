using System;

namespace Section.Eleventh
{
	struct Game
	{
		public string name;
		public string developer;
		public double rating;
		public string releaseDate;

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
			Game game1;

			game1.name = "Pokemon Go";
			game1.developer = "Niantic";
			game1.rating = 3.6;
			game1.releaseDate = "01.07.2016";

			game1.Display();
		}
	}
}

