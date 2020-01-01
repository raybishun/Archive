using System;

namespace _01_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string day in Enum.GetNames(typeof(Weekdays)))
            {
                Console.Write($"{day} ");
            }

            Console.WriteLine();

            foreach (int day in Enum.GetValues(typeof(Weekdays)))
            {
                Console.Write(  $"{((Weekdays)day).ToString()} ")  ;
            }
        }
    }
}
