using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTaskRunApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var job1 = Task.Run(() => 
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(i);
                }

                return "Done from 99";
            });

            var job2 = Task.Run(() =>
            {
                for (int i = 1000; i < 1100; i++)
                {
                    Console.WriteLine(i);
                }

                return "Done from 1999";
            });


            Console.WriteLine(job1.Result);
            Console.WriteLine(job2.Result);

            Console.ReadLine();
        }
    }
}
