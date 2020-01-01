using System; 
using System.Linq;
using System.Reflection; 

/// <summary>
/// Note: Appears Reflection is only able to retrieve 'public' members
/// </summary> 
namespace _2_04_Adv_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reflection101();
            Reflection102();
        }

        static void Reflection101()
        {
            var assembly = Assembly.GetExecutingAssembly();
            Console.WriteLine(assembly.FullName);
            // Console output:  _2_4_AdvTopics_Reflection, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

            var types = assembly.GetTypes();
            foreach (var type in types)
            {
                Console.WriteLine($"Type: {type.Name}\t BaseType{type.BaseType}");

                var props = type.GetProperties();
                foreach (var prop in props)
                {
                    Console.WriteLine($"\tProperty: {prop.Name}\tPropertyType: {prop.PropertyType}");
                }

                var fields = type.GetFields();
                foreach (var field in fields)
                {
                    Console.WriteLine($"\tProperty: {field.Name}\tPropertyType: {field.FieldType}");
                }

                var methods = type.GetMethods();
                foreach (var method in methods)
                {
                    Console.WriteLine($"\tProperty: {method.Name}");
                }
            }

            var sampleClass = new Sample { MyPublicProperty = "Ray", myPublicInt = 25 };
            var sampleType = typeof(Sample);   // compile time operation
            var sampleType2 = sampleType.GetType(); // runtime operation

            var nameProperty = sampleType.GetProperty("MyPublicProperty");
            Console.WriteLine($"Property: {nameProperty.GetValue(sampleClass)}");

            // Invoking (executing) a method via Reflections
            var myMethod = sampleType.GetMethod("MyMethod");
            myMethod.Invoke(sampleClass, null);
        }

        static void Reflection102()
        {
            var assembly = Assembly.GetExecutingAssembly();

            var types = assembly.GetTypes().Where(t => t.GetCustomAttributes<MyClassAttribute>().Count() > 0);
            foreach (var type in types)
            {
                Console.WriteLine(type.Name);

                var methods = type.GetMethods().Where(m => m.GetCustomAttributes<MyMethodAttribute>().Count() > 0);
                foreach (var method in methods)
                {
                    Console.WriteLine(method.Name);
                }
            }
        }
    }
}
