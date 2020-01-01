using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "this is an example of";
            s1 = s1 + " string contatentation";
            Console.WriteLine(s1);

            StringBuilder sb = new StringBuilder("this is an example of");
            sb.Append(" string contatentation");
            Console.WriteLine(sb);

            sb.AppendLine();
            sb.Append(" using StringBuilder...");

            sb.Replace("StringBuilder", "*** The StringBuilder Class ***");
            Console.WriteLine(sb);


            Console.ReadLine();
        }
    }
}
