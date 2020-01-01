using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _87_Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(DoWork1);
            t1.Start();

            Thread t2 = new Thread(DoWork2);
            t2.Start();

            Thread t3 = new Thread(() => {
                for (int i = 0; i < 1000; i++)
                {
                    Console.Write(" & ");
                }
            });
            t3.Start();

            TaskFactory tf = new TaskFactory();
            tf.StartNew(() => {
                for (int i = 0; i < 1000; i++)
                {
                    Console.Write(" % ");
                }
            });


            Console.ReadLine();
        }

        static void DoWork1()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("O");
            }
        }

        private static void DoWork2()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write(" . ");
            }
        }
    }
}
