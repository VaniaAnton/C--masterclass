using System;
using System.Threading.Tasks;
using System.IO;
namespace Section.Tenth.TextFile
{
	public class TextFile
	{
		public static void Test()
		{
            // Writing into the text METHOD 1
            string[] lines = { "First 250", "Second 242", "Third 240" };
			File.WriteAllLines(@"/Users/5_vania_5/Desktop/Udemy/C# masterclass/Course/Csharp_masterclass/Assets/highscores.txt", lines);
			/*
            // METHOD 2 
            Console.WriteLine("Enter the file name");
            string fileName = Console.ReadLine();
            Console.WriteLine("Enter the text for the file");
            string input = Console.ReadLine();
			File.WriteAllText(@"/Users/5_vania_5/Desktop/Udemy/C# masterclass/Course/Csharp_masterclass/Assets/" + fileName + ".txt", input);
			*/
            // METHOD 3
			using(StreamWriter file = new StreamWriter(@"/Users/5_vania_5/Desktop/Udemy/C# masterclass/Course/Csharp_masterclass/Assets/myText.txt"))
			{
				foreach (string line in lines)
				{
					if (line.Contains("Third"))
					{
						file.WriteLine(line);
					}
				}
			}
            using (StreamWriter file = new StreamWriter(@"/Users/5_vania_5/Desktop/Udemy/C# masterclass/Course/Csharp_masterclass/Assets/myText.txt", true))
			{
				file.WriteLine("Additional line");
			}


            /*
			//Example 1 - reading the text
			string text = System.IO.File.ReadAllText(@" / Users/5_vania_5/Desktop/Udemy/C# masterclass/Course/Csharp_masterclass/Assets/textFile.txt");
			Console.WriteLine("TextFile contains following text: \n {0}", text);

            //Example 2 - reading the text
            string[] lines = System.IO.File.ReadAllLines(@"/Users/5_vania_5/Desktop/Udemy/C# masterclass/Course/Csharp_masterclass/Assets/textFile.txt");
			Console.WriteLine("Contents of textFile.txt = ");
			foreach (string line in lines)
			{
				Console.WriteLine("\t" + line);
			}
			*/
        }
    }
}

