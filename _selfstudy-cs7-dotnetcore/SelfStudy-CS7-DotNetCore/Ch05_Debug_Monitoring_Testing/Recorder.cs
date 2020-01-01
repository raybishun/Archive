using System;
using System.Collections.Generic;
using System.Diagnostics;
using static System.Diagnostics.Process;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05_Debug_Monitoring_Testing
{
    class Recorder
    {
        static Stopwatch timer = new Stopwatch();
        static long bytesPhysicalBefore = 0;
        static long bytesVirtualBefore = 0;

        public static void Start()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            bytesPhysicalBefore = GetCurrentProcess().WorkingSet64;
            bytesVirtualBefore = GetCurrentProcess().VirtualMemorySize64;
            timer.Restart();
        }

        public static void Stop()
        {
            timer.Stop();
            long bytesPhysicalAfter = GetCurrentProcess().WorkingSet64;
            long bytesVirtualAfter = GetCurrentProcess().VirtualMemorySize64;

            Console.WriteLine("Stopped recording.");
            Console.WriteLine($"{bytesPhysicalAfter - bytesPhysicalBefore:N0} physical bytes used.");
            Console.WriteLine($"{bytesVirtualAfter - bytesVirtualBefore:N0} virtual bytes used.");

            Console.WriteLine($"{timer.Elapsed} time span ellapsed.");
            Console.WriteLine($"{timer.ElapsedMilliseconds:N0} total milliseconds ellapsed.");
        }
    }
}
