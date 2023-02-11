using System;
using System.Runtime.InteropServices;
using System.Threading;
// using System.Threading.Tasks;

namespace PoCMoveFileEx
{
    [Flags]
    enum MoveFileFlags
    { 
        MOVEFILE_REPLACE_EXISTING = 0x00000001,
        MOVEFILE_COPY_ALLOWED = 0x00000002,
        MOVEFILE_DELAY_UNTIL_REBOOT = 0x00000004,
        MOVEFILE_WRITE_THROUGH = 0x00000008,
        MOVEFILE_CREATE_HARDLINK = 0x00000010,
        MOVEFILE_FAIL_IF_NOT_TRACKABLE = 0x00000020
    }
    
    class Program
    {
        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)] 
        static extern bool MoveFileEx(string lpExistingFileName, string lpNewFileName, MoveFileFlags dwFlags);

        static void Main(string[] args)
        {
            var result = MoveFileEx(
                @"c:\temp\test1.txt",
                @"c:\temp\test2.txt",
                MoveFileFlags.MOVEFILE_COPY_ALLOWED | MoveFileFlags.MOVEFILE_REPLACE_EXISTING
            );

            if (!result)
            {
                var lastError = Marshal.GetLastWin32Error();
                Console.WriteLine(lastError);
            }

            // Console.ReadKey();
        }
    }
}
