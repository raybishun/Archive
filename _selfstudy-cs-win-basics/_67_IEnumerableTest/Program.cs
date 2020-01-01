using System;
using System.Collections.Generic;

namespace _67_IEnumerableTest
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (int num in Numbers())
            {
                Console.WriteLine(num);
            }

            Console.ReadLine();
        }

        static IEnumerable<int> Numbers()
        {
            yield return 1;
            yield return 2;
            yield return 3;
        }
    }
}
