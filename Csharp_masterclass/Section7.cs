using System;
using System.Collections;

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
            //ParamsMethod2(price, pi, at, book);
            //ParamsMethod2("Hello)", 5.55, '$' );

            Console.WriteLine(GetMin(2, 5, 6, 8, 9, -3, 0, 7, 4, 3, 2, 2));


        }

        public static void ArraysList()
        {
            //declaring an ArrayList
            ArrayList myArrList = new ArrayList();
            ArrayList myArrList2 = new ArrayList(100);

            myArrList.Add("Something");
            myArrList.Add('$');
            myArrList.Add(5);
            myArrList.Add(12);
            myArrList.Add(5);
            myArrList.Add(5.5);

            //delete element with specific value from my list
            myArrList.Remove(5);

            //delete element at specific position
            myArrList.RemoveAt(1);

            Console.WriteLine(myArrList.Count);

            double sum = 0;
            foreach (object obj in myArrList)
            {
                if (obj is int)
                {
                    sum += Convert.ToDouble(obj);
                }
                else if (obj is double)
                {
                    sum += (double)obj;
                }
                else if (obj is string)
                {
                    Console.WriteLine(obj);
                }
            }
            Console.WriteLine(sum);


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

        public static int GetMin(params int[] numbers)
        {
            int min = int.MaxValue;
            foreach (int num in numbers)
            {
                if (num < min)
                {
                    min = num;
                }
            }
            return min;
        }

        public static void HashTables()
        {
            Hashtable studentsTable = new Hashtable();

            //create hashtable
            Student student1 = new Student(1, "Maris", 98);
            Student student2 = new Student(2, "Oleg", 76);
            Student student3 = new Student(3, "Ivan", 43);
            Student student4 = new Student(4, "Pablo", 55);

            //add data
            studentsTable.Add(student1.Id, student1);
            studentsTable.Add(student2.Id, student2);
            studentsTable.Add(student3.Id, student3);
            studentsTable.Add(student4.Id, student4);

            //retrieve individual item with khown ID
            Student storedStudent1 = (Student)studentsTable[student1.Id];

            //retrieve all values from a hashtable
            foreach (DictionaryEntry entry in studentsTable)
            {
                Student temp = (Student)entry.Value;
                Console.WriteLine("Student Id:{0}, Name {1}, GPA {2}", temp.Id, temp.Name, temp.GPA);
            }

            foreach (Student value in studentsTable.Values)
            {
                Console.WriteLine("Student Id:{0}, Name {1}, GPA {2}", value.Id, value.Name, value.GPA);
            }

            //Console.WriteLine("Student Id:{0}, Name {1}, GPA {2}", storedStudent1.Id, storedStudent1.Name, storedStudent1.GPA);
        }
	}

    class Student
    {
        public int  Id { get; set; }

        public string  Name { get; set; }

        public float  GPA { get; set; }

        public Student(int id, string name, float gpa)
        {
            this.Id = id;
            this.Name = name;
            this.GPA = gpa;
        }
    }
 
}

