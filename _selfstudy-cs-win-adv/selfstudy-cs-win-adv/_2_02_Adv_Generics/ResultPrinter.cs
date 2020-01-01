using System;

namespace _2_02_Adv_Generics
{
    class ResultPrinter
    {
        public void Print<X, Y>(Result<X, Y> result)
        {
            Console.WriteLine($"{result.Success}, {result.Data}");
        }
    }
}
