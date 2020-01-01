using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_TPL
{
    class Program
    {
        static void Main(string[] args)
        {
            // TaskRun();
            //TaskFactory();
            //DelegateBuiltIn_Action();
            //Delegate();
            // AsyncAwait();
            Task_FromResult();

            Console.ReadLine();
        }

        static async void AsyncAwait()
        {
            await Task.Run(()=> DoWork1());
            Console.WriteLine("Done");
        }

        static async void Task_FromResult()
        {
            int result = await Task.FromResult<int>(GetSum(4, 5));
            Console.WriteLine(result);
        }

        static int GetSum(int a, int b)
        {
            return a + b;
        }

        static void TaskRun()
        {
            // Task.Run(() => DoWork1());

            Task.Run(() => PrintMessage("Hi"));

            Task t = Task.Run(() => PrintMessage("hello"));
        }

        static void TaskFactory()
        {
            Task.Factory.StartNew(() => DoWork2());
        }

        static void DelegateBuiltIn_Action()
        {
            //Task t = new Task(new Action(PrintMessage));
            //t.Start();

            Task.Run(new Action(PrintMessage));
        }

        static void Delegate()
        {
            Task t = new Task(delegate { PrintMessage(); });
            t.Start();

            Task t1 = new Task(delegate { PrintMessage("my message"); });
            t1.Start();
        }

        // ====================================================================
        // The Work Store
        // ====================================================================
        static void DoWork1()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void DoWork2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"\t{i}");
            }
        }

        static void PrintMessage()
        {
            Console.WriteLine("hi");
        }

        static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        static string SayHello(string name)
        {
            return $"Hello {name}!";
        }
    }
}
