using System;
using System.Linq;
using System.Reflection;

namespace Ch02_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            //CountingTypesAndMethods();
            //NameOf();
            //CS7_Digit_Separators();
            //PrimitiveTypeMaxValues();
            //NeverCompareDoublesUsingEquals();
            //UseDecimalInstead();
            //DynamicTypes();
            //GetDefaultValue();
            Null_CoalesingOperator();


            Console.WriteLine($"There are {args.Length} args.");
            Console.ReadLine();
        }

        static void CountingTypesAndMethods()
        {
            // loop through the assemblies that this app references
            foreach (var r in Assembly.GetEntryAssembly().GetReferencedAssemblies())
            {
                // load the assebly so we can read its details
                var a = Assembly.Load(new AssemblyName(r.FullName));

                // declare a var to count the total number of methods
                int methodCount = 0;

                // loop through all the types in the assembly
                foreach (var t in a.DefinedTypes)
                {
                    // add up the counts of methods
                    methodCount += t.GetMethods().Count();
                }

                // output the count of type s& their methods
                Console.WriteLine($"{a.DefinedTypes.Count():N0} types " +
                    $"with {methodCount:N0} methods in {r.Name} assembly.");
            }
        }

        static void NameOf()
        {
            double goldenRatio = 1.618;
            Console.WriteLine($"{nameof(goldenRatio)} is {goldenRatio}");
        }

        static void CS7_Digit_Separators()
        {
            int decimalNotation = 2_000_000;
            // int binaryNotation = 0b_0001_1110_1000_0100_1000_0000; // supported in CS 7.2
            // int hexadecimalNotation = 0x_001E_8480; // // supported in CS 7.2
            Console.WriteLine($"{decimalNotation:N0}");
        }

        static void PrimitiveTypeMaxValues()
        {
            Console.WriteLine();
            Console.WriteLine($"int uses {sizeof(int)} bytes to store between {int.MinValue:N0} and {int.MaxValue:N0}\n");
            Console.WriteLine($"int uses {sizeof(double)} bytes to store between {double.MinValue:N0} and {double.MaxValue:N0}\n");
            Console.WriteLine($"int uses {sizeof(decimal)} bytes to store between {decimal.MinValue:N0} and {decimal.MaxValue:N0}\n");
        }

        static void NeverCompareDoublesUsingEquals()
        {
            double a = 0.1;
            double b = 0.2;

            if (a + b == 0.3)
            {
                Console.WriteLine($"{a} + {b} equals {0.3}");
            }
            else
            {
                Console.WriteLine($"{a} + {b} does NOT equals {0.3}");
            }
        }

        static void UseDecimalInstead()
        {
            decimal a = 0.1M;
            decimal b = 0.2M;

            if (a + b == 0.3M)
            {
                Console.WriteLine($"{a} + {b} equals {0.3}");
            }
            else
            {
                Console.WriteLine($"{a} + {b} does NOT equals {0.3}");
            }
        }

        static void Unboxing()
        {
            object name = "Ray";
            int len = ((string)name).Length;
        }

        static void Boxing()
        {
            int age = 25;
            object o = age;
        }

        static void DynamicTypes()
        {
            dynamic compilerDoesNotcheckAtBuildTime = "Ray";
            int len = compilerDoesNotcheckAtBuildTime.Length;
        }

        static void GetDefaultValue()
        {
            Console.WriteLine();
            Console.WriteLine(default(int));
            Console.WriteLine(default(float));
            Console.WriteLine(default(double));
            Console.WriteLine(default(decimal));
            Console.WriteLine(default(string));
            Console.WriteLine(default(bool));
            Console.WriteLine(default(DateTime));
        }

        static void Nullables()
        {
            int iCannotBeNull;
            int? iCanBeNull = null;
        }

        static void Null_CoalesingOperator()
        {
            string authorName = null;
            int? howManyLetters = authorName?.Length;
            var result = howManyLetters ?? 3;
            Console.WriteLine($"{result}");
        }
    }
}