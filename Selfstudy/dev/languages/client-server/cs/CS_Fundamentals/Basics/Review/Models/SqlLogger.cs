using System;

namespace Review.Models
{
    class SqlLogger : DbLogger
    {
        public override void WriteToLog()
        {
            // base.WriteToLog();
            Console.WriteLine("SqlLogger implementation...");
        }
    }
}
