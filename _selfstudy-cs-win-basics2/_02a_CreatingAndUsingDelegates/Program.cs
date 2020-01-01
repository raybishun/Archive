using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02a_CreatingAndUsingDelegates
{
    delegate decimal MathDelegate(int first, int second);

    class Program
    {
        static void Main(string[] args)
        {
            MathDelegate mathDelegate = null;
            mathDelegate += new MathDelegate(AddAndGoForward);
            mathDelegate += SubtractAndBePositive;
            // Console.WriteLine(mathDelegate.Invoke(200, 100));

            foreach (MathDelegate delMethod in mathDelegate.GetInvocationList())
            {
                Console.WriteLine(delMethod.Invoke(200, 100));
            }

            Console.ReadLine();
        }

        static decimal AddAndGoForward(int first, int second)
        {
            return first + second;
        }

        static decimal SubtractAndBePositive(int first, int second)
        {
            return first - second;
        }
    }
}
