using System;

namespace ConsoleAppCodeShow
{
    class Program
    {
        static void Main(string[] args)//always starts here
        {
            Console.WriteLine("Hello World!");
            Example2();
        }

        static void Example1()
        {
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

    }//end of class program
}//end of namespace
