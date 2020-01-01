using IronPython.Hosting;
using System;
using System.Dynamic;

/// <summary>
/// Note: Installed IronPython via NuGet
/// IronPython is an open-source implementation of the Python programming language which is tightly
/// integrated with the .NET Framework. IronPython can use the .NET Framework and Python libraries,
/// and other .NET languages can use Python code just as easily.
/// </summary>
namespace _2_11_Adv_TheDynamicKeyword_And_LateBinding
{
    class Program
    {
        static void Main(string[] args)
        {
            // DynamicDemo();
            // PythonRuntimeDemo();
            Expando_ObjectDemo();
        }

        static void DynamicDemo()
        {
            dynamic test = "string";
            Console.WriteLine(test.GetType());
            test = 5;
            Console.WriteLine(test.GetType());
        }

        private static void PythonRuntimeDemo()
        {
            // Prep work: On the properties for the Test.py file, change:
            // 1.Build Action: Content
            // 2.Copy to Output Directory: Copy always

            var pythonRuntime = Python.CreateRuntime();
            dynamic pythonFile = pythonRuntime.UseFile("Test.py");
            pythonFile.SayHelloToPython();
        }

        private static void Expando_ObjectDemo()
        {
            // ExpandoObject allows you to bypass all the compile
            // time checking that exists for this 'test' object.
            // And allows you to dynamically add properties at runtime
            // ExpandoObject is similar to 'ViewBag' in MVC
            dynamic test = new ExpandoObject();
            test.Name = "Ray";
            test.Age = 25;

            try
            {
                Console.WriteLine($"{test.Name}, {test.Age}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
