using System;
namespace Section.Forth
{
	public class Section4
	{
        static string username;
        static string password;

        public static void Test()
        {
            TernaryOperator("2");
            Console.Read();
        }

        public static void Register()
        {
            Console.WriteLine("Please enter your username: ");
            username = Console.ReadLine();
            Console.WriteLine("Please enter your password: ");
            password = Console.ReadLine();
            Console.WriteLine("Registratin completed");
            Console.WriteLine("---------------------------------");
        }

        public static void Login()
        {
            Console.WriteLine("Please enter your username: ");
            if (username == Console.ReadLine())
            {
                Console.WriteLine("Please enter your password");
                if (password == Console.ReadLine())
                {
                    Console.WriteLine("Login succesful");
                }
                else
                {
                    Console.WriteLine("password is incorrect");
                }
            }
            else
            {
                Console.WriteLine("Usernaame is incorrect");
            }
        }

        public static void TernaryOperator(string temperature)
        {
            int myTemp;
            string output;
            bool success = int.TryParse(temperature, out myTemp);
            if (success)
            {
                output = myTemp <= 15 ? "it is too cold here" : myTemp > 28 ? "it is hot here" : "it is ok";
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine("Not a valid temperature");
            }
        }
    }

}

