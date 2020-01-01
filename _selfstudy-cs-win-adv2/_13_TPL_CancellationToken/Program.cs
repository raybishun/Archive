using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _13_TPL_CancellationToken
{
    class Program
    {
        static void Main(string[] args)
        {
            CancellationTokenSource source = new CancellationTokenSource();

            try
            {
                Task t1 = Task.Factory.StartNew(() => DoSomeVeryImportantWork(1, 1200, source.Token))
                .ContinueWith((pTask) => DoSomeOtherVeryImportantWork(2, 3000, source.Token));

                source.Cancel();

            }
            catch (Exception ex)
            {
                // Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType());
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }

        static void DoSomeVeryImportantWork(int id, int sleepTime, CancellationToken token)
        {
            if (token.IsCancellationRequested)
            {
                Console.WriteLine("Cancellation requestd.");
                token.ThrowIfCancellationRequested();
            }

            Console.WriteLine($"task {id} is beginning");
            Thread.Sleep(sleepTime);
            Console.WriteLine($"task {id} is ending");
        }

        static void DoSomeOtherVeryImportantWork(int id, int sleepTime, CancellationToken token)
        {
            if (token.IsCancellationRequested)
            {
                Console.WriteLine("Cancellation requestd.");
                token.ThrowIfCancellationRequested();
            }

            Console.WriteLine($"task {id} is beginning");
            Thread.Sleep(sleepTime);
            Console.WriteLine($"task {id} is ending");
        }
    }
}
