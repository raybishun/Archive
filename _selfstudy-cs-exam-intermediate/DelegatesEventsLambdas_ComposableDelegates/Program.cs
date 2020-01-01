using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesEventsLambdas_ComposableDelegates
{
    public delegate void MyDelegate(int arg1, int arg2);

    class Program
    {
        static void func1(int arg1, int arg2)
        {
            string result = (arg1 + arg2).ToString();
            Console.WriteLine($"1. {result}");
        }

        static void func2(int arg1, int arg2)
        {
            string result = (arg1 * arg2).ToString();
            Console.WriteLine($"2. {result}");
        }

        static void Main(string[] args)
        {
            MyDelegate f1 = func1;
            MyDelegate f2 = func2;
            MyDelegate f1f2 = f1 + f2;

            f1(10, 20);
            f2(10, 20);
            f1f2(10, 20); // chained delegates


            Console.ReadLine();
        }
    }
}
