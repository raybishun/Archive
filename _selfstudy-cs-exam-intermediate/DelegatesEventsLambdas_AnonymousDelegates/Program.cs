using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesEventsLambdas_AnonymousDelegates
{
    class Program
    {
        public delegate string MyDelegate(int arg1, int arg2);
        
        static void Main(string[] args)
        {
            MyDelegate f = delegate (int arg1, int arg2)
            {
                return (arg1 + arg2).ToString();
            };

            Console.WriteLine($"{f(10, 20)}");

            Console.ReadLine();
        }

        
    }
}
