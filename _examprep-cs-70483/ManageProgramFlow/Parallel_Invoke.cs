using System;
using System.Threading.Tasks;

namespace ManageProgramFlow
{
    class Parallel_Invoke
    {
        // Parallel.Invoke runs on all cores at the same time)

        static void Task1()
        {
            Console.WriteLine("Task 1 starting");

            for (int i = 0; i < 100000; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("Task 1 ending");
        }

        static void Task2()
        {
            Console.WriteLine("Task 2 starting");

            for (int i = 0; i < 10000; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine($"\t{i}");
                }
            }

            Console.WriteLine("Task 2 ending");
        }

        public static void DoWork()
        {
            // Parallel.Invoke(() => Task1(), () => Task2());

            Parallel.Invoke(() => Task1());

            Console.WriteLine("Finished processing, Press any key...");
        }
    }
}
