using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_Ctor_Instance_Priv_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();

            // Calling a static method
            Console.WriteLine(Math.Round(28.5));

            Car.Go();

            StructTest st = new StructTest(3, 5);
            st.DoWork();

            StructTest st2;
            st2.x = 3;
            st2.y = 8;
            st2.DoWork();

            Console.ReadLine();
        }
    }

    class Test
    {
        // There's also a default ctor
        
        // Either public or private
        public Test() {
            Console.WriteLine("ctor called...");
            DoWork();
        }

        // private Test() {}

        
        static Test() { // called only once, and before the 1st instance of the class is created 
        }

        // You can of course also have overloaded ctors

        public void DoWork()
        {
            Console.WriteLine("DoWork() called...");
        }
    }


    class Car
    {
        public static void Go()
        {
            Console.WriteLine("vrrmm, vrrmm");
        }
    }



    interface ITestInterface { };

    struct AStruct : ITestInterface // Can use ITestInterface
    {
        // A light version of class, but does not support inheritance
        // Is stored on the stack
        // Can inherit from Interfaces
        // CANNOT have a DEFAULT ctor, that is, a PARAMETERLESS ctor
        // Interesting enough, can use the 'new' key work to instantiate

        // public AStruct() { }   <-- cannot have ctor

        public int Name { get; set; }
    }


    struct StructTest
    {
        // CANNOT have instance prop or field initializers in structs
        public int x;
        public int y;

        public StructTest(int i, int j)
        {
            x = i;
            y = j;
        }

        public void DoWork()
        {
            Console.WriteLine($"DoWork(): {x + y}");
        }
    }
}
