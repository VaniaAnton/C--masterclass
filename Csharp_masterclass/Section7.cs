using System;

namespace Section.Seventh
{
	public class Arrays
	{
		public static void classicArray()
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
        public static void MultiDimensionalArray()
        {
            //declare 2d array
            string[,] matrix2D;


            //declare 3d array
            int[,,] matrix3D;

            // two dimensional array
            int[,] array2D = new int[,]
            {
            {1,2,3 },//row 0
            {4,5,6 },//row 1
            {7,8,9 }//row 2
            };

            Console.WriteLine("Central element is {0}", array2D[1,1]);

            string[,,] array3D = new string[,,]
            {
                {
                    {"000", "001" },
                    {"010", "011" }
                },
                {
                    {"100", "101" },
                    {"110", "111" }
                }
            };
            Console.WriteLine("Central element is {0}", array3D[1,0,1]);
            Console.ReadKey();
        }

        public static bool Checker(string[,] board)
        {

            //Horizontal check
            for (int i = 0, j = 0; i < board.GetLength(0); i++)
            {
                if (board[i, j] == board[i, j+1] && board[i, j + 1] == board[i, j+2])
                {
                    return true;
                }
            }
            //Vertical check
            for (int i = 0, j = 0; i < board.GetLength(0); j++)
            {
                if (board[i, j] == board[i+1, j] && board[+1, j] == board[i+2, j])
                {
                    return true;
                }
            }
            //Diagonal check
            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 2])
            {
                return true;
            }
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 0])
            {
                return true;
            }
            return false;
        }
        

	}
 
}

