using System;

namespace Section.Seventh
{
	public class Arrays
	{
		public static void Test()
        {
            //first way of initialiazing an array
            int[] grades = new int[5];

            grades[0] = 20;
            grades[1] = 15;
            grades[2] = 12;
            grades[3] = 9;
            grades[4] = 5;

            Console.WriteLine("grades at index 0 : {0}", grades[0]);

            string input = Console.ReadLine();
            //assign value to array grades at index 0
            grades[0] = int.Parse(input);
            Console.WriteLine("grades at index 0 : {0}", grades[0]);

            //second way of initialiazing an array
            int[] gradesOfMathStudentsA = { 20, 13, 12, 8, 8 };

            //third way of initialiazing an array
            int[] gradesOfMathStudentsB = new int[] { 20, 13, 12, 8, 8, 5 };

            //get length
            Console.WriteLine("Length of gradesOfMathStudentsA: {0}", gradesOfMathStudentsA.Length);
            Console.ReadKey();
        }
	}
}

