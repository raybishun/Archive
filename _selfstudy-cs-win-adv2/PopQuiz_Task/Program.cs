using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopQuiz_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            DoWork();


            Console.ReadLine();
        }

        static void DoWork()
        {
            Task<int> sum = AddAsync(5, 3);
            Console.WriteLine(sum.Result);
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static async Task<int> AddAsync(int a, int b)
        {
            int sum = await Task.Run(() => a + b);
            return sum;
        }
    }
}
