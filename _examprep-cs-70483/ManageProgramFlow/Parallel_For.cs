using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ManageProgramFlow
{
    class Parallel_For
    {
        static void WorkOnItem(object item)
        {
            Console.WriteLine($"Started working on: {item}");
            Thread.Sleep(100);
            Console.WriteLine($"Finished working on: {item}");
        }

        public static void DoWork()
        {
            var items = Enumerable.Range(0, 5000).ToArray();

            Parallel.For(0, items.Length, i => {

                WorkOnItem(i);

            });

            Console.WriteLine("Finished processing, Press any key...");
        }
    }
}
