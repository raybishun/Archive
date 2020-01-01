using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _01_ManagePrgFlow_ImplMultithreadingAndAsyncProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            GetCurrentThreadInfo();
        }

        static void GetCurrentThreadInfo()
        {
            // Get the thread currently executing this method
            Thread currentThread = Thread.CurrentThread;

            Console.WriteLine(currentThread.Priority);
            Console.WriteLine(currentThread.ThreadState);
            Console.WriteLine(currentThread.ManagedThreadId);
            Console.WriteLine(currentThread.IsThreadPoolThread);
            Console.WriteLine(currentThread.IsBackground);
            Console.WriteLine(currentThread.IsAlive);
            Console.WriteLine(currentThread.ExecutionContext);
            Console.WriteLine(currentThread.GetApartmentState());

            Console.ReadLine();
        }

    }
}
