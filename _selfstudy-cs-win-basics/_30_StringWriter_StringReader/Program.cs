using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_StringWriter_StringReader
{
    class Program
    {
        static void Main(string[] args)
        {
            StringReadWrite srw = new StringReadWrite();

            Console.ReadLine();
        }
    }

    #region "Write data using StringWriter"
    public class StringReadWrite
    {
        StringBuilder sb = new StringBuilder();

        public StringReadWrite()
        {
            WriteData();
            WriteData2();
            ReadDate();
        }

        private void WriteData()
        {
            StringWriter sw = new StringWriter(sb);

            Console.Write("Enter name: ");

            string name = Console.ReadLine();

            sw.WriteLine($"Name: {name}");

            sw.Flush();
            sw.Close();
        }

        private void WriteData2()
        {
            using (StringWriter sw = new StringWriter(sb))
            {
                Console.Write("Enter name: ");

                string name = Console.ReadLine();

                sw.WriteLine($"Name: {name}");
            }
        }

        private void ReadDate()
        {
            StringReader sr = new StringReader(sb.ToString());

            Console.WriteLine("\nreading the info...");

            while (sr.Peek() > -1)
            {
                Console.WriteLine(sr.ReadLine());
            }

            Console.WriteLine("\ndone...");
        }
    }
    #endregion  
}
