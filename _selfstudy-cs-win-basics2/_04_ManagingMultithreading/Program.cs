using System;
using System.Threading;

// ****************************************************************************
// Using the [lock] statement
// ****************************************************************************

namespace _04_ManagingMultithreading
{
    class Program
    {
        static void Main(string[] args)
        {
            DoWork();

            Console.ReadLine();
        }

        static void DoWork()
        {
            LoockingForSafety();
        }

        static void LoockingForSafety()
        {
            Thread[] threads = new Thread[10];
            Account acc = new Account(1000);
            for (int i = 0; i < 10; i++)
            {
                Thread t = new Thread(new ThreadStart(acc.DoTransactions));
                threads[i] = t;
            }

            for (int i = 0; i < 10; i++)
            {
                threads[i].Start();
            }
        }
    }
}
