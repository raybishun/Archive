using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _60_ExtensionMethods
{
    // Is a static method in a static class, 
    // that uses the 'this' modifier
    // and the 'this' modifier, must me the FIRST parameter

    class Program
    {
        static void Main(string[] args)
        {
            string x = "Hello";
            string y = "hello";

            Console.WriteLine($"Is {x} cap? {x.IsCap()}");
            Console.WriteLine($"Is {y} cap? {y.IsCap()}");

            Console.ReadLine();
        }
    }

    static class StringCap
    {
        public static bool IsCap(this string s)
        {
            //if (string.IsNullOrEmpty(s))
            //{
            //    return false;
            //}
            //else
            {
                return char.IsUpper(s[0]);
            }
        }
    }
}
