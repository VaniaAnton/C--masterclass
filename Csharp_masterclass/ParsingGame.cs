using System;
using System.Text.RegularExpressions;

namespace Section.Tenth.Game
{
	public class ParsingGame
	{
		public static void Test()
		{
			string[] lines = System.IO.File.ReadAllLines(@"/Users/5_vania_5/Desktop/Udemy/C# masterclass/Course/Csharp_masterclass/Assets/input.txt");

			using (StreamWriter file = new StreamWriter(@"/Users/5_vania_5/Desktop/Udemy/C# masterclass/Course/Csharp_masterclass/Assets/output.txt", true))
			{
				foreach (string line in lines)
				{
					if (line.Contains("split"))
					{
						string[] savedWords = line.Split();
						file.Write(savedWords[4] + " ");
					}
				}
			}

            string text = System.IO.File.ReadAllText(@"/Users/5_vania_5/Desktop/Udemy/C# masterclass/Course/Csharp_masterclass/Assets/input2.txt");
            string pattern = @"\d{3}|\d{2}";
            Regex regex = new Regex(pattern);

            MatchCollection matchCollection = regex.Matches(text);

            using (StreamWriter file = new StreamWriter(@"/Users/5_vania_5/Desktop/Udemy/C# masterclass/Course/Csharp_masterclass/Assets/output.txt", true))
            {
                foreach (Match match in matchCollection)
                {
					int numbers = int.Parse(match.Value);
					file.Write((char)numbers);
                }
            }



        }
      
    }
}

