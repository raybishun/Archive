using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ManageProgramFlow
{
    class Parallel_ForEach
    {
        static void WorkOnItem(object item)
        {
            Console.WriteLine($"Started working on: {item}");
            Thread.Sleep(100);
            Console.WriteLine($"Finished working on: {item}");
        }

        public static void DoWork()
        {
            var items = Enumerable.Range(0, 1000);

            Parallel.ForEach(items, item => {

                WorkOnItem(item);

            });

            Console.WriteLine("Finished processing, Press any key...");
        }
    }
}
