using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02c_AnonymousMethods
{
    class Program
    {
        delegate decimal MathDelegate(int x, int y);

        static void Main(string[] args)
        {
            DoWork();

            Console.ReadLine();
        }


        static void DoWork()
        {
            Thread t1 = new Thread(delegate() 
            {
                Console.WriteLine("Hello, ");
                Console.WriteLine("World!");
            });
            t1.Start();

            MathDelegate mathDelegate = new MathDelegate(delegate(int i, int j)
            {
                return i / j;
            });

            decimal result = mathDelegate.Invoke(3333, 11);
            Console.WriteLine(result);
        }
    }
}
