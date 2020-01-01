using System;
using System.Collections;
using System.IO;

namespace Ch03_CtrlFlow_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //PatternMatching();
            //RandomNumbers();
            //SwtchStmt();
            //IterationStmts();
            //IEnum();
            //ConvertingTypes();
            //TryParse();
            CheckingForOverflow();


            Console.ReadLine();
        }

        static void PatternMatching()
        {
            object o = "3";
            int j = 4;

            if (o is int i)
            {
                Console.WriteLine($"{i} * {j} = {i * j}");
            }
            else
            {
                Console.WriteLine($"{o.GetType()} is not an int");
            }
        }

        static void RandomNumbers()
        {
            var rndNum = new Random().Next(1, 3);
            Console.WriteLine(rndNum);
        }

        static void SwtchStmt()
        {
            string path = @"C:\TEMP";

            try
            {
                using (Stream s = File.Open(Path.Combine(path, "file.txt"), FileMode.OpenOrCreate))
                {
                    switch (s)
                    {
                        case FileStream writeableFile when s.CanWrite:
                            Console.WriteLine("The stream is to a file that I can write to.");
                            break;
                        case FileStream readonlyFile:
                            Console.WriteLine("The stream is to a read-only file.");
                            break;
                        case MemoryStream ms:
                            Console.WriteLine("The stream is to a memory address.");
                            break;
                        default:
                            Console.WriteLine("The stream is some other type.");
                            break;
                        case null:
                            Console.WriteLine("The stream is null.");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void IterationStmts()
        {
            int x = 0;
            while (x < 10)
            {
                Console.WriteLine($"{x}");
                x++;
            }

            string password = string.Empty;
            do
            {
                Console.Write("Enter password: ");
                password = Console.ReadLine();
            } while (password != "secret");

            Console.WriteLine("Access granted...");
        }

        static void IEnum()
        {
            string[] names = { "Ray", "Julie", "Parker" };

            // ForEach
            IEnumerator e = names.GetEnumerator();
            while (e.MoveNext())
            {
                Console.WriteLine($"{(string)e.Current}");
            }
        }

        private static void ConvertingTypes()
        {
            // A diff between casting & converting is that converting rounds
            // the double varle up to 10 instad of trimming the part after the decimal
            double g = 9.8;
            int h = Convert.ToInt32(g);
            Console.WriteLine($"g is {g}, and h is {h}");

            // Rounding in C# is subtle diffferent - it uses a rule known as the 'Banker's Rounding'
        }

        private static void TryParse()
        {
            Console.Write("How many eggs are there? ");
            int defaultIntValue;
            string input = Console.ReadLine();
            int myInt = (int.TryParse(input, out defaultIntValue) ? Convert.ToInt32(input) : defaultIntValue);
            Console.WriteLine(myInt);
        }

        // Throw an exception when an overflow occurs (at runtime)
        private static void CheckingForOverflow()
        {
            checked
            {
                int i = int.MaxValue - 1;
                Console.WriteLine(i);

                i++;
                Console.WriteLine(i);

                i++;
                Console.WriteLine(i);
            }
        }
    }
}
