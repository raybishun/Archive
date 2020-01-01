using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTaskRunApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            Action a = DoWork2;
            Task.Run( a );
            Console.ReadKey();
            

            Task<string> t = Task.Run(() => DoWork1());
            Console.WriteLine(t.Result);
            Console.ReadKey();

            Task.Run(() => DoWork2());

            // Task.Run
            Task.Run(() =>
            {
                for (int i = 0; i < 1000; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            });
            Task.Run(() =>
            {
                for (int i = 0; i < 1000; i++)
                {
                    if (!(i % 2 == 0))
                    {
                        Console.WriteLine($"\t{i}");
                    }
                }
            });

            // Task.Factory
            Task.Factory.StartNew(() => DoWork1());
            Task.Factory.StartNew(() =>
            {
                for (int i = 0; i < 1000; i++)
                {
                    if (!(i % 2 == 0))
                    {
                        Console.WriteLine($"\t{i}");
                    }
                }
            });


            Console.ReadLine();
        }

        static string DoWork1()
        {
            for (int i = 0; i < 1000; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i}");
                }
            }
            return "Done.";
        }

        static void DoWork2()
        {
            for (int i = 0; i < 1000; i++)
            {
                if (!(i % 2 == 0))
                {
                    Console.WriteLine($"\t{i}");
                }
            }
        }
    }
}
