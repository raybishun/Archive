using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deletate_Test
{
    //delegate void MyDelegate1();
    //delegate void MyDelegate2(int arg1, int arg2);

    class Program
    {
        static void Main(string[] args)
        {
            //MyDelegate1 plug = new MyDelegate1(Add);
            //plug += Sub;
            //plug();

            //MyDelegate2 plug = new MyDelegate2(Add);
            //plug += Sub;
            //plug(9, 4);

            //MyDelegate1 plug = Add;
            //plug += Sub;
            //plug();

            //MyDelegate2 plug = Add;
            //plug += Sub;
            //plug(9, 4);

            //Action action = Add;
            //action += Sub;
            //action();

            //Action<int, int> action = Add;
            //action += Sub;
            //action(9, 4);

            Func<int, int, int> func = Add_With_Return;
            func += Sub_With_Return;
            Console.WriteLine($"{func(9, 4)}");


            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine($"{5 + 3}");
        }

        static void Add(int a, int b)
        {
            Console.WriteLine($"{a + b}");
        }

        static int Add_With_Return(int a, int b)
        {
            return a + b;
        }

        static void Sub()
        {
            Console.WriteLine($"{5 - 3}");
        }

        static void Sub(int a, int b)
        {
            Console.WriteLine($"{a - b}");
        }

        static int Sub_With_Return(int a, int b)
        {
            return a - b;
        }
    }
}
