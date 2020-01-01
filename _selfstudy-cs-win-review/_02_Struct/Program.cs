using System;

namespace _02_Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock s = new Stock
            {
                Close = 100.25m
            };

            Console.WriteLine(string.Format($"{s.Close:C}"));

            // Create struct on the stack
            Future f;
            f.Close = 99.35m;
            Console.WriteLine(string.Format($"{f.Close:C}"));
        }
    }
}
