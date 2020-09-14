using System;

namespace Week3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Login Form
             * login: admin
             * password:pass1234
             * Create a program that asks user's login credentials
             * Check if the user entered correct login and password
             * If the login and password are correct display 'Welcome'
             * If the login or password are incorrect dispay 'try again'
             
             
             */
            string Login;
            string Password;
            Console.WriteLine(" login:  ");
            Login = Console.ReadLine();           
            Console.WriteLine(" Password:  ");
            Password = Console.ReadLine();

            if ((Login == "admin") && (Password == "pass1234"))
            {
                Console.WriteLine("Welcome Tovarish!");
            } else if ((Login == "admin") && (Password != "pass1234"))
            {
                Console.WriteLine("Get to the gulag  you western spy");
            } else if ((Login != "admin") && (Password == "pass1234"))
            {
                Console.WriteLine("what are you doing here capitalist pig");


            }
            else
            {
                Console.WriteLine("Stalin will destroy you");
            }
        }   
    }
}
