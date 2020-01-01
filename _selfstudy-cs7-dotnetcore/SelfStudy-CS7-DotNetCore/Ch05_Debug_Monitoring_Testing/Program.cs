using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using static System.Console;

namespace Ch05_Debug_Monitoring_Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            //Debugging();
            //Monitoring();
            MeasuringEfficiencyOfProcessingStrings();


            ReadKey();
        }

        static void Monitoring()
        {
            Write("Press ENTER to start the timer: ");
            ReadLine();
            Recorder.Start();

            int[] largeArrayOfInts = Enumerable.Range(1, 10000).ToArray();

            Write("Press ENTER to stop the timer: ");

            ReadLine();

            Recorder.Stop();

            ReadLine();
        }

        static void MeasuringEfficiencyOfProcessingStrings()
        {
            int[] numbers = Enumerable.Range(1, 10000).ToArray();

            Recorder.Start();
            WriteLine("Using string");
            string s = "";
            for (int i = 0; i < numbers.Length; i++)
            {
                s += numbers[i] + ", ";
            }
            Recorder.Stop();

            Recorder.Start();
            WriteLine("Using StringBuilder");
            var builder = new StringBuilder();
            for (int i = 0; i < numbers.Length; i++)
            {
                builder.Append(numbers[i]);
                builder.Append(", ");
            }
            Recorder.Stop();
            ReadLine();
        }

        static double Add(double a, double b)
        {
            return a * b; // deliberate bug!
        }

        static void Debugging()
        {
            double a = 4.5; // or use var
            double b = 2.5;
            double answer = Add(a, b);
            Console.WriteLine($"{a} + {b} = {answer}");
        }
    }
}
