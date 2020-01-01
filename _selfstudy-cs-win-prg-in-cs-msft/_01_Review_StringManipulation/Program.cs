using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _01_Review_StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //StringBuilderDemo();
            //RegExDemo();
            Test();
        }

        static void StringBuilderDemo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("R");
            sb.Append("a");
            sb.Append("y");

            Console.WriteLine(sb.ToString());

            string name = sb.ToString();

            Console.WriteLine(name.ToUpper());

            string formatted = string.Format($"Demo: {name} \n {name.ToUpper()}");

            Console.WriteLine(formatted);
        }

        static void RegExDemo()
        {
            string s = "Hell0 W0rld";
            string myRegEx = "\\d";
            var r = Regex.Match(s, myRegEx, RegexOptions.None);
            if (r.Success)
            {
                Console.WriteLine("Match");
            }
        }

        static void Test()
        {
            string firstName = "John";
            string lastName = "Smith";
            string fullName = $"{lastName}, {firstName}";
            Console.WriteLine(fullName);
        }
    }
}
