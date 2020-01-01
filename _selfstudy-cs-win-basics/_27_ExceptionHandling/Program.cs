using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            // DivideByZeroException();

            UsingChecked();

            Console.ReadLine();
        }

        static void DivideByZeroException()
        {
            int a = 4;
            int b = 0;

            try
            {
                Console.WriteLine($"{a / b}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void UsingChecked()
        {

            checked
            {
                // Overflow is not caught w/o checked
                // However, checked will catch the Overflow at runtime


                // set i to 10,000,000
                int i = 10000000;

                for (; i < int.MaxValue; i++)
                {
                    // i = whatever it was before, plus another 10M
                    i += 10000000;
                    Console.WriteLine(i);
                }
            }
        }
    }
}
