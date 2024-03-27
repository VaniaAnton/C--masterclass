using System;
using System.Text.RegularExpressions;

namespace Section.Eleventh
{
	enum Day { Mo, Tu, we, Th, Fr, Sa, Su};
	enum Month { Jan = 1, Feb, Mar, Apr, May, Jun, Jul = 12, Aug, Sep, Oct, Nov, Dec};

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

			
			Console.WriteLine(Day.Mo);
			Console.WriteLine((int)Month.Feb);
		}
	}

	public class MathClass
	{
		public static void Test()
		{
			Console.WriteLine("Ceiling: " + Math.Ceiling(15.3));
			Console.WriteLine("Floor: " + Math.Floor(15.3));

			int n1 = 13;
			int n2 = 9;
			Console.WriteLine("Lower number is: " + Math.Min(n1,n2));
		}
	}
	public class RandomClass
	{
		public static void Test()
		{
			Console.WriteLine("Enter your question:");
			Console.ReadLine();
			Random yesNoMaybe = new Random();
			int answerNum = yesNoMaybe.Next(1, 4);
			if (answerNum == 1)
			{
				Console.WriteLine("Yes");
			}
			else if (answerNum == 2)
			{
				Console.WriteLine("Maybe");
			}
			else
			{
				Console.WriteLine("No");
			}
		}
	}

    class RegularExpression
    {
        public static void Test()
        {
			string pattern = @"\d";
			Regex regex = new Regex(pattern);

			string text = " Hi there, my number is 12314";

			MatchCollection matchCollection = regex.Matches(text);

			Console.WriteLine("{0} hits found:\n {1}", matchCollection.Count, text);

			foreach (Match hit in matchCollection)
			{
				GroupCollection group = hit.Groups;
				Console.WriteLine("Digit {0} found at {1} index", group[0].Value, group[0].Index);
			}
        }
    }
}

