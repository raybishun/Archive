﻿using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ManageProgramFlow
{
    class Parallel_ManagingLoops
    {
        static void WorkOnItem(object item)
        {
            Console.WriteLine($"Started working on: {item}");
            Thread.Sleep(100);
            Console.WriteLine($"Finished working on: {item}");
        }

        public static void DoWork()
        {
            var items = Enumerable.Range(0, 500).ToArray();

            ParallelLoopResult result =
                Parallel.For(0, items.Count(), (int i, ParallelLoopState loopState) =>
                {
                    if (i == 200)
                    {
                        loopState.Stop();
                    }

                    WorkOnItem(items[i]);
                });

            Console.WriteLine($"Completed: {result.IsCompleted}");
            Console.WriteLine($"Items: {result.LowestBreakIteration}");

            Console.WriteLine("Finished processing, Press any key...");
        }
    }
}
