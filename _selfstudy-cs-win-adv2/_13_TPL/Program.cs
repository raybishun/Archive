using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace _13_TPL
{
    class Program
    {
        static void Main(string[] args)
        {
            //DoWorkStart();
            //MoreWork();

            Parallel_ForEach();


          



            Console.WriteLine("Press any key to quit...........................................");
            Console.ReadKey();
        }

        static async void DoWorkStart()
        {
            Task t1 = new Task(() => DoSomeVeryImportantWork(1, 1000));
            t1.Start();

            Task t2 = new Task(() => DoSomeVeryImportantWork(2, 1500));
            t2.Start();

            Task t3 = Task.Run(() => DoSomeVeryImportantWork(3, 1000));

            Task t4 = Task.Factory.StartNew(() => DoSomeVeryImportantWork(4, 1000));
            
            Task t5 = Task.Factory.StartNew(() => DoSomeVeryImportantWork(5, 1000));

            Task t6 = Task.Factory.StartNew(() => DoSomeVeryImportantWork(6, 1000));

            Task t7 = Task.Factory.StartNew(() => DoSomeVeryImportantWork(7, 1000)).ContinueWith((pTask) => DoSomeOtherVeryImportantWork(10, 1000));

            Task t8 = Task.Factory.StartNew(() => DoSomeVeryImportantWork(8, 1000)).ContinueWith((pTask) => DoSomeOtherVeryImportantWork(11, 1000));

            Task t9 = Task.Factory.StartNew(() => DoSomeVeryImportantWork(9, 1000)).ContinueWith((pTask) => DoSomeOtherVeryImportantWork(12, 1000));

            await Task.Run(() => Console.WriteLine("OK"));

            List<Task> tasks = new List<Task> { t1, t2, t3, t4, t5, t6, t7, t8, t9 };

            // await Task.WhenAll(tasks); or the below
            Task.WaitAll(tasks.ToArray());

            Console.WriteLine("Done");
        }


        static void DoSomeVeryImportantWork(int id, int sleepTime)
        {
            Console.WriteLine($"{id} is beginning");
            Thread.Sleep(1000);
            Console.WriteLine($"{id} is ending");
        }

        static void DoSomeOtherVeryImportantWork(int id, int sleepTime)
        {
            Console.WriteLine($"{id} is beginning MORE work");
            Thread.Sleep(1000);
            Console.WriteLine($"{id} is ending MORE work");
        }

        static void MoreWork()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(250);
                Console.WriteLine($"i = {i}");
            }
        }

        static void Parallel_ForEach()
        {
            List<int> intList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27,
            28, 29, 30};

            // thread blocking - the Parallel.ForEach must complete before proceeding...
            Parallel.ForEach(intList, (i) => { Console.WriteLine($"{i}"); });

            // thread blocking - the Parallel.For must complete before proceeding...
            Parallel.For(1, 100, (i) => { Console.WriteLine($"\t{i}"); });
            
        }
    }
}
