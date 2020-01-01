using System;

namespace Mod04_Classes_L1_RefValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            StaticDemo();

            Console.ReadLine();
        }

        private static void DoWork()
        {
            SimpleClass c1 = new SimpleClass() { Payload = "class 1" };
            SimpleStruct s1 = new SimpleStruct() { Payload = "struct 1" };
            SimpleClass c2 = c1;
            SimpleStruct s2 = s1;
            c2.Payload = "Second class";
            s2.Payload = "Second struct";

            Console.WriteLine($"struct\n\t{s1.Payload}\n\t{s2.Payload}\nclass\n\t{c1.Payload}\n\t{c2.Payload}");
        }

        private static void StaticDemo()
        {
            foreach (Customer cust in Utilities.GetCustomer())
            {
                Console.WriteLine($"{cust.Id}. {cust.Name}");
            }
        }

        private static void GenericDemo()
        {

        }
    }

    class SimpleClass
    {
        public string Payload { get; set; }
    }

    struct SimpleStruct
    {
        public string Payload { get; set; }
    }
}
