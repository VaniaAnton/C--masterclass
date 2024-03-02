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

        public static void JaggedArray()
        {
            //Declare jaggedArray
            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];

            jaggedArray[0] = new int[] {1,2,3,4,5};
            jaggedArray[1] = new int[] {6,7,8};
            jaggedArray[2] = new int[] {9,10};

            //Alternative way:
            int[][] jaggedArray2 = new int[][]
            {
                new int[] {1,2,3,4,5},
                new int[] {6,7,8}
            };

            //Print array
            for (int i = 0; i < jaggedArray2.Length; i++)
            {
                Console.WriteLine("Element {0}", i);
                for (int j = 0; j < jaggedArray2[i].Length; j++)
                {
                    Console.WriteLine("then {0}", jaggedArray2[i][j]);
                }
            }
        }

        public static void Params()
        {
            int price = 5;
            float pi = 3.14f;
            char at = '@';
            string book = "the Hobbit";

            string[] test = { "to", "pu", "du" };
            //ParamsMethod("to", "pu", "du", "to", "pu", "du", "to", "pu", "du", "to", "pu", "du");
            // ParamsMethod(test);
            ParamsMethod2(price, pi, at, book);
            ParamsMethod2("Hello)", 5.55, '$' );
        }
        public static void ParamsMethod(params string[] sentence)
        {
            for (int i = 0; i < sentence.Length; i++)
            {
                Console.Write(sentence[i]+ " ");
            }
        }

        public static void ParamsMethod2(params object[] stuff)
        {
            //for each loop to go through the array of objects
            foreach (object obj in stuff)
            {
                //print each obj followed by space
                Console.WriteLine(obj + " ");
            }
            Console.WriteLine();
        }
	}
 
}

