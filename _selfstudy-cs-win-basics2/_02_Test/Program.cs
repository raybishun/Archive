using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02_Test
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.ReadLine();
        }

        static void Question_Thread()
        {
            Thread t1 = new Thread
                (delegate ()
                {
                    Console.WriteLine("Hello");
                });
            t1.Start();
        }
    }
}
