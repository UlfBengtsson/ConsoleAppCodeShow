using System;

namespace ConsoleAppCodeShow
{
    /*
    static void BadSpotForAMethod()
    {

    }
    */

    class Program
    {
        static void Main(string[] args)//always starts here
        {
            Console.WriteLine("Hello World!");

            do
            {
                Console.WriteLine("--- Menu ---\nPress number key to run menu option\n1: Example 1\n2: Example 2\n3: About me\n4: Say hello to me");

                char userKeyPress = Console.ReadKey(true).KeyChar;

                switch (userKeyPress)
                {
                    case '1':
                        Example1();
                        break;
                    case '2':
                        Example2();
                        break;
                    case '3':
                        AboutMe();
                        break;
                    case '4':
                        string userFirstName = AskUserFor("first name");
                        string userLastName = AskUserFor("last name");
                        int userAge = AskUserFor("age", true);

                        Console.WriteLine("Hello {0} {1} your age is {2}", userFirstName, userLastName, userAge );
                        break;
                    default:
                        Console.WriteLine("Invalid keypress");
                        break;
                }


                Console.WriteLine("Press y key to continue or another key too exit.");
            } while (Console.ReadKey(true).KeyChar == 'y');

        }

        static void Example1()
        {
            Console.Write("Type in a bear: ");
            string bear = Console.ReadLine();

            Console.WriteLine(bear == "Bamse" ? "Thunder honey" : "Honey");
        }

        static void Example2()
        {
            Console.Write("Count down to zero from: ");
            int number = Convert.ToInt32(Console.ReadLine());

            while (number >= 0)
            {
                Console.WriteLine("Number is: " + number--);
            }
        }

        static void AboutMe()
        {
            Console.WriteLine("My name is Ulf");
        }

        static string AskUserFor(string what)
        {
            Console.Write($"Please type in {what}: ");
            return Console.ReadLine();
        }

        static int AskUserFor(string what, bool isNumber)
        {
            return Convert.ToInt32( AskUserFor(what) );
        }

    }//end of class program
}//end of namespace
