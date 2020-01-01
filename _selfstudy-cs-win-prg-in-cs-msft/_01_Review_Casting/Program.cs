using System;

namespace _01_Review_Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Basics();
            GuessNumber();

        }

        static void Basics()
        {
            string shortDate = "08/01/2018";
            DateTime dt = DateTime.Parse(shortDate);
            Console.WriteLine(dt.ToShortDateString());

            string longDate = dt.ToLongDateString();
            Console.WriteLine(longDate);
        }

        static void GuessNumber()
        {
            Console.Write("Guess a number: ");

            // int number = int.Parse(Console.ReadLine());


            string input = Console.ReadLine();
            int value = int.TryParse(input, out int result) ? int.Parse(input) : result;

            Console.WriteLine(value);
        }
    }
}
