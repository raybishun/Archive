using System;

namespace _2_12_Adv_OptionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            // All REQUIRED parameters must be listed FIRST
            // All OPTIONAL parameters must be listed LAST
            OptionalParameterDemo("John");

            NamedParameterDemo(age: 25, lName: "Doe", fName: "John");
        }
        
        static void OptionalParameterDemo(string fName, string lName = null, int age = 0)
        {
            Console.WriteLine($"{lName}, {fName} is {age} years old.");
        }

        static void NamedParameterDemo(string fName, string lName = null, int age = 0)
        {
            Console.WriteLine($"{fName} {lName} is {age} years old.");
        }
    }
}
