using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02b_LambdaExpressions
{
    class Program
    {
        delegate decimal MathDelegate(int x, int y);

        static void Main(string[] args)
        {
            DoWork();

            Console.ReadLine();
        }

        static void DoWork()
        {
            MathDelegate mathDelegate = null;
            mathDelegate += ((param1In, param2In) => { return param1In * param2In; });
            Console.WriteLine($"{mathDelegate.Method.Name}: {mathDelegate.Invoke(2, 3)}");
        }
    }
}
