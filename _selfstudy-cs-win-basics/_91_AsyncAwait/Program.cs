using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _91_AsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            AsyncAwaitDemo demo = new AsyncAwaitDemo();
            demo.DoStuff();

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Main thread running...");
            }


            Console.ReadLine();
        }
    }

    class AsyncAwaitDemo
    {
        public async Task DoStuff()
        {
            await Task.Run(() => {
                CountToFifty();
            });

            // This will not execute until CountToFifty() has completed!
            Console.WriteLine("counting to 50 completed.");
        }

        private static async Task<string>CountToFifty()
        {
            int i;

            for (i = 0; i < 50; i++)
            {
                Console.WriteLine($"BG thread: {i}");
            }

            return $"i: {i}";
        }
    }
}
