using System;

namespace Review.Models
{
    class Logger
    {
        public virtual void WriteToLog()
        {
            Console.WriteLine("Logger implementation...");
        }
    }
}
