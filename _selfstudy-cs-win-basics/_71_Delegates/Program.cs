using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _71_Delegates
{
    class Program
    {
        delegate void del(int x, int y);

        static void Main(string[] args)
        {
            Mark m = new Mark();
            del d = m.AddNumbers;
            d += m.MultipleNumbers;
            d(3, 3);


            Console.ReadLine();
        }
    }

    class Mark
    {
        public void AddNumbers(int a, int b)
        {
            Console.WriteLine($"a + b = {a + b}");
        }

        public void MultipleNumbers(int a, int b)
        {
            Console.WriteLine($"a * b = {a * b}");
        }
    }
}
