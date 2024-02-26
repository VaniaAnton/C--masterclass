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

        public static void ForEach()
        {
            int[] numbers = new int[10];

            for (int i = 0; i < 10; i++)
            {
                numbers[i] = i;
            }

            int counter = 0;
            foreach (var i in numbers)
            {
                Console.WriteLine("Element {0} = {1}",counter ,i);
                counter++;
            }

        }

	}
}

