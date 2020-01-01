using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Test2
{
    delegate void CalcDelegate();
    delegate void CalcDelegate2(int a, int b);
    delegate int CalcDelegate3(int a, int b);

    class Program
    {
        static void Main(string[] args)
        {
            // CalcDelegateWorker();
            // CalcDelegateWorker2();
            // CalcDelegateWorker3();


            //Action action = Add;
            //action += Sub;
            //action();

            //Action<int, int> action2 = Add;
            //action2 += Sub;
            //action2(5, 3);

            Func<int, int, int> func = Add3;
            func += Sub3;
            Console.WriteLine(func(5, 3));


            Console.ReadLine();
        }




        static void CalcDelegateWorker3()
        {
            CalcDelegate3 c3 = Add3;
            c3 += Sub3;
            Console.WriteLine(c3(5,3));
        }

        static int Add3(int a, int b)
        {
            return a + b;
        }

        static int Sub3(int a, int b)
        {
            return a - b;
        }






        static void CalcDelegateWorker2()
        {
            CalcDelegate2 c2 = Add;
            c2 += Sub;
            c2(9, 8);
        }

        static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        static void Sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }




        #region CalcDelegateWorker
        static void CalcDelegateWorker()
        {
            CalcDelegate calc = Add;
            calc += Sub;
            calc();
        }

        static void Add()
        {
            Console.WriteLine(5 + 3);
        }

        static void Sub()
        {
            Console.WriteLine(5 - 3);
        }
        #endregion
    }
}
