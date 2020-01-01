using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            // UsingMultipleCatchBlocks();
            

            Console.ReadLine();
        }

        static void UsingMultipleCatchBlocks()
        {
            Console.Write("Enter a path to a file: ");
            string pathName = Console.ReadLine();

            try
            {
                File.Open(pathName, FileMode.Create);

                Random r = new Random();
                int excToThrow = r.Next(1, 5);
                switch (excToThrow)
                {

                    // Possible File.Open() Exceptions
                    case 1:
                        throw new FileNotFoundException("File not found", pathName);
                    case 2:
                        throw new UnauthorizedAccessException();
                    case 3:
                        throw new PathTooLongException();
                    case 4:
                        throw new DirectoryNotFoundException();
                    case 5:
                        throw new ArgumentException();
                    default:
                        break;
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                try
                {
                    if (!EventLog.SourceExists("ExceptionDemo"))
                    {
                        EventLog.CreateEventSource("ExceptionDemo", "Application");
                    }

                    EventLog.WriteEntry("Program class", "Test Message...", EventLogEntryType.Error);
                    Console.WriteLine($"{DateTime.Now.ToString("hh:mm:ss:ffff")} :: {"Test Message..."}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

       
    }

    class MyAppExceptions : Exception
    {
        public static string MyException(string message)
        {
            return message;
        }
    }
}
