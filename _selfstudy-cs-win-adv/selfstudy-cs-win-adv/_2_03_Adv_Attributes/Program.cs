using System;
using System.Linq;
using System.Reflection; 

namespace _2_03_Adv_Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            GetTypesUsingReflection();
        }

        static void GetTypesUsingReflection()
        {
            var types = from t in Assembly.GetExecutingAssembly().GetTypes()
                        where t.GetCustomAttributes<SampleAttribute>().Count() > 0
                        select t;

            foreach (var t in types)
            {
                Console.WriteLine($"{t.Name}\n");
            }

            foreach (var t in types)
            {
                Console.WriteLine(t.Name);

                foreach (var prop in t.GetProperties())
                {
                    Console.WriteLine(prop.Name);
                    Console.WriteLine(prop);
                }
            }
        }
    }
}
