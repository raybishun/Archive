using System;
using System.Threading;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace RayMemLeakTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                LeakMem(); 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void LeakMem()
        {
            int ctr = 0;
            var list = new List<byte[]>();

            while (true)
            {
                ctr++;
                var byteObj = new byte[1024];
                GCHandle gch = GCHandle.Alloc(byteObj, GCHandleType.Pinned);
                IntPtr pByteObj = gch.AddrOfPinnedObject();
                Console.WriteLine($"{ctr:N0} --> Address allocated: {pByteObj}");
                list.Add(byteObj);
                
                // list.Add(new byte[1024]);
                // Thread.Sleep(10); 
            }
        }
    }
}
