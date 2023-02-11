using System;

namespace Review.Models
{
    class DbLogger : Logger
    {
        public override void WriteToLog()
        {
            // base.WriteToLog();
            Console.WriteLine("DbLogger implementation...");
        }
    }
}