using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopQuiz_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            DoWorkAsync();

            Console.WriteLine("going to start doing something else...");

            Console.ReadLine();
        }

        static async void DoWorkAsync()
        {
            //Work1Async();
            //Work2Async();
            //Work3Async();

            string four = await Work4Async();
            Console.WriteLine(four);
        }

        static async void Work1Async()
        {
            for (int i = 0; i < 100; i++)
            {
                await Task.Run(() => Console.WriteLine($"{i}"));
            }
        }

        static async void Work2Async()
        {
            for (int i = 0; i < 100; i++)
            {
                await Task.Run(() => Console.WriteLine($"\t{i}"));
            }
        }

        static async void Work3Async()
        {
            for (int i = 0; i < 100; i++)
            {
                await Task.Run(() => Console.WriteLine($"\t\t{i}"));
            }
        }

        static async Task<string> Work4Async()
        {
            //await Task.Run(() => 
            //{
            //    for (int i = 0; i < 100; i++)
            //    {
            //        Console.WriteLine($"{i}");
            //    }
            //});

            string x = await Task.Run(() => "Done**********************************");
            return x;
            //return "=========================================";
        }
    }
}
