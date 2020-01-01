using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace _2_13_Adv_TaskParallelLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            // TaskDemo();
            // TaskDemo2();
            // TaskFactoryDemo();
            // TaskFactoryContinueWithDemo();
            // TaskWaitAll();
            // ParallelForEach();
            // ParallelFor();
            TaskCancellationToken();

            Console.WriteLine("Press any key to quit.");
            Console.ReadKey();
        }

        static void TaskDemo()
        {
            Task t1 = new Task(() =>
            {
                Console.WriteLine("task 1 has started...");
                Thread.Sleep(1000);
                Console.WriteLine("task 1 has completed.");
            });
            t1.Start();
        }

        private static void TaskDemo2()
        {
            Task t1 = new Task(() => DoWork(1, 1500));
            t1.Start();

            Task t2 = new Task(() => DoWork(2, 3000));
            t2.Start();

            Task t3 = new Task(() => DoWork(3, 1000));
            t3.Start();
        }

        private static void TaskFactoryDemo()
        {
            var t1 = Task.Factory.StartNew(() => DoWork(1, 1500));
            
            var t2 = Task.Factory.StartNew(() => DoWork(2, 3000));
            
            var t3 = Task.Factory.StartNew(() => DoWork(3, 1000));
        }

        private static void TaskFactoryContinueWithDemo()
        {
            var t1 = Task.Factory.StartNew(() => DoWork(1, 1500))
                .ContinueWith((prevTask) => DoMoreWork(2, 1000));

            var t2 = Task.Factory.StartNew(() => DoWork(3, 2000))
                .ContinueWith((prevTask) => DoMoreWork(4, 500));

            var t3 = Task.Factory.StartNew(() => DoWork(5, 1000))
                .ContinueWith((prevTask) => DoMoreWork(6, 100));
        }

        private static void TaskWaitAll()
        {
            var t1 = Task.Factory.StartNew(() => DoWork(1, 1500))
                .ContinueWith((prevTask) => DoMoreWork(2, 1000));

            var t2 = Task.Factory.StartNew(() => DoWork(3, 1000))
                .ContinueWith((prevTask) => DoMoreWork(4, 500));

            var t3 = Task.Factory.StartNew(() => DoWork(5, 1000))
                .ContinueWith((prevTask) => DoMoreWork(6, 100));

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"\t\t....................starting #{i}.");
                Thread.Sleep(250);
                Console.WriteLine($"\t\t....................completed #{i}.");
            }

            var tasks = new List<Task> { t1, t2, t3 };
            Task.WaitAll(tasks.ToArray());

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"\t\t....................starting #{i}.");
                Thread.Sleep(250);
                Console.WriteLine($"\t\t....................completed #{i}.");
            }
        }

        private static void ParallelForEach()
        {
            List<int> list = new List<int>
                { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597 };

            Parallel.ForEach(list, (int i) => Console.WriteLine($"{i}"));
        }

        private static void ParallelFor()
        {
            Parallel.For(0, 11, (int i) => Console.WriteLine($"{i}"));
        }

        private static void TaskCancellationToken()
        {
            var source = new CancellationTokenSource();

            try
            {
                var t1 = Task.Factory.StartNew(() => DoWorkWithCancellationChecking(1, 1000, source.Token))
                    .ContinueWith((prevTask) => DoMoreWorkWithCancellationChecking(2, 1500, source.Token));

                // Test cancelling...
                // source.Cancel();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType());
            }
        }


        // The work...
        static void DoWork(int id, int sleepTime)
        {
            Console.WriteLine($"task {id} has started...");
            Thread.Sleep(sleepTime);
            Console.WriteLine($"task {id} has completed.");
        }

        static void DoMoreWork(int id, int sleepTime)
        {
            Console.WriteLine($"\ttask {id} has started more work...");
            Thread.Sleep(sleepTime);
            Console.WriteLine($"\ttask {id} has completed all of it's work.");
        }

        static void DoWorkWithCancellationChecking(int id, int sleepTime, CancellationToken token)
        {
            if (!token.IsCancellationRequested)
            {
                Console.WriteLine($"task {id} has started...");
                Thread.Sleep(sleepTime);
                Console.WriteLine($"task {id} has completed.");
            }
            else
            {
                token.ThrowIfCancellationRequested();
            }
        }

        static void DoMoreWorkWithCancellationChecking(int id, int sleepTime, CancellationToken token)
        {
            if (!token.IsCancellationRequested)
            {
                Console.WriteLine($"\ttask {id} has started more work...");
                Thread.Sleep(sleepTime);
                Console.WriteLine($"\ttask {id} has completed all of it's work.");
            }
            else
            {
                token.ThrowIfCancellationRequested();
            }
        }
    }
}
