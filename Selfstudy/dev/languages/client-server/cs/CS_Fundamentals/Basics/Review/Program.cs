using System;
using Review.Models;

namespace Review
{
    class Program
    {
        public int MyProperty { get; set; }

        static void Main(string[] args)
        {
            DoArrays();
            // DoPolymorphism();
            // DoTruth();
            // DoForLoop();
        }

        private static void DoArrays()
        {
            // Cannot implicitely convert type int[] to int[*,*]
            // int[,] nums = new int[5];
            int[] nums = new int[5];
        }

        private static void DoPolymorphism()
        {
            DbLogger appLogger;
            appLogger = new SqlLogger();
            appLogger.WriteToLog(); // SqlLogger implementation...
        }

        static void DoTruth()
        {
            Console.WriteLine(true && true); // True
            Console.WriteLine(false && false); // False
            Console.WriteLine(true && false); // False
            Console.WriteLine(false && true); // False
            Console.WriteLine();
            Console.WriteLine(true || true); // True
            Console.WriteLine(false || false); // False
            Console.WriteLine(true || false); // True
            Console.WriteLine(false || true); // True
        }

        static void DoForLoop()
        {
            int i = 0, x = 0;
            for (i = 1; i < 10; i += 3)
            {
                x = i * 2;
            }
            Console.WriteLine(x); // 14

            /*
                i	x
                ------
                1	2
                4	8
                7	14
                10
             */
        }
    }
}
