using System;

namespace DelegatesEventsLambdas_ComposableDelegates2
{
    delegate void MyDelegate(int arg1, ref int arg2);

    class Program
    {
        static void func1(int arg1, ref int arg2)
        {
            var result = (arg1 + arg2).ToString();
            arg2 += 20;
            Console.WriteLine($"{result}");
        }

        static void func2(int arg1, ref int arg2)
        {
            var result = (arg1 * arg2).ToString();
            Console.WriteLine($"{result}");
        }

        static void Main(string[] args)
        {
            int a = 10, b = 10;
            MyDelegate f1 = func1;
            MyDelegate f2 = func2;
            MyDelegate combined = f1 + f2;

            Console.WriteLine($"the value of b is: {b}");
            combined(a, ref b);
            Console.WriteLine($"the value of b is: {b}");


            Console.ReadLine();
        }
    }
}
