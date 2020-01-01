using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48_Boxing_UnBoxing
{
    class Program
    {
        static void Main(string[] args)
        {
            Boxing();
            UnBoxing();

            Console.ReadLine();
        }

        static void Boxing()
        {
            // 1. Converting a Value-Type into a Reference-Type
            // 2. This is a (cheap) implict operation


            int myInt = 5;
            object myObjet = myInt;
            Console.WriteLine(myObjet);
        }

        static void UnBoxing()
        {
            // 1. Converting a Reference-Type into a Value-Type
            // 2. This is an (expensive) explicit operation

            object myObject = 5;
            int i = (int)myObject;
            Console.WriteLine(i);
        }

    }
}
