using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_NamedArguments_OptionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            // Named arguments example
            SayHello(age: 25, name: "Ray");

            // Optional parameter example
            SayHello("Peter");

            Console.ReadLine();
        }
        
        static void SayHello(string name, int age = 99)
        {
            Console.WriteLine($"Name: {name}, Age: {age}.");
        }
    }
}
